using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_while循环
{
    class Program
    {
        static void Main(string[] args)
        {
          //while(true)//死循环，一直执行循环体，停不下来;
          //{
          //    Console.WriteLine("爱言和");
          //}
          //while循环会进行条件判断，然后根据判断的结果去判定是否去循环体，循环体的执行次数>=0;
            int TY = 1;
            while (TY <= 10) 
            {
                Console.WriteLine("爱言和的第"+TY+"天");
                TY++;
            }
            Console.ReadKey();
        }
    }
}
