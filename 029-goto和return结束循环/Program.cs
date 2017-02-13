using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_循环的中断continue_goto和return结束循环_2_
{
    class Program
    {
        static void Main(string[] args)
        {
         //   string str;
         //while(true)
         //{
         //    str=Console.ReadLine();
         //    if (str == "0")
         //    {
         //        goto si;//当str==0字符时，直接到si标签处，以此来结束循环；不过不建议这种结束循环的方式；
         //    }
         //}
         //   si:
         //   Console.ReadKey();


            string str;
            while (true)
            {
                str = Console.ReadLine();
                if (str == "0")
                {
                    return;//当运行到return时，直接结束Mian函数循环，所有看不到下面输出的字符;
                }
               }
            Console.WriteLine("看不见我");
            Console.ReadKey();
        }
    }
}
