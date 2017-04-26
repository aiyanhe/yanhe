using NetCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerFrame
{
    /// <summary>
    /// 一个UserToken类代表一个客户端
    /// </summary>
   public class UserToken
    {
       /// <summary>
       /// 用来承载远端用户的ip等信息
       /// </summary>
        public Socket socket;

        /// <summary>
        /// 接收数据
        /// </summary>
        public SocketAsyncEventArgs ReceSAEA;
        /// <summary>
        /// 发送数据
        /// </summary>
        public SocketAsyncEventArgs SendSAEA;
        /// <summary>
        /// 缓存接收数据列表
        /// </summary>
        public List<byte> Recath;
        /// <summary>
        /// 是否开始接收
        /// </summary>
        public bool isRecive = false;
        /// <summary>
        /// 用来承载错误信息的，当监听结束的时候执行的该委托
        /// </summary>
        /// <param name="ut"></param>
        /// <param name="error"></param>
        public delegate void ClientClose(UserToken ut, string error);
        /// <summary>
        /// 委托ClientClose声明的对象；
        /// </summary>
        public ClientClose CloseProcess;

        /// <summary>
        /// 用来缓存发送消息的队列
        /// </summary>
        public Queue<byte[]> queue  = new Queue<byte[]>();
        /// <summary>
        /// 是否发送消息
        /// </summary>
        public bool isSend = false;

        /// <summary>
        /// 服务器默认配置声明的对象(其实是给所有客户端配置好解码器等工具)
        /// </summary>
        public static ServerSetting Setting;

        public UserToken()
        {
            ReceSAEA = new SocketAsyncEventArgs();
            SendSAEA = new SocketAsyncEventArgs();
            Recath = new List<byte>();
            ReceSAEA.Completed += ReceSAEA_Completed;
            SendSAEA.Completed += SendSAEA_Completed;

            //设置数据接收的缓存
            ReceSAEA.SetBuffer(new byte[1024],0,1024);
        }

        private void ReceSAEA_Completed(object sender, SocketAsyncEventArgs e)
        {
            ProcessRece(e);
        }
        private void SendSAEA_Completed(object sender, SocketAsyncEventArgs e)
        {
            ProcessSend(e);
        }

        #region 接收消息
        private void ProcessRece(SocketAsyncEventArgs e)
        {
            if (e.BytesTransferred > 0 && e.SocketError == SocketError.Success)
            {
                Recive(e);
                StatrRecive();//重新挂起监听
            }
            else
            {
                string error;
                if (e.SocketError == SocketError.Success)//当用户主动断开连接的时候，会向服务端发送消息，但没字节传入
                {
                    error = "用户主动断开了连接";
                }
                else
                {
                    error = e.SocketError.ToString();
                }

                //断开连接的时候
                if (CloseProcess != null)
                {
                    CloseProcess(this, error);
                }
            }
        }

        /// <summary>
        /// 拷贝接收缓存数据
        /// </summary>
         private void Recive(SocketAsyncEventArgs e)
        {
            byte[] mby = new byte[e.BytesTransferred];
            Buffer.BlockCopy(e.Buffer, 0, mby, 0, e.BytesTransferred);
            Recive(mby);
        }
        /// <summary>
        /// 把接收数据添加到缓存，然后进行处理缓存数据
        /// </summary>
        /// <param name="mby"></param>
         private void Recive(byte[] mby)
        {
            Recath.AddRange(mby);
            if (isRecive == false)
            {
                isRecive = true;
                OnRecive();
            }
        }

        private void OnRecive()
        {
            byte[] bt;
            //处理缓存数据 进行 有长度解码做长度表
            if (Setting.LengthDncoad==null)
            {
                //无长度解码器
                if (Recath.Count==0)//没有缓存数据
                {
                    isRecive = false;
                    return;
                }
                bt = Recath.ToArray();
                Recath.Clear();
                
            }
            else
            {
                //有长度解码器
                bt = Setting.LengthDncoad(ref Recath);
                if (bt==null)
                {
                    Console.WriteLine("消息不全，无法进行长度解码");
                    isRecive = false;
                    return;
                    
                }
            }

            //（可选）消息的解密
            if (Setting.MessageDecrypt!=null)
            {
                bt = Setting.MessageDecrypt(bt);
            }



            // （可选）消息的解压
            if (Setting.CompressDecode!=null)
            {
                bt = Setting.CompressDecode(bt);
            }



            // （必须）消息的解码-反序列，从二进制变成对象
            object ob;
            if (Setting.MessageDncoad==null)
            {
                throw new Exception("必须有消息解码器");
            }
            else
            {
                 ob= Setting.MessageDncoad(bt);
            }
            // 把数据通知应用层
            Setting.Center.ReceiveMessage(this,ob);
            OnRecive();//仅仅是为了归位isRecive

        }
        /// <summary>
        /// 开始挂起监听,供上层调用客户端的接收消息方法
        /// </summary>
        public void StatrRecive()
        {
            try
            {
                Console.WriteLine("开启用户{0}接收数据",socket.RemoteEndPoint);
                bool t = socket.ReceiveAsync(ReceSAEA);//ReceiveAsync 开始一个异步请求以便从连接的 System.Net.Sockets.Socket 对象中接收数据。这里线程会阻塞；
                if (!t)
                {
                    ProcessRece(ReceSAEA);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        #endregion

        #region 发送消息
        /// <summary>
        /// 处理发送数据
        /// </summary>
        /// <param name="e"></param>
        private void ProcessSend(SocketAsyncEventArgs e)
        {
            //先判断连接是否正常
            if (e.SocketError==SocketError.Success)
            {
                OnSend();
            }
            else
            {
                if (CloseProcess!=null)
                {
                    CloseProcess(this,e.SocketError.ToString());
                }
            }

        }
        /// <summary>
        /// 从队列中加载发送消息到SendSAEA缓冲区
        /// </summary>
        private void OnSend()
        {
            if (queue.Count==0)//队列中没有想要发送的消息
            {
                isSend = false;
                return;
            }
            byte[] bt = queue.Dequeue();//将队列的开头数据移除并赋值带buff上
            SendSAEA.SetBuffer(bt,0,bt.Length);//将数据传入到SendSAEA的数据缓冲区

            StartSend();//开始启动传送消息
        }
        /// <summary>
        /// 启动实际的发送功能
        /// </summary>
        private void StartSend()
        {
            
            bool s = socket.SendAsync(SendSAEA);//SendAsync 将数据异步发送到连接的 System.Net.Sockets.Socket 对象。
            if (!s)
            {
                ProcessSend(SendSAEA);//再次挂起监听
            }
        }

        /// <summary>
        ///  应用层进行发数据的接口(接收byte[])
        /// </summary>
        public void Send(byte[] bt)
        { 
            //先检查连接是否正常
            if (socket==null)
            {
                if (CloseProcess!=null)
                {
                    CloseProcess(this,"用户断开了连接");
                }
                return;
            }
            queue.Enqueue(bt);//将想要发送的消息添加到缓存队列中
            if (isSend==false)//数据已经加载到队列中了，可以发送了；
            {
                isSend = true;
            }
            OnSend();
        }

        /// <summary>
        ///  应用层进行发数据的接口(接收NetModle)
        /// </summary>
        public void Send(NetModle nm)//如果用户想要发送的消息时NetModle模块时，先进行消息编码和长度编码
        {
            if (Setting.MessageEncoad==null)
            {
                isSend = false;
                throw new Exception("消息编码必须存在");
            }
            byte[] bt = Setting.MessageEncoad(nm);
            //消息压缩，可选
            if (Setting.CompressEncode!=null)
            {
                bt = Setting.CompressEncode(bt);
            }
            // 消息加密，可选
            if (Setting.MessageEncrypt!=null)
            {
                bt =Setting.MessageEncrypt(bt);
            }
            if (Setting.LengthEncoad!=null)
            {
                bt = Setting.LengthEncoad(bt);
            }
            Send(bt);

        }

        #endregion
        /// <summary>
        /// 客户端里面的关闭功能
        /// </summary>
        public void CloseToken()
        {
            //清理列表，队列，将开关设为默认关闭状态
            isRecive = false;
            isSend = false;
            Recath.Clear();
            queue.Clear();
            try
            {
                //判断并关闭socket
                if (socket!=null)
                {
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                    socket = null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        
        }


    }
}
