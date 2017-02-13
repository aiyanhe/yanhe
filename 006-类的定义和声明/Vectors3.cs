using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_类的定义和声明
{
    class Vectors3
    {
        //编程规范上 习惯把所有的字段设置为private,只可以在类的内部访问，不可以通过对象访问
        private float x,y,z;
        //为字段提供set方法，来设置字段的值；
        public void SetX(float x)
        {
            //如果我们直接在方法内部访问同名的变量的时候，优先访问最近（形参）
            //我们可以通过this.表示访问的是类的字段或者方法；
            this.x = x;
        }
        public void SetY(float y)
        {
            this.y = y;
        }
        public void SetZ(float z)
        {
            this.z = z;
        }
        public float Length()
        {
            return (float)Math.Sqrt(x*x+y*y+z*z);
        }
    }
}
