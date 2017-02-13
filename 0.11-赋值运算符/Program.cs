using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_赋值运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 32;
            Console.WriteLine(num1);
            num1 += 45;
            Console.WriteLine(num1);
            num1 -= 45;
            Console.WriteLine(num1);
            num1 *= 2;
            Console.WriteLine(num1);
            num1 /= 2;
            Console.WriteLine(num1);
            num1 %= 3;
            Console.WriteLine(num1);
            Console.ReadKey();
        }
    }
}
