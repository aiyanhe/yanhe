using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015__接口
{
    class Program
    {
        static void Main(string[] args)
        {
            bird bi = new bird();
            bi.Fly();
            bi.Move();
            Console.ReadKey();
        }
    }
}
