using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_布尔运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 10;
            int a2 = 20;
            bool s1 = a1 == a2;//false;
            bool s2 = a1 != a2;//true
            bool s3 = a1 >= a2;//false
            bool s4 = a1 <= a2;//true
            bool s5 = a1 > a2;//false
            bool s6 = a1 < a2;//true
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.ReadKey();
        }
    }
}
