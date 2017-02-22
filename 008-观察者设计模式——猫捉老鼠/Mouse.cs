using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_观察者设计模式__猫捉老鼠
{
    class Mouse
    {
         private string name;
        private string color;

        public Mouse(string name, string color ,Cat cat)//在观察者中进行委托添加方法的操作
        {
            this.name = name;
            this.color = color;
            cat.kaka += MouseMove;
        }
        public void MouseMove()
        {
            Console.WriteLine("叫做{0}的{1}老鼠跑了", name, color);
            
        }
    }
}
