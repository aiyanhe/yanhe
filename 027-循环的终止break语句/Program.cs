using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_循环的终止break语句
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while(true)
            {
                Console.WriteLine(num);
                if (num == 9)
                {
                    break;//跳出最近的循环结构（While循环），执行下一行代码；
                }else {

                    num++;
                }
                
         
           }
            Console.ReadKey();
        }
    }
}
