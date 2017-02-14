using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013___抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crow aa = new Crow();
            //aa.Fly();
            //Bird bb = new Bird();//不可以用抽象类构造；
            Bird cc = new Crow();//我们可以通过抽象类去声明对象，但是不可以去构造；
            Console.ReadKey();
        }
    }
}
