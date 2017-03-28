using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _013__线程_通过Thread发起线程
{
    class Program
    {
        public static void DownloadFile(object fileName)
        {
            Console.WriteLine("开始下载"+fileName);
            Thread.Sleep(2000);
            Console.WriteLine("下载完成");
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(DownloadFile);//创建出来Thread对象，这个线程并没有启动
            t.Start("xxx.种子");//开始去执行线程

            //使用lambda表达式
            Thread a = new Thread(o => {
                Console.WriteLine("开始下载"+o);
                Thread.Sleep(2000);
                Console.WriteLine("下载完成");
            });
            a.Start("jjj.种子");

            MyThread my = new MyThread("xxx.bt","http://www.xxx.bbs");
            Thread h = new Thread(my.Text);//我们构造一个thread对象的时候，可以传递一个静态方法，也可以传递一个对象的普通方法
            h.Start();

            Thread q = new Thread(DownloadFile);//默认为前台线程
            q.IsBackground = true;//设置为后台线程
            q.Start();
            //q.Abort();//终止这个线程的执行
            q.Join();//当前线程睡眠，等待q线程执行完，然后继续运行下面的代码
            Console.ReadKey();
        }
    }
}
