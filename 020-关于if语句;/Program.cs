using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_关于if语句_
{
    class Program
    {
        static void Main(string[] args)
        {
            bool boom = true;
            if (boom)//当bool值为true时，返回值为true时;
            {
                Console.WriteLine("条件符合可以看到我");
            }
            Console.WriteLine("条件不符合时只能看到我");


            if (56 > 54)//当返回值为true时;
            {
                Console.WriteLine("条件符合可以看到我");
            }
            Console.WriteLine("条件不符合时只能看到我");


            if (boom == false)//当返回值为true时;
            {
                Console.WriteLine("条件符合可以看到我");
            }
            Console.WriteLine("条件不符合时只能看到我");


            Console.WriteLine("请输入喜欢的数字");
            float str1 = Convert.ToSingle(Console.ReadLine());



            //if else只能执行其中一个分支，而且肯定一定会执行其中一个分支；
            if (str1 > 50f)
            {
                Console.WriteLine("你输入的数字大于50");
            }
            else
            {
                Console.WriteLine("你输入的数字小于50");
            }
            Console.ReadKey();
        }
    }
}
