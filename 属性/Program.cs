using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 属性
{
    class Program
    {
        static void Main(string[] args)
        {
            V yanhe = new V();
            yanhe.Age = 18;
            Console.WriteLine(yanhe.Age);
            yanhe.Age = 1000;
            Console.ReadKey();
        }
    }
}
