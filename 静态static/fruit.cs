using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态static
{
    static class Fruit
    {
        public static int size;
        //public void GetColor()//实例方法
        //{

        //}
        //使用静态方法是为了方便调用；
        //静态方法，直接通过类名来访问
        //静态成员是和类一起存在的，只要有了类，那么就有了静态成员，直接通过类名来访问

        //静态类
        //静态类不可以被实例化
        //静态类中只能有静态成员
        //静态类，字段，方法存储在内存的静态成员区，当程序运行到静态成员时会生成并存储到静态成员区，程序结束后会清空静态成员区。
        //常量存储在内存的常量区，程序运行前存储在常量区，程序结束后会清空；
        public static void GetName()
        {

        }
    }
}
