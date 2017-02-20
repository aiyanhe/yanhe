using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcweit
{
    class Program
    {
        public static int State()
        {
            return 210;
        }
        public static string State(string str)
        {
            return str;
        }
        public static string State(string str,int ina)
        {
            return str+ina;
        }
        static void Main(string[] args)
        {
            
            Func<int> fu= State;//func中的泛型类型<>指定的是方法的返回值类型
            Func<string,string> fu2 = State;
            Func<string,int,string> fu3 = State;//func后面必须指定一个返回值类型，参数类型可以有0~16个
                                                //先写参数类型，最后一个是返回值类型；
            Console.WriteLine( fu());
            Console.WriteLine(fu2("aiyanhe"));
            Console.WriteLine( fu3("aitianyi",100)); 
            Console.ReadKey();
        }
    }
}
