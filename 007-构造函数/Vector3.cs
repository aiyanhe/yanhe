using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 namespace _007_构造函数
{
    public class Vector3
    {
        private int x, y, z;
        public float length;
        //构造函数就是用于初始化数据的函数；
        //声明基本的构造函数的语法就是声明一个和所在类同名的方法，但是该方法没有返回类型；
        public Vector3(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            length = (float)Math.Sqrt(x * x + y * y + z * z);
        }


        static Vector3()
        {
            //静态构造函数是C#的一个新特性，其实好像很少用到。
            //不过当我们想初始化一些静态变量的时候就需要用到它了。
            //这个构造函数是属于类的，而不是属于哪里实例的，就是说这个构造函数只会被执行一次。也就是在创建第一个实例或引用任何静态成员之前，由.NET自动调用
            //在使用静态构造函数的时候应该注意几点：
            //1、静态构造函数既没有访问修饰符，也没有参数。因为是.NET调用的，所以像public和private等修饰符就没有意义了。　　
　　        //2、是在创建第一个类实例或任何静态成员被引用时，.NET将自动调用静态构造函数来初始化类，也就是说我们无法直接调用静态构造函数，也就无法控制什么时候执行静态构造函数了。
　　        //3、一个类只能有一个静态构造函数。
　　        //4、无参数的构造函数可以与静态构造函数共存。尽管参数列表相同，但一个属于类，一个属于实例，所以不会冲突。
　　        //5、最多只运行一次。
　　        //6、静态构造函数不可以被继承。
　　        //7、如果没有写静态构造函数，而类中包含带有初始值设定的静态成员，那么编译器会自动生成默认的静态构造函数。
        }
    }
}
