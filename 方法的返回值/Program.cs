using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的返回值
{
    class Program
    {
        public static int GetSum(int num1,int num2)
        {
            int sum = num1 + num2;
            return sum;

        }
        public static string StrSum(string str1,string str2,string str3)
        {
            string str = str1 + str2 + str3;
            return str;

        }
        static void Main(string[] args)
        {
            int sum = GetSum(100,50);
            Console.WriteLine(sum);
            string str = StrSum("ddd","fff","dddfffsss");
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
