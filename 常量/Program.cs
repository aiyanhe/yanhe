using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 常量
{
    class Program
    {
        static void Main(string[] args)
        {
            Anima dog = new Anima();
            string str =Anima.name;//常量要通过类名来调用；
            Console.WriteLine(dog.gender);
            Console.WriteLine();
            dog.Say();
        }
    }
}
