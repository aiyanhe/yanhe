using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的重载
{
    class Program
    {
        //重载：多个方法中，方法命名一样，但方法的参数类型或者参数数量不一样；
        public static void GetSum()
        {
            Console.WriteLine("调用正确");
        }
        public static void GetSum(int num)
        {
            Console.WriteLine("调用正确");
        }
        public static void GetSum(int num, int num1)
        {
            Console.WriteLine("调用正确");
        }
            public static void GetSum(string num)
        {
            Console.WriteLine("调用正确");
        }
        public static void GetSum(int num, string num1, int num2)
        {
            Console.WriteLine("调用正确");
        }
            public static void GetSum(int num, int num1, string num2)
        {
            Console.WriteLine("调用正确");

        }
        static void Main(string[] args)
        {
            GetSum(1);
            GetSum();
            GetSum("744");
            GetSum(1,545,"a22");
            GetSum(1,"5s4d",241);
            Console.ReadKey();
        }
    }
}
