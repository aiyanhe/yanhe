using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_循环的中断continue_goto和return结束循环_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while(num<=10)
            {
                num++;
                if (num == 5) {
                    continue;//当运行到continue时，不执行下面语句，直接重新执行while(条件)判断;
                }
                Console.WriteLine(num);
                
            }
            Console.ReadKey();
        }
    }
}
