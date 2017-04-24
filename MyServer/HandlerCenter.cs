using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using MyProtocol;
using MyProtocol.Protol;
using NetCommon;
using ServerFrame;


namespace MyServer
{
    class HandlerCenter:AbsHandlerCenter
    {
        /// <summary>
        /// 键为协议，值为处理协议接口的字典
        /// </summary>
        Dictionary<Protocol,IHander> dicHandlers =new Dictionary<Protocol, IHander>();

        public HandlerCenter()
        {
            Addhandler<LogicHandler>();
        }
        #region 逻辑处理模块的管理

        /// <summary>
        /// 确定字典有该模块的协议Protocol
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private void Addhandler<T>() where T:IHander,new()
        {
           T handler =new T();
            if (dicHandlers.ContainsKey(handler.Protocol))
            {
                return;
            }
            dicHandlers.Add(handler.Protocol,handler);
        }
        /// <summary>
        /// 通过字典根据协议得到处理接口
        /// </summary>
        /// <param name="protocol"></param>
        /// <returns></returns>
        private IHander GetHandler(Protocol protocol)
        {
            IHander hander;
            if (dicHandlers.TryGetValue(protocol,out hander))//在字典找寻对应的值
            {
                return hander;
            }
            return null;
        }
#endregion
        public override void ReceiveMessage(UserToken Uto, object message)
        {
            Console.WriteLine("接收到{0}用户的{1}信息",Uto.ReceSAEA.RemoteEndPoint,message);
            NetModle modle =(NetModle)message;//消息模块化
            IHander hander = GetHandler(modle.Type);//得到消息对应的模块号
            if (hander ==null)
            {
                Console.WriteLine("hander==null");
                return;
            }
            hander.ReciveMessage(Uto, modle);//消息塞进去
        }

        public override void ClientAccept(UserToken Uto)
        {
            Console.WriteLine("有用户接入");
        }

        public override void ClientClose(UserToken Uto, string error)
        {
            Console.WriteLine("有用户离开");
        }
    }
}
