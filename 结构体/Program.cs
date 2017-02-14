using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构体
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    //类与结构体的区别
    //1.结构体中的成员变量不能赋初始值，类中可以
    //2.结构体的关键字是struct,类是class;
    //3.类和结构体的成员变量的初始值都是在构造函数里面进行赋值的，
      //但是由于结构体的成员变量无法赋初始值，所以构造函数里面给数值类型的变量赋默认值为0，引用类型赋默认值为null
    //4.结构体中虽然可以定义构造函数，但是不能定义无参的构造函数，因为结构体中的无参构造函数始终存在，我们如果再定义一个就冲突了
    //5.结构体中的构造函数必须对成员变量赋值；
    //6.类是引用类型 结构体是值类型；
    //7.当要表示一个轻量级对象的时候，我们就用结构体
     // 当我们要表示一个重量级的对象的时候，我们就用类；


    struct Fruit
    {
        public string name;
        //public string name1 = "asjdg";//不能赋初始值，结构体是在构造函数中赋值的
        private string color;
        public int weight;

        public Fruit(string name , string color,int weight)//因为当存在有参数的构造函数时，执行有参的构造函数,
        {
            this.name = name;
            this.color = color;
            this.weight = weight;
        }
        public Fruit(int size)
        {
            this.name = "241";
            this.color = "6412";
            this.weight = 1321;
        }
        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }
    }
}
