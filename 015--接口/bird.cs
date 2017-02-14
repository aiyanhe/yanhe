using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015__接口
{
   // class bird:fly,Move
     class bird:Move
    {

        public void Fly()//实现接口

        {
            Console.WriteLine("fly接口被实现了");
        }

        public void Move()
        {
            Console.WriteLine("Move接口被实现了");
        }
    }
}
