using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerFrame;
namespace MyServer
{
    class HandlerCenter:AbsHandlerCenter
    {
        public override void ReceiveMessage(UserToken Uto, object message)
        {
            Console.WriteLine("接收到{0}用户的{1}信息",Uto.ReceSAEA.RemoteEndPoint,message);
        }

        public override void ClientAccept(UserToken Uto)
        {
            throw new NotImplementedException();
        }

        public override void ClientClose(UserToken Uto, string error)
        {
            throw new NotImplementedException();
        }
    }
}
