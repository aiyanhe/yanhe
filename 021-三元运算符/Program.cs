using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_三元运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //三元运算符格式;所需数据类型a1：自定义名称 = 一个判断（返回值是Bool就行）？（bool为true时）和a1数据类型一样的条件：（bool为false时）和a1数据类型一样的条件；

            Console.WriteLine("请输入喜欢的数字,判断你的属性");
            float str1 = Convert.ToSingle(Console.ReadLine());
            string name = str1 > 50 ? "你是gay" : "你是基佬";
            Console.WriteLine(name);


            Console.WriteLine("请输入喜欢的数字,判断你的属性");
            float str2 = Convert.ToSingle(Console.ReadLine());
            int num = str1 > 50 ? 520 : 20;
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
