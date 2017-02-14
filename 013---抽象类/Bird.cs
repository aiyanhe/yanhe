using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013___抽象类
{
    abstract class Bird//当有抽象方法时，类也必须为抽象类；
    {
        public abstract void Fly();//抽象方法有关键字abstract，没有方法体，不完整的方法；
    }
}
