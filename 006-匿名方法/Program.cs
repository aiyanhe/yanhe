using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_匿名方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> aa = delegate(int a, int b)
            {
                Console.WriteLine(a);
                return b;
            };
            //匿名方法，本质上是一个方法，只是没有名字，任何使用委托变量的地方都可以使用匿名方法赋值
            aa(3,5);

            //Lambda表达式
            Func<int,int,int> plus  = (a,b)=>{return 574;};
            Console.WriteLine(plus(21,32));
            Func<int, int> p = s => 645;
            //如果Lambda表达式只有一条语句，在方法块内就不需要花括号和return语句，编译器会自动添加return语句
            //如果Lambda表达式的实现代码中需要多条语句，就必须添加花括号和return语句；

            //通过Lambda表达式可以访问Lambda表达式外部的变量，这是一个非常好的功能，但如果不能正确使用，也会非常危险；
            int ssssd = 5;
            Func<int,int> pdd = a=> {return ssssd+a;};
            Console.WriteLine(pdd(20));
            ssssd = 50;
            Console.WriteLine(pdd(54));
            //这个方法的结果给，不但受到参数的控制，还受到ssssd变量的控制，结果不可控，容易出现编程问题，用的时候要谨慎；




            Console.ReadKey();
        }
    }
}
