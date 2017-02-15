using System;

namespace 抽象类
{
    abstract  class Anima
    {
        public string name;
        public int age;

        public void Run()//实例方法
        {
            Console.WriteLine("跑");
        }
        public abstract void Fly();//抽象方法必须存在于抽象类中；
        //抽象类其实是一个普通的类，但是里面可以包含有抽象成员
        //当一个子类继承于父类的时候，子类（普通类）必须实现父类的抽象方法

        //虚方法与抽象方法的区别
        //1.虚方法的关键字是virtual 抽象类的关键字是abstract
        //2.虚方法可以被子类重写，也可以不重写。而抽象方法，必须被重写（子类必须实现父类的抽象方法）
        //3.抽象类不能被实例化
           //备注：抽象类继承于抽象类，则不需要重写抽象方法；
    }
}
