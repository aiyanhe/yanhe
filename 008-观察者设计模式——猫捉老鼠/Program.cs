using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_观察者设计模式__猫捉老鼠
{
    class Program
    {
        static void Main(string[] args)
        {
            //多播委托
            
            Cat cat = new Cat("汤姆","灰蓝");
            
            Mouse mouse1 = new Mouse("杰克1","橙黄",cat);
            cat.kaka += mouse1.MouseMove;
            Mouse mouse2 = new Mouse("杰克2", "橙黄", cat);
            cat.kaka += mouse2.MouseMove;
            Mouse mouse3 = new Mouse("杰克3", "橙黄", cat);
            cat.kaka += mouse3.MouseMove;
            Mouse mouse4 = new Mouse("杰克4", "橙黄", cat);
            cat.kaka += mouse4.MouseMove;
            Mouse mouse5 = new Mouse("杰克5", "橙黄", cat);
            cat.kaka += mouse5.MouseMove;
            //cat.kaka();//事件不能在类的外部触发，只能在类的内部触发
            cat.CatMove();
            Console.ReadKey();
        }
    }
}
