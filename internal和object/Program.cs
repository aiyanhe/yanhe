using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internal和object
{
     internal  class Program//只能在包含它的程序集中访问该项
    {
        static void Main(string[] args)
        {
            int num = 10;
            object obj = num;//装箱：数值类型转换为引用类型
            string result = (string)obj;//拆箱 
        }
    }
}
