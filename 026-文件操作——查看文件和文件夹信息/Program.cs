using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_文件操作__查看文件和文件夹信息
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path1 = "TextFile1.txt";//相对路径
            //string path2 = @"G:\paixun\yanhe\yanhe\026-文件操作——查看文件和文件夹信息\bin\Debug\TextFile1.txt";//绝对路径
            //FileInfo fileInfo = new FileInfo(path1);
            //if (fileInfo.Exists==false)//如果文件不存在
            //{
            //    fileInfo.Create();//就创建一个
            //}
            //Console.WriteLine("当前文件的大小" + fileInfo.Length);
            //Console.WriteLine("表示目录的完整路径的字符串。" + fileInfo.DirectoryName);
            //Console.WriteLine("获取指示文件是否存在的值" + fileInfo.Exists);
            //Console.WriteLine("如果当前文件为只读，则为 true；否则为 false。" + fileInfo.IsReadOnly);
            //Console.WriteLine("获取文件名" + fileInfo.Name);
            //fileInfo.Delete();//删除输出目录下的文件，但工程文件还在


            //文件夹操作(目录操作)(按照完整路径名创建)
            //查看Debug文件夹的信息
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\爱言和\Desktop\Statr");
            Console.WriteLine(dirInfo.Exists);
            Console.WriteLine(dirInfo.Name);
            Console.WriteLine(dirInfo.Parent);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.CreationTime);
            dirInfo.CreateSubdirectory("test");
            DirectoryInfo dirInfo2 = new DirectoryInfo("test2");
            if (dirInfo2.Exists==false)
            {
                dirInfo2.Create();//创建目录
            }
            Console.ReadKey();

        }
    }
}
