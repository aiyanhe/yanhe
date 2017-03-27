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
            Console.WriteLine("开始下载" + Thread.CurrentThread.ManagedThreadId);//当前线程的Id
            Thread.Sleep(2000);
            Console.WriteLine("下载完成");
        }
        static void Main(string[] args)
        {
            Task t = new Task(Text);//传递一个需要线程去执行的方法
            t.Start();

            TaskFactory tf = new TaskFactory();//开启一个任务工厂
            Task t2 = tf.StartNew(Text);
        }
    }
}
