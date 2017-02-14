using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    class Program
    {
        static void Main(string[] args)
        {
            bus car = new smallbus();
            car.Move();
            smallbus car1 = new smallbus();
            car1.Move();
            Console.ReadKey();
        }
    }
}
