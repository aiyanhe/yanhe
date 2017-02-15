using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    class LLo
    {
        //1.构造函数私有化，这样的话外界就不能通过new关键字来实例化出对象了
        private LLo() { }
        //2.声明一个私有的该类类型的静态字段
        private static LLo theTool;
        //3.定义一个公有的静态方法，返回值为该类类型的，以供外部调用
        public static LLo GetToolSingle()
        {
            if (theTool==null)
            {
                theTool = new LLo();
            }
            return theTool;

        }
        public void GetSum()
        {
            Console.WriteLine("(╯▔皿▔)╯^(*￣(oo)￣)^");
        }
    }
}
