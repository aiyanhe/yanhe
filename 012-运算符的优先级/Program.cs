using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_运算符的优先级
{
    class Program
    {
        static void Main(string[] args)
        {
            //编程运算的优先级按数学上的优先级计算;
            int num1 = 10;
            Console.WriteLine(num1);
            num1 = 10 + 20;
            Console.WriteLine(num1);
            num1 = 10+12 * 20;
            Console.WriteLine(num1);
            num1 = (10 + 20) * 5 / 54 % 12;
            Console.WriteLine(num1);
            Console.ReadKey();
        }
    }
}
