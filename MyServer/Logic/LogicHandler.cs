using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProtocol;
using NetCommon;
using ServerFrame;

namespace MyServer
{
    /// <summary>
    /// 逻辑处理模块，处理接口IHander
    /// </summary>
    class LogicHandler : IHander
    {
        /// <summary>
        /// 获取当前协议Protocol的子模块
        /// </summary>
        public Protocol Protocol
        {
            get { return Protocol.Login; }
        }
        /// <summary>
        /// 处理当前用户断开链接
        /// </summary>
        /// <param name="token"></param>
        /// <param name="error"></param>
        public void ClientClose(UserToken token, string error)
        {
            
        }
        /// <summary>
        /// 处理当前用户接收到的信息
        /// </summary>
        /// <param name="token"></param>
        /// <param name="modle"></param>
        public void ReciveMessage(UserToken token, NetModle modle)
        {
            switch (modle.Command)//根据当前用户的消息模块的命令号
            {
                case LoginProtocol.C2S_Login:
                    //todo Login
                    Console.WriteLine("登入功能。。。。未完成");

                break;
                case LoginProtocol.C2S_Register:
                    //todo Reister
                    Console.WriteLine("注册功能。。。。未完成");
                    break;
                    
            }
        }
    }
}
