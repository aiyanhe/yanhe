using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _022__socket编程_TCP协议
{
    class Program
    {
        static void Main(string[] args)
        {
            //1，创建socket
            Socket tcpServer = new Socket
            (AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            //2,绑定ip跟端口号 192.168.1.101
            IPAddress ipaddress = new IPAddress(new byte[]{192,168,1,101});
            EndPoint point = new IPEndPoint(ipaddress,7788);//ipendpoint是对ip+端口做了一层封装的类
            tcpServer.Bind(point);//向操作系统申请一个可用的ip跟端口号用来做通信
            //3,开始监听（等待客户端连接）
            tcpServer.Listen(100);//参数是最大连接数
            Socket clientScoket = tcpServer.Accept();
            string message = "hello";
            byte[] data = Encoding.UTF8.GetBytes(message);//对字符串做编码，得到一个字符串的字节数组
            clientScoket.Send(data);
        }
    }
}
