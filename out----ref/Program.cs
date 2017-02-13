using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out____ref
{
    class Program
    {
        //out与ref
        //共同点：被out与ref这两个关键字修饰的方法参数，我们传进去的变量是传递变量的地址，
        //        如果对该参数进行赋值，那么传进去的变量的值也会跟着该改变
        //不同点：1.如果是ref，那么传进去的变量必须赋初始值，out则不用;
        //        2.如果是ref，那么在方法里面不需要对被ref修饰的变量进行赋值（当然，要赋值也可以）；
        //       如果是out，那么在方法里面，必须对被out修饰的变量进行赋值
        static void Main(string[] args)
        {
            int temp = 0;
            Out(out temp);
            Console.WriteLine("结果为"+temp);
            Ref(ref temp);
            Console.WriteLine("结果为" + temp);
            Console.ReadKey();
        }
        static void Out(out int result)//这个result可以没有初始值，但必须有返回值;
        {
            int num = 100;
            int num1 = 50;
            result = num + num1;
        }
        static void Ref(ref int result)//这个result必须有初始值，但可以没有返回值;
        {
            int num = 100;
            int num1 = 50;
            result = num - num1;
        }
    }
}
