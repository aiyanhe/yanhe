using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_接收用户的输入数字_求出和
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("请输入第一个数字");
           string num1 = Console.ReadLine();
           Console.WriteLine("请输入第二个数字");
           string num2 = Console.ReadLine();
           int num3 = Convert.ToInt32(num1);
           int num4 = Convert.ToInt32(num2);
           int num5 = num3 + num4;
           Console.WriteLine("两个数字的和");
           Console.WriteLine(num5);
           Console.ReadKey();

        }
    }
}
