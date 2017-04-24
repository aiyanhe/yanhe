using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProtocol;
using MyProtocol.Common;
using MyProtocol.Protol;
using NetCommon;
using ServerFrame;

    /// <summary>
    /// 扩展UserToken的类
    /// </summary>
    public static class ExUserToken
    {
    //c#参数带this
    //这是 .NET 3.0 之后新增的一种特性，叫“扩展方法”。
    // 扩展方法能够向现有类型“添加”方法，而无需创建新的派生类型、重新编译或以其他方式修改原始类型。扩展方法是一种特殊的静态方法，但可以像扩展类型上的实例方法一样进行调用


    /// <summary>
    /// 使用默认协议，默认命令号的UserToken.Send
    /// </summary>
    /// <param name="token">this UserToken 客户端</param>
    /// <param name="error">ErrorCode 要发给客户端的消息</param>
    public static void Send(this UserToken token,ErrorCode error)
        {
           Send(token,Protocol.Common,CommonProtocol.C2S_HearBeat,error);
        }
    /// <summary>
    /// 使用指定协议，指定命令号的UserToken.Send
    /// </summary>
    /// <param name="token">this UserToken 客户端</param>
    /// <param name="protocol">协议</param>
    /// <param name="commond">CommonProtocol 命令号</param>
    /// <param name="message">要发送的消息</param>
    public static void Send(this UserToken token,Protocol protocol,short commond,object message =null)
        {
            NetModle netModle = new NetModle();
            netModle.Type = protocol;
            netModle.Command = commond;
            netModle.Message = message;
            token.Send(netModle);

        }



    }

