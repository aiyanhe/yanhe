using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数学运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 45;
            int num2 = 13;
            int res = num1 + num2;
            int res2 = num1 - num2;
            int res3 = num1 * num2;
            int res4 = num1 / num2;
            int res5 = num1 % num2;
            double res6 = 10%3;
            //加减乘除求余两边的操作数都是整数的话，结果还是整数，如果不能被整除的话，自动略去小数部分；
            double res7=10;
            int res8 = 100;
            double res9 = res7 + res8;//不同类型的数字相加，结果的类型应为容量大的类型,不然会报错;
            //关于加法运算符的更多的使用
            //1.字符串相加 用来连接两个字符串 返回一个字符串
            string str1 = "123";
            string str2 = "abc";
            string str = str1 + str2;
            Console.WriteLine(str);
            //2,当一个字符串跟一个数字相加的话，首先把数字转变成字符串，然后连接起来 结果是字符串；
            int num = 456;
            string res10 = str1 + num;
            Console.WriteLine(res10);
            Console.WriteLine("加法：{0}，减法：{1}，乘法：{2}，除法：{3}，求余：{4},求余2：{5}",res,res2,res3,res4,res5,res6);
            Console.ReadKey();
        }
    }
}
