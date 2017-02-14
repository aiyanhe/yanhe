using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_面向对象编程
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.如果要使用一个类的话，要先引入它所在的命名空间，
            //因为customer位于当前的命名空间下，所以不需要引入，我们可以直接使用；            
            //这里我们使用customer模板，声明了一个变量（对象）//对对象初始化需要使用new加上类名；
            Customer customer1 = new Customer();
            customer1.age = 18;
            customer1.cost = 100;
            customer1.Buyname = "发髻";
            customer1.name = "言和";
            customer1.Show();//使用对象中的方法；
            Console.ReadKey();
        }
    }
}
