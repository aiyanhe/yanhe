using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_do_while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            do{
               Console.WriteLine(num);
               num++;
            }while(num<=10);
            //do while循环会首先执行一次循环体，然后进行条件判断 循环体的执行次数>=1;
            //while循环会进行条件判断，然后根据判断的结果去判定是否去循环体，循环体的执行次数>=0;
            Console.ReadKey();
        }
    }
}
