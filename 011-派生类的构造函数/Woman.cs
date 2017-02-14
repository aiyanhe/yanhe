using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_派生类的构造函数
{
    class Woman:Person
    {
        public Woman():base()//调用父类中无参的构造函数，当我们没有在子类的构造函数中显示调用父类的构造函数，默认会调用父类中的无参构造函数；
        {
            Console.WriteLine("Woman的无参构造函数");
        }
        public Woman(string x, string y): base(x)
        {
            Console.WriteLine("woman的有参构造函数");
        }
    }
}
