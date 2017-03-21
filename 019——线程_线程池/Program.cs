using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _019__线程_线程池
{
    class Program
    {
        public static void  Text(object fileName)//线程池中的方法必须要有参数
        {
            Console.WriteLine("开始下载"+Thread.CurrentThread.ManagedThreadId);//当前线程的Id
            Thread.Sleep(2000);
            Console.WriteLine("下载完成");
        }
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(Text);
            ThreadPool.QueueUserWorkItem(Text);
            ThreadPool.QueueUserWorkItem(Text);
            ThreadPool.QueueUserWorkItem(Text);
            ThreadPool.QueueUserWorkItem(Text);
            ThreadPool.QueueUserWorkItem(Text);
            Console.ReadKey();
        }
    }
}
