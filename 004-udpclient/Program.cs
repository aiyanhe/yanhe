using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _004_udpclient
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建udpclient对象
            UdpClient udpClient = new UdpClient();
            while (true)
            {
                byte[] buff = Encoding.UTF8.GetBytes(Console.ReadLine());
                udpClient.Send(buff, buff.Length, new IPEndPoint(IPAddress.Parse("192.168.4.101"), 12345));
            }
            udpClient.Close();

        }
    }
}
