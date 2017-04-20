using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MyProtocol;
using MyServer;
using MyServer.Common.Tools;
using NetCommon;
using ServerFrame;
using MyServer.Biz;

namespace MyServer
{
    
    /// <summary>
    /// 逻辑处理模块，处理接口IHander
    /// </summary>
    class LogicHandler : IHander
    {
        /// <summary>
        /// 通过biz管理器声明的子biz AccoutBiz类
        /// </summary>
        private AccoutBiz accoutBiz = BizManager.Get<AccoutBiz>();
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
                    //Login
                    //Console.WriteLine("登入功能。。。。未完成");
                    Login(token,modle.GetMessage<AccountDto>());
                break;
                case LoginProtocol.C2S_Register:
                    //Reister
                    //Console.WriteLine("注册功能。。。。未完成");
                    Register(token,modle.GetMessage<AccountDto>());
                    break;
                    
            }
        }
        /// <summary>
        /// 登录，需要客户端和用户的账号密码信息 UserToken和AccountDto
        /// </summary>
        /// <param name="token"></param>
        /// <param name="accountDto"></param>
        private void Login(UserToken token, AccountDto accountDto)
        {
            ExecutorManager.Execute(() =>
            {
                ErrorCode error = accoutBiz.Login(token, accountDto.Account, accountDto.Password);
                if (error== ErrorCode.Success)
                {
                    //通知用户登录成功
                    token.Send(Protocol.Login,LoginProtocol.S2C_Login);
                }
                else
                {
                    //把错误代码发给用户
                    token.Send(error);
                }

            });


        }
        /// <summary>
        /// 注册，需要客户端和用户的账号密码信息 UserToken和AccountDto
        /// </summary>
        /// <param name="token"></param>
        /// <param name="accountDto"></param>
        private void Register(UserToken token, AccountDto accountDto)
        {
            ExecutorManager.Execute(() =>
            {
               accoutBiz.Create(token,accountDto);
            });
        }

 
    }
}
