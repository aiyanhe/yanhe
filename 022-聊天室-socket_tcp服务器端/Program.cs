using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _022_聊天室_socket_tcp服务器端
{
    class Program
    {
        static List<Client> clientList = new List<Client>();
        static void Main(string[] args)
        {
             int listenNum = 1;
             int MaxListenNum = 100;
            Socket MainSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            MainSocket.Bind(new IPEndPoint(new IPAddress(new byte[]{192,168,1,101}),6688));
            MainSocket.Listen(MaxListenNum);
            while (listenNum <= MaxListenNum)
            {
                Socket Cast = MainSocket.Accept();//等待客户端连接
                Client client = new Client(Cast);//把与每个客户端通信的逻辑（收发消息）放到Client类里面进行处理
                clientList.Add(client);
            }
            
        }
    }
}
