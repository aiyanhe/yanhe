using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _025_udplient
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建udpclient 绑定ip跟端口号
            UdpClient udpClient =new UdpClient(new IPEndPoint(IPAddress.Parse("192.168.1.101"), 12345));
            //接收数据
            while (true)
            {
                IPEndPoint ipEnd = new IPEndPoint(IPAddress.Any, 0);
                byte[] buff = udpClient.Receive(ref ipEnd);//通过point确定数据来自哪个ip的端口号,返回值是一个字节数组，就是我们的数据
                Console.WriteLine("接收消息：" + buff);
            }

            udpClient.Close();
            Console.ReadKey();
        }
    }
}
