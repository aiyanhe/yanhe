using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerFrame
{

    class ServerAgent
    {
        /// <summary>
        /// 服务器Socket
        /// </summary>
        public Socket socket;

        /// <summary>
        /// 服务器默认配置类
        /// </summary>
        ServerSetting sers;

        /// <summary>
        /// Semaphore
        /// 是一件可以容纳N人的房间，如果人不满就可以进去，如果人满了，就要等待有人出来。对于N=1的情况，称为binary semaphore。一般的用法是，用于限制对于某一资源的同时访问。
        /// </summary>
        public Semaphore semaphore;

        private ServerAgent()
        {
            socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

        }
        /// <summary>
        /// 开启服务器
        /// </summary>
        public void StartServer(ServerSetting sers)
        {
            socket.Bind(new IPEndPoint(IPAddress.Any, sers.point));//将默认配置对应上
            semaphore = new Semaphore(sers.MaxAccept,sers.MaxAccept);//将默认配置对应上
            socket.Listen(100);
            StartListen();
            Console.WriteLine("服务端已启用");
        }
        public void StartListen()
        {
            SocketAsyncEventArgs saea = new SocketAsyncEventArgs();
            saea.Completed += Acction;
            bool jim = socket.AcceptAsync(saea);
            if (!jim)
            {
                ListenTheUser(saea);
            }

        }

        private void Acction(object sender, SocketAsyncEventArgs e)
        {
            ListenTheUser(e);
        }
        public void ListenTheUser(SocketAsyncEventArgs saea)
        {
            Console.WriteLine("有客户端连接上来了");
            //TODO  保存客户信息 
            UserToken use = new UserToken();


            //信号量减一 
            semaphore.WaitOne();
            //TODO  通知应用层有客户端计接入 
            //TODO  启动该客户端消息接收 

            StartListen();//重新开始监听
        }
    }

}
