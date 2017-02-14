using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_派生类的构造函数
{
    class Person
    {
        private string name;
        private int age;
        public Person()
        {
            Console.WriteLine("Person的无参构造函数");
        }
        public Person(string name)
        {
            this.name = name;
            Console.WriteLine("Person的有参构造函数"+"name:"+name);
        }
    }
}
