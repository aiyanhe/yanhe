using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012____虚假方法
{
    class Program
    {
        static void Main(string[] args)
        {
            yanhe ya = new yanhe();
            ya.Move();
            person pe = new yanhe();//隐藏方法：如果使用子类声明的对象。调用隐藏方法会调用子类的，如果使用父类声明对象，那么就会调用父类中的隐藏方法；
            pe.Move();
            Console.ReadKey();
        }
    }
}
