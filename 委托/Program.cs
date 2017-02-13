using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    class Program
    {
        //委托；
        //委托，我们可以把它看作是装方法的容器
        //委托它其实是一个类，它可以把方法作为参数进行传递
        //委托只是存储了各个方法的地址，而他自己也是什么也不做的.
        //用处：要在方法中用指定的一个方法里面执行多个指定的方法，就需要委托；(暂时的自我理解)
        static void Main(string[] args)
            
        {
           // 多播委托！
            Console.WriteLine(Get1(GetSum1));
            DelGetSum del = new DelGetSum(GetSum);
            del += GetSum3;
            del += GetSum4;
            Get(del);
            Console.WriteLine("************");
            Console.WriteLine("************");
            del -= GetSum3;
            Get(del);
            Console.ReadKey();
        }
        public delegate void DelGetSum();//委托的定义，命名规则：要以Del开头;
        public delegate int DelGetSum1(int num1,int num2);//带参数的委托；
                                                          //方法与委托的参数和返回一一对应，无参对无参，有参对有参，严格对应；
        public static void SASA(Action axc)            //Action是一个系统自带的方法；
        { } 

        public static void Get(DelGetSum del)//因为不能有参数为方法的方法，所以以委托为中介，传递方法；(暂时的自我理解)
                                             //传递时克隆方法，委托是个类（蓝图）；(暂时的自我理解)
                                             //委托可以把很多方法克隆在自己（蓝图）上；
                                             
        {
            del();
        }
        public static int Get1(DelGetSum1 del)//不能重载的方法委托重载的方法；
        {
            
            return del(12,21);

        }
        public static void GetSum()
        {
            int a = 1;
            int b = 2;
            int sum = a + b;
            //return sum;
            Console.WriteLine(sum);
            

        }
        public static int GetSum1(int num1,int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
        public static void GetSum3()
        {
            Console.WriteLine("GetSum3");
        }
        public static void GetSum4()
        {
            Console.WriteLine("GetSum4");
        }
    }
}
