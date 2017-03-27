using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _021__线程问题_争用问题和锁
{
    class Program
    {
        public  static void dd(object d)
        {
            MyThreedObject rr = d as MyThreedObject;
            while (true)
            {
                //锁住这个数据，先自己调用，其他线程不允许调用
                lock (rr)//当其他线程要用这个数据的时候，会等待这个数据被解锁，解锁后再调用；
                {
                    rr.State();
                }//解锁

            }
           
        }
        static void Main(string[] args)
        {
            MyThreedObject m = new MyThreedObject();
            Thread t = new Thread(dd);
                t.Start(m);//让其使用数据m

                while (true)
                {
                    new Thread(dd).Start(m);//让其使用数据m，与上面使用同一个数据；
                }
        }
    }
}
