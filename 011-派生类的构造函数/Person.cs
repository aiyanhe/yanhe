using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_派生类的构造函数
{
    class Person
    {
        private string name="sdsd";
        private string name1="sdsdaa";
        private int age;
        public Person()
        {
            Console.WriteLine("Person的无参构造函数");
        }
        public Person(string name,string name1)
        {
            this.name = name;
            Console.WriteLine("Person的有参构造函数"+"name:"+name+"name1:"+name1);
        }
    }
}
