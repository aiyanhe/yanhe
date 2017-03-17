#define IsTest//定义一个宏
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011__特性
{
    class Program
    {
        [Obsolete("这个方法过时了，使用NewMethod代替")]//Obsolete特性用来表示一个方法被弃用了（但仍可以调用）
        static void OldMethod()
        {
            Console.WriteLine("OldMethod");
        }
        [Obsolete("该方法过时了",true)]//当Obsolete括号内有个true时，该方法被调用会报错；
        static void OldMethod2()
        {

        }
        static void NewMethod()
        {

        }

        [Conditional("IsTest")]//Conditional特性允许我们包括或取消特定方法的所以调用。为方法声明应用Conditional特性并把编译符作为参数来使用
                               //定义方法的CIL代码本身总是会包含在程序集中，只是调用代码会被插入或忽略（编译器仍会编译，但不会调用）
        static void Test1()
        {
            Console.WriteLine("Test1");
        }
        static void Test2()
        {
            Console.WriteLine("Test2");
        }
        static void Main(string[] args)
        {
            OldMethod();
            // OldMethod2();
            Test1();//如果想调用这个方法，必须在Using上面定义一个宏
            Test2();
            Console.ReadKey();
        }
    }
}
