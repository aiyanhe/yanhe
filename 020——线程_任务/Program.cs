using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _020__线程_任务
{
    class Program
    {
        public static void Text()
        {
            Console.WriteLine("t1父级任务开始下载" + Thread.CurrentThread.ManagedThreadId);//当前线程的Id
           
            Thread.Sleep(2000);
            Task t3 = new Task(Text3);
            t3.Start();
            Console.WriteLine("t1父级任务完成");
        }
        public static void Text2(Task k)
        {
            Console.WriteLine("Text2开始下载" + Thread.CurrentThread.ManagedThreadId);//当前线程的Id
            Thread.Sleep(2000);
            Console.WriteLine("Text2下载完成");
        }
        public static void Text3()
        {
            Console.WriteLine("子级任务开始");
            Thread.Sleep(5000);
            Console.WriteLine("子级任务完成");
        }
        static void Main(string[] args)
        {
            Task t = new Task(Text);//传递一个需要线程去执行的方法
            t.Start();
            Console.WriteLine("父级任务未完成时状态" + t.Status);
            Thread.Sleep(2000);
            Console.WriteLine("父级任务完成时状态" + t.Status);
            Thread.Sleep(8000);
            Console.WriteLine("父级任务完成时状态" + t.Status);
            //连续任务ContinueWith
            //Task t1 = t.ContinueWith(Text2);//当t任务完成后才执行t1任务
            //t1.Start();//连续任务的下级任务不用Start();
            TaskFactory tf = new TaskFactory();//开启一个任务工厂
            //Task t2 = tf.StartNew(Text);
            Console.ReadKey();
        }
    }
}
