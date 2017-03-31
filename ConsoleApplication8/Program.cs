using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipaddress = new IPAddress(new byte[]{192,168,4,137});
            EndPoint point = new IPEndPoint(ipaddress,7788);
            mySocket.Bind(point);
            mySocket.Listen(100);
            Socket clientScoket = mySocket.Accept();
        }
    }
}
