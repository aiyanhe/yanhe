using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class dog:anima
    {
        //string name1 = "金毛";
        
        public dog():base("sds")//表示调用父类的相对应参数的构造函数
        {
            //Console.WriteLine("这里是dog的构造函数");

        }
        //public new void Run()//加了关键字new，让编译器知道我们隐藏父类的run方法,自建一个新的run方法，当然，new也可以不用加;
        //{
        //    Console.WriteLine("这里是dog的run");
        //}
        public override void Run()//关键字override ,重写父类相对应的虚方法
        {
            //base.Run(); //base 基于父类 this 基于本类
            Console.WriteLine("这里是dog的run");
        }
        public new void Say()
        {
            Console.WriteLine("dog在叫");
        }
        public void jia()
        {
           // cost = 100;//两个要在方法下测试！！
            color = "red";
        }
        

    }
}
