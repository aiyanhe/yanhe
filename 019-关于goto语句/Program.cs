using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_关于goto语句
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            goto myInd;//goto语句用来控制程序跳到某个标签的位置
            num1++;
        myInd: Console.WriteLine(num1);
            Console.ReadKey();
        }
    }
}
