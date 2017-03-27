using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021__线程问题_争用问题和锁
{
    class MyThreedObject
    {
        public int num = 5;
        public void State()//有两个任务使用操作同一个数据num，会产生当一个线程判断if(num==5)时
                                    //一个线程正在num=5，就会条件为true，这就是线程的争用；
        {
            num++;
            if (num==5)
            {
                Console.WriteLine("num="+num);
            }
            num = 5;
        }
    }
}
