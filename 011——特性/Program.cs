#define IsTest//定义一个宏
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _011__特性
{
    //通过制定属性的名字，给属性赋值，这种是命名参数
    [MyTest("自定义的特性类",ID =100)]//当我们使用特性的时候，后面的Attribute不需要写
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
        [DebuggerStepThrough]//可以跳过debugger的单步调试 不让进入该方法（当我们确定这个方法没有任何错误的时候，可以使用这个）
        static void PrintOut(string str,[CallerFilePath]string fileName ="",[CallerLineNumber]int lineNumeber=0,[CallerMemberName]string methodName="")
        {//调用者信息，这些特性只能用于方法中的可选参数//[CallerFilePath]访问该方法的成员文件路径 //[CallerLineNumber]总代码行数  //[CallerMemberName]调用该方法的成员的名称
            Console.WriteLine(str);
            Console.WriteLine(fileName);
            Console.WriteLine(lineNumeber);
            Console.WriteLine(methodName);
        }
        static void Main(string[] args)
        {
            OldMethod();
            // OldMethod2();
            Test1();//如果想调用这个方法，必须在Using上面定义一个宏
            Test2();
            PrintOut("123");

            //获取方法上的特性类
            Type type = typeof(Program);//通过typeof+类名也也可以获取type对象
            object[] array = type.GetCustomAttributes(false);
            MyTestAttribute mytest = array[0] as MyTestAttribute;//因为Program只有一个特性类，所以不用遍历
            Console.WriteLine(mytest.Description);
            Console.WriteLine(mytest.ID);
            
            Console.ReadKey();
        }
    }
}
