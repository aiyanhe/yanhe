using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //单例模式：保证该类只有一个实例化的对象
            LLo.GetToolSingle().GetSum();
            LLo.GetToolSingle().GetSum();//再次声明时，还是只有一个theTool;
            Console.ReadKey();
        }
    }
}
