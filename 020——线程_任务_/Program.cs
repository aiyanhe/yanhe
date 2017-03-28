using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _020__线程_任务_
{
    class Program
    {
        public static void Test()
        {
            Console.WriteLine("任务开始");
            Thread.Sleep(2000);
            Console.WriteLine("任务完成");

        } 
        static void Main(string[] args)
        {
            Task t = new Task(Test);
            t.Start();

            TaskFactory tf = new TaskFactory();
            Task l = tf.StartNew(Test);
            l.Start();

            Console.ReadKey();
        }
    }
}
