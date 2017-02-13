using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _038_结构体
{
    //我们可以把结构体当成，几个类型组成了一个新的类型
    //比如下面的这个就是使用了3个float类型的变量，来表示一个坐标类型
    struct Position///////Position 是一个类啊！！！！！
    {
        public float x;
        public float y;
        public float z;
    }
    enum Direction
    {
        West,
        East,
        North,
        South
    }
    struct Path
    {
        public float distance;
        public Direction dir;//链接枚举；
    }
    class Program
    {
        static void Main(string[] args)
        {
            //当使用结构体声明变量的时候，相当于使用结构体中所有的变量去声明
            Position enemy1Position;//直接声明第一个敌人（包含xyz）
            enemy1Position.x = 34;//可以通过.加上属性名来访问结构体中指定的变量
            //使用结构体让程序变得更清晰；
            Position enemy2Position;//声明第一个敌人（包含xyz）

            //设置第三个敌人的方向和距离；
            Path enemy3Position;
            enemy3Position.distance = 10000;
            enemy3Position.dir=Direction.West;
        }
    }
}
