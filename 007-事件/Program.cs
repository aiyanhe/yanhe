using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_事件
{
    class Program
    {
        public delegate void yanhe();//
        //public yanhe tianyi;
        public event yanhe tianyi;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.tianyi = Test;
            p.tianyi();
            Console.ReadKey();
        }
        public static void Test()
        {
            Console.WriteLine("哎，言和");
        }
    }
}
