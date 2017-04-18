using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProtocol;
using NetCommon;
using ServerFrame;

namespace MyServer
{/// <summary>
/// 逻辑处理模块接口，如处理该模块对应的协议Protocol，接收到的消息ReciveMessage，用户断开链接ClientClose；
/// </summary>
    public interface IHander
    {
        /// <summary>
        /// 处理该模块对应的协议
        /// </summary>
        Protocol Protocol { get; }
        /// <summary>
        /// 接收到的消息
        /// </summary>
        /// <param name="token"></param>
        /// <param name="modle"></param>
        void ReciveMessage(UserToken token ,NetModle modle);
        /// <summary>
        /// 用户断开链接
        /// </summary>
        /// <param name="token"></param>
        /// <param name="error"></param>
        void ClientClose(UserToken token ,string error);

    }
}
