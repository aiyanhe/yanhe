using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_使用FileStream读写文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.创建文件流 用来操作文件
            FileStream stream = new FileStream("TextFile1.txt",FileMode.Open);
            //2.读取或者写入数据
            byte[] data = new byte[1024];//数据容器
            //1 byte = 1字节 1024byte = 1KB 1024KB = 1MB
            while (true)
            {
                int length = stream.Read(data, 0, data.Length);
                if (length==0)
                {
                    Console.WriteLine("读取结束");
                    break;
                }
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(data[i]+"");
                }
            }
            //使用filestream完成文件复刻
            //1.5MB = 1.5*1024KB
            FileStream readStream = new FileStream("言和.jpeg", FileMode.Open);
            FileStream writeStream = new FileStream("言和.png", FileMode.Create);
            byte[] bt = new byte[1024];
            while (true)
            {
                int length2 = readStream.Read(bt, 0, bt.Length);
                if (length2==0)
                {
                    Console.WriteLine("读取结束");
                    break;
                }
                else
                {
                    writeStream.Write(bt,0,length2);
                }
            }

        }
    }
}
