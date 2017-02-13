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
    }
}
