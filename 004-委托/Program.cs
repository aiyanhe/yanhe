using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_委托
{
    class Program
    {
        private delegate string GetAString();//定义了一个委托类型，这个委托类型的名字叫做GetAString
        private delegate void sdkl();
        private delegate void duobo();
        public static void PrintString()
        {
            Console.WriteLine("Action");
        }
        public static void PrintString1()
        {
            Console.WriteLine("PrintString1");
            //throw new Exception();当多播委托中有一个抛出异常时，剩下的方法将不再执行；
        }
        public static void PrintString2() {
            Console.WriteLine("PrintString2");
        }
        public static void PrintString(int a)
        {
            Console.WriteLine("Action");
        }
        public static void PrintString(string a)
        {
            Console.WriteLine("Action");
        }
        public static int State()
        {
            return 210;
        }
        public static string State(string str)
        {
            return str;
        }
        public static string State(string str, int ina)
        {
            return str + ina;
        }

        public static void Main(string[] args)
        {
            int num = 400;
            //使用委托类型创建实例
            GetAString sasa = new GetAString(num.ToString);//sasa指向了num中的tostring方法
            GetAString dada = num.ToString;//第二种赋值方法；
            string kk = dada.Invoke();//通过委托实例去调用num中的tostring方法；
            Console.WriteLine(sasa());//通过委托类型是调用一个方法，跟直接调用这个方法作用是一样的
            GetAString dde = new GetAString(num.ToString);


            Action a = PrintString;//action是系统内置（预定义）的一个委托类型，它可以指向一个没有返回值，没有参数的方法；
            Action<int> a1 = PrintString;//定义了一个委托类型，这个类型可以指向一个没有返回值，有一个int参数的方法
            Action<string> a2 = PrintString;//定义了一个委托类型，这个类型可以指向一个没有返回值，有一个string参数的方法，在这里系统hi自动寻找匹配的方法；
                                            //Action可以后面通过泛型去指定action指向的方法的多个参数的类型，参数的类型跟action后面声明的委托是对应着的



            Func<int> fu = State;//func中的泛型类型<>指定的是方法的返回值类型
            Func<string, string> fu2 = State;
            Func<string, int, string> fu3 = State;//func后面必须指定一个返回值类型，参数类型可以有0~16个
                                                  //先写参数类型，最后一个是返回值类型；
            Console.WriteLine(fu());
            Console.WriteLine(fu2("aiyanhe"));
            Console.WriteLine(fu3("aitianyi", 100));

            //多播委托
            duobo ll = PrintString;
            ll += PrintString1;
            ll+= PrintString2;//一个委托有多个方法，叫做多播委托；
            ll();
            ll -= PrintString;//减去一个指定委托
            ll -= PrintString1;
            ll -= PrintString2;
            if (ll!=null)
            {
                ll();//如果委托为空，执行时会报错；
            }
            ll = PrintString;
            ll += PrintString1;
            ll += PrintString2;
            Delegate[] sss = ll.GetInvocationList();//新建一个委托数组来接受
            foreach (var item in sss)
            {
                item.DynamicInvoke();
            }




            Console.ReadKey();
        }
    }
}
