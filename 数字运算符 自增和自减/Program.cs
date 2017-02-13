using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数字运算符_自增和自减
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int num1 = 10;
            //num++;
            //++num1;//++无论放在操作数的前面还是后面，都是让操作数加1;
            int num2 = ++num;//拆分算，num先自增,然后num2=num;
            int num3 = num1++;//拆分算,mun3=num1,然后num1先自增;
            Console.WriteLine(num);//11
            Console.WriteLine(num1);//11
            Console.WriteLine(num2);//11
            Console.WriteLine(num3);//10   如果++放在前面会先进行自增，然后再进行其余的运算，如果放在操作数的后面，会先使用操作数进行运算，然后让操作数自增;
            Console.ReadKey();
            //减法运算法则一样;
        }
    }
}
