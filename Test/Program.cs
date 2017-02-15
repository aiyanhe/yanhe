using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Father
    {
        public void F()
        {
            Console.WriteLine("A.F");
        }
        public virtual void G()
        {
            Console.WriteLine("A.G");
        }
    }
    class Son : Father
    {
        new public void F()//有new的情况下这个F()方法是子类独有的；
        {
            Console.WriteLine("B.F");
        }
        public override void G()
        {
            Console.WriteLine("B.G");
        }
    }
    class override_new
    {
        static void Main()
        {
            Son b = new Son();
            Father a = b;
            a.F();//AF
            b.F();//BF
            a.G();//BG
            b.G();//BG
            Console.ReadKey();
        }

    }
}
