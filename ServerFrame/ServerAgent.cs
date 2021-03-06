﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerFrame
{

   public class ServerAgent
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

        /// <summary>
        /// 用户token缓存
        /// </summary>
        public UserToKenCache Cache;

        private SocketAsyncEventArgs saea;

        public ServerAgent()
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            

        }
        /// <summary>
        /// 开启服务器
        /// </summary>
        public void StartServer(ServerSetting sers)
        {
            this.sers = sers;
            semaphore = new Semaphore(sers.MaxAccept, sers.MaxAccept);//将默认配置对应上
            Cache = new UserToKenCache(200);
            try
            {
                socket.Bind(new IPEndPoint(IPAddress.Any, sers.point));//将默认配置对应上
                socket.Listen(100);
                StartListen(saea);
                Console.WriteLine("服务端已启用");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
        public void StartListen(SocketAsyncEventArgs saea)
        {
            if (saea==null)
            {
                saea = new SocketAsyncEventArgs();
               
            }
            else
            {
                saea.AcceptSocket = null;//初始化清空；
            }

            saea.Completed += Acction;//saea.Completed回调程序，在完成监听的时候执行委托
            bool jim = socket.AcceptAsync(saea);//这里线程不会阻塞，但异步线程正在等待用户接入，等到用户接入时，就会调用saea.Completed;
            //判断异步是否挂起
            //true   挂起监听，如果挂起表示我们没有立刻收到客户端的链接，（假阻塞）需要等待客户端接入进来，通过Completed事件通知服务器有客户端接入进来
            //false  没有挂起，没有挂起表示我们立刻收到了客户端链接,不会执行saea.Completed这个回调程序，所以需要自己手动执行
            if (!jim)//取反，如果jim为true,这里就为false条件，反之为true条件；因为当jim为false时，需要执行下面方法；但是只有if(ture)才会执行，这里就绕了一下；相当于if(jim==false){};
            {
                ListenTheUser(saea);//同步完成
            }
        }

        private void Acction(object sender, SocketAsyncEventArgs e)
        {
            ListenTheUser(e);
        }
        public void ListenTheUser(SocketAsyncEventArgs saea)
        {
            Console.WriteLine("有客户端连接上来了");
            // 保存客户信息 
            UserToken use = Cache.Pop();
            use.CloseProcess = ClientClose;
            use.socket = saea.AcceptSocket;
            
            //信号量减一 
            semaphore.WaitOne();
            // 通知应用层有客户端计接入 
            sers.Center.ClientAccept(use);

            //启动该客户端消息接收 
            use.StatrRecive();

            StartListen(saea);//重新开始监听
        }

        private void ClientClose(UserToken ut, string error)//在有错误时发的，停止客户端连接等处理
        {
            if (ut!=null)
            {
                lock (ut)//加锁，防止多个线程同时调用一个方法
                {
                    ut.CloseToken();
                }
                // 通知应用层有客户端断开

                sers.Center.ClientClose(ut,error);

                //回收token到缓存
                Cache.Push(ut);


                //一个客户端离开，信号量加1
                semaphore.Release();
            }
            
        }

    }

}
