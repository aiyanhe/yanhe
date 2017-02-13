using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象编程__类
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bus = new Car();
            bus.carName = "广龙日天大帝";
            bus.speed = 1000;
            bus.value = 10000000;

            bus.Move();
            Console.ReadKey();
        }
    }
}
