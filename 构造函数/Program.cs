using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 构造函数
{
    class Program
    {
        
        static void Main(string[] args)
        {
            fruit taozi = new fruit(1000);
            taozi.GetFruit();
            Console.ReadKey();
        }
    }
}
