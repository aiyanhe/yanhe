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
    class UserToken
    {
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

        public UserToken()
        {
            ReceSAEA = new SocketAsyncEventArgs();
            SendSAEA = new SocketAsyncEventArgs();
            Recath = new List<byte>();
            ReceSAEA.Completed += ReceSAEA_Completed;
            SendSAEA.Completed += SendSAEA_Completed;
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
        partial void Recive(SocketAsyncEventArgs e)
        {
            byte[] mby = new byte[e.BytesTransferred];
            Buffer.BlockCopy(e.Buffer, 0, mby, 0, e.BytesTransferred);
            Recive(mby);
        }
        /// <summary>
        /// 把接收数据添加到缓存，然后进行处理缓存数据
        /// </summary>
        /// <param name="mby"></param>
        partial void Recive(byte[] mby)
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
            //todo 处理缓存数据 进行 有长度编码做长度表

            //todo （可选）消息的解密

            //todo （可选）消息的解压

            //todo （必须）消息的解码-反序列，从二进制变成对象

            //todo 把数据通知应用层
        }
        /// <summary>
        /// 开始挂起监听
        /// </summary>
        public void StatrRecive()
        {
            try
            {
                Console.WriteLine("开始接收数据");
                bool t = socket.AcceptAsync(ReceSAEA);//AcceptAsync 开始一个异步操作来接受一个传入的连接尝试。
                if (t == false)
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
        ///  应用层进行发数据的接口
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
                Console.WriteLine(e.Message.ToString());
                throw;
            }
        
        }


    }
}
