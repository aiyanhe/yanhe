using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010____虚方法
{
    class Woman:Person
    {
        public void Say()
        {
            Console.WriteLine("Woman中的Say");
        }
        public override void Move()//加上override，与父类相对应的虚方法呼应；重写虚方法；
        {
            Console.WriteLine("Woman中的Move");
        }
    }
}
