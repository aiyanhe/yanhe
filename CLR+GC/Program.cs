using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLR_GC
{
    class Program
    {
        static void Main(string[] args)
        {
            //垃圾回收机制(GC)所操控
            //内存里面的垃圾什么时候被回收，我们无法确定，是由CLR自动控制的
            //值类型的变量出了作用域{}就立即被CLR所回收
            //引用类型的对象存放在堆里面，是由垃圾回收机制所回收的
            Fruit apple = new Fruit();
            apple = null;//apple的指针被删除了（存在栈里面的指向堆的地址被删除了），
                         //堆里面的内容就没有指针，会被GC删除的；栈里的apple出了Main方法的作用域{}就会被删除；
            GC.Collect();//手动调用垃圾回收，会消耗性能！一般切换场景时使用；
            
        }
        
    }
}
