using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TroubleTest
{
    public class A
    {
        public virtual void Fun1(int i)
        {
            Console.WriteLine(i);
        }
        public void Fun2(A a)
        {
            a.Fun1(1);
            Fun1(5);//b.Fun2(a);这里是执行b的fun1（5）；
        }
    }
    public class B : A
    {
        public override void Fun1(int i)
        {
            base.Fun1(i + 1);
        }
        public static void Main()
        {
            B b = new B();
            A a = new A();
            a.Fun2(b); //2,5
            b.Fun2(a); //1,6
            Console.ReadKey();//2,5,1,6
        }
    }
}
