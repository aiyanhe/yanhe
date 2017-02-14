using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013___抽象类
{
    class Crow:Bird//一个抽象类，就是一个不完整的模板
    {
        public override void Fly()//继承抽象类父类，必须去实现抽象方法
        {
            Console.WriteLine("乌鸦在飞");
        }
    }
}
