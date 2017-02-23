using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_观察者设计模式__猫捉老鼠
{
    class Cat
    {
        private string name;
        private string color;

        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        public void CatMove()
        {
            Console.WriteLine("叫做{0}的{1}猫来了", name, color);
            if (kaka!=null)
            {
                kaka();
            }
        }

        public  delegate void Catch();
        public event Catch kaka;//声明一个事件，发布了一个消息；
    }
}