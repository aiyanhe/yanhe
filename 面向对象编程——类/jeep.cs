using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象编程__类
{
    class jeep
    {
        private float speed;//私有的，不被外界引用；
        public string carName;

        public void Move()
        {
            Console.WriteLine("城市化真实大帝");
        }
        public void Say(string carName)
        {
            this.carName = carName;
            Console.WriteLine("车的名字是"+carName);
        }
    }
}
