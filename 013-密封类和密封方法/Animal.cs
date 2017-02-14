using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_密封类和密封方法
{
    sealed class Animal
    {
        public void Move()
        {
            Console.WriteLine("这是Animal的Move");
        }
    }
}
