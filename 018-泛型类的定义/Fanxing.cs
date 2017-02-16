using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_泛型类的定义
{
    class Fanxing<T>//T代表一个数据类型，当使用Fanxing进行构造的时候，需要指定T的类型；
    {
        private T num1;
        private T num2;
        private string sum;
        public Fanxing(T num1,T num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public string Sum()
        {
            return sum = num1 +""+ num2;
        }
        public static string Get<A,B,C>(A a,B b,C c)//泛型方法，泛型可以定义多个不确定类型;
        {
            return a + ""+b + c + "";
        }
    }
}
