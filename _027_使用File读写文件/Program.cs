using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_使用File读写文件
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = File.ReadAllLines("TextFile1.txt");//读写文件，把每一行文本读取成一个字符串，最后组成一个字符串的数组
            foreach (var s in strArray)
            {
                Console.WriteLine(s);
            }
            string a = File.ReadAllText("TextFile1.txt");//打开一个文本文件，读取文件的所有行，然后关闭该文件。
            Console.WriteLine(a);

            File.WriteAllText("TextFile2.txt", "阿斯伯格爱言和");//创建一个新文件，在其中写入指定的字符串，然后关闭文件。 如果目标文件已存在，则覆盖该文件。
            File.WriteAllLines("TextFile2.txt", new string[] { "sjadksak", "254855641", "阿斯伯格爱言和" });//创建一个新文件，在其中写入指定的字符串数组，然后关闭该文件。

            byte[] data = File.ReadAllBytes("言和.jpeg");// 打开一个文件，将文件的内容读入一个字符串，然后关闭该文件。
            foreach (var b in data)
            {
                Console.WriteLine(b);
            }
            File.WriteAllBytes("4.png", data);//创建一个新文件，在其中写入指定的字节数组，然后关闭该文件。 如果目标文件已存在，则覆盖该文件。
        }
    }
}
