using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053_委托的使用
{
    //定义一个委托跟函数差不多，区别在于
    //1，定义委托需要加上delegate关键字
    //2.委托的定义不需要函数体
      public delegate  int MyDelegate(int max,int min);
    class Program
    {
       public static int Multiply(int max,int min) 
        {
            return max * min;
        }
       public static int Divide(int max, int min)
       {
           return max / min;
       }  
        static void Main(string[] args)
        {

            MyDelegate de;//利用我们定义的委托类型声明了一个新的变量
            de = Multiply;//当我们给一个委托的变量赋值的时候，返回值跟参数列表必须一样，否则无法赋值；
            Console.WriteLine(de(2,34));
            de = Divide;
            Console.WriteLine(de(255,33));
            Console.ReadKey();
        }
    }
}
