using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象编程__继承
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy en = new Boss();//父类声明的对象，可以使用子类去构造，子类声明的对象不可以使用父类构造；
            Boss bos = (Boss)en;//bos虽然使用父类进行了声明，但是使用了子类构造，所有本质上是一个子类类型的，我们可以强制转换成子类类型；
            bos.Bossname = "skdj";
            Boss bo = new Boss();
            bo.Hp = 100;
            bo.Speed = 2000;
            bo.Ai();//继承：父类里面所有的数据成员和函数成员都会继承到子类里面
            bo.Move();
            Enemy en1 = new Enemy();
            //Boss bo1 = (Boss)en1;//（会报错）
            //一个对象是什么类型的 主要看它是通过什么构造的 这里en1使用了父类的构造函数，所以只有父类中的字段和方法，不能被强制转换成子类；

        }
    }
}
