using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _012__线程_委托方式发起线程
{
    class Program
    {
        //一般我们会为比较耗时的操作 开启单独的线程去执行，比如下载操作
        static int Test(int i,string str)
        {
            Console.WriteLine("test"+i+str);
            Thread.Sleep(100);//让当前线程休眠（暂停线程的执行）单位ms（毫秒）
            return 100;
        }
        static void Main(string[] args)//在main线程中执行 一个线程里面语句的执行是从上到下
        {
            //下载文件 code 这里可以开启一个线程 

            //移动文件 code 这里也可以开启一个线程

            //线程结束时间不确定；

            //1.通过委托，开启一个线程
            Func<int, string, int> a = Test;
            IAsyncResult ar = a.BeginInvoke(100,"siki",null,null);//开启一个新的线程去执行a所引用的方法（BeginInvoke开启一个新线程）
            //BeginInvoke参数里的两个null:第一个参数是回调方法委托类型，这个委托只有一个参数，就是IAsyncResult
            //BeginInvoke的第二个参数需要向MethodCompleted方法中传递一些值，一般可以传递被调用方法的委托
            //IAsyncResult可以取得当前线程的状态
            //可以认为线程是同时执行的（异步执行）
            Console.WriteLine("main");
            while (ar.IsCompleted==false)//如果当前线程没有执行完毕
            {
                Console.Write(".");
                Thread.Sleep(10);//控制子线程的检测频率
            }
            int res = a.EndInvoke(ar);//取得异步线程的返回值（EndInvoke是异步线程的返回值）
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
