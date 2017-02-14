using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class anima
    {
        public string name;
        public int age;
        private string cost;
        protected string color;
        //public 公共的，无访问限制
        //private 私有的，只有本类可以访问
        //protected 受保护的，只有本类和子类可以访问到（要注意区别）
        public anima(string name)
        {
           // Console.WriteLine("anima的有参构造函数");

        }
        public anima()
        {

        }
        public virtual void Run()//关键字 virtual 将该方法变为虚方法，方便子类重写；
        {
            Console.WriteLine("anima在跑");

        }
        public void Say()
        {
            Console.WriteLine("anima在叫");
        }
    }
}
