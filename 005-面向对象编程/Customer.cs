using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_面向对象编程
{
    //在这里我们定义了一个新的类叫做customer,也可以说定义了一个新的类型叫做customer
    class Customer
    {
        //数据成员：里面包含了4个字段
        public string name;
        public string Buyname;
        public int age;
        public int cost;
        //函数成员：定义了一个方法；
        public void Show()
        {
            Console.WriteLine("顾客名字为" + name);
            Console.WriteLine("顾客年龄为"+age);
            Console.WriteLine("所买物品为" + Buyname);
            Console.WriteLine("物品价格为" + cost);
            


        }
    }
}
