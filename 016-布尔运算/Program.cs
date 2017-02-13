using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_布尔运算
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 50;
            bool srt = num >= 20;//在这里》=就是一个比较运算符，用来比较score是否大于等于20，如果是的话返回true,如果不是的话返回false;
            bool srtd = num >= 100;
            Console.WriteLine(srt);
            Console.WriteLine(srtd);
            Console.ReadKey();

        }
    }
}
