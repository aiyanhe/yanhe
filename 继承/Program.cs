using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class Program
    {
        static void Main(string[] args)
        {
            //当实例化出一个子类对象的时候，一般情况下会去先调用父类的无参构造函数，接着调用子类的构造函数；
            dog a = new dog();
            a.Run();
            //里氏替换原则
            //anima ani = new dog();//用一个子类对象实例化一个父类变量，只能调用子类对象的父类的成员（只能调用到父类里面的成员）
            //里氏替换原则的三种表现形式
            //1.Aanimal ani =new Cat();//用一个子类对象实例化一个父类变量
            //2.父类变量当做参数，传入子类对象
            //3.父类当做返回类型，子类对象当做返回值
            cat theCat = new cat();
            theCat.name = "sjdgj";
            anima ani = theCat;
            //cat ca = new cat();
            //ca.name = "机器猫";
            //Test(ca);
            //Console.ReadKey();
            Console.WriteLine("********");
            anima kk = new anima();
            dog ll = new dog();
            kk.name = "kkkkkkk";
            ll.name = "llllllll";
            kk = ll;//anima kk =new dog();  kk.name和ll.name指向同一个地方;
            //父类有的，子类肯定有，所以可以成功转换，那么转换后只能调用父类里面的方法，调用不到子类的特有成员；
            kk.Run();
            kk.Say();
            Console.WriteLine("sdsd"+kk.name);
            Console.WriteLine("********");
            kk.name = "kkkkkkk";
           //ll.name = "llllllll";

            ll = (dog)kk;
            //父类强制转换为子类，由于子类的成员肯定比父类多（或者一样），那么我们在编辑器里面可以顺利转换
            //但是程序编译的时候，会发现这样转换出错，因为子类的东西一般比父类的多，所以编译不通过；
            ll.Run();
            ll.Say();
            Console.WriteLine(ll.name);
            Console.ReadKey();
        }
        public static void Test(anima ani)
        {

        }
        public static anima Test2()
        {

            cat ca = new cat();
            return ca;
            //return new cat();//简写
        }
    }
}
