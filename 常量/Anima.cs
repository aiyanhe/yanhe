using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 常量
{
    class Anima
    {
        //常量 ，关键字const,常量必须赋初始值并不允许再次更改；
        public const string name = "dog";//常量的值在编译的时候就确定了
        public string color = "黄色";//成员变量的值在运行的时候确定了
                                   //什么时候回用到常量，如果一个变量，从软件开始运行直到软件结束，这个值都不需要改变的，我们就给它设定为常量

        //只读变量
        public readonly bool gender = false;//运行的时候确定值，但是我们可以在构造函数里面来修改它的值
                                            //只能修饰成员变量，局部变量不行；
        public void Say()
        {
            const int ss = 21;//const可以修饰局部变量；
            color = "青色";
            //name = "cat";//常量不允许更改
            Console.WriteLine(name);
            Console.WriteLine(color);
        }
        public Anima()//构造函数，实例化对象的时候就会被调用;
            {
            gender = true;
            Console.WriteLine("构造函数先运行！");
            }
    }
}
