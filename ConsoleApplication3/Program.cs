using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //用三元表达式求出最大值;
            int a1 = 10;
            int b1 = 20;
            int c1 = 15;
            int max1 = a1 > b1 ? a1 : b1;//a1和b1比较，当为true时，输出a1,当为false时，输出false;
            int max = max1 > c1 ? max1 : c1;
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
