using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_for循环
{
    class Program
    {
        //for(;;){}-----初始化条件，和循环的判断条件都不写的话，就是一个死循环
        //for（a;b;c）{}-----a可以无，c可以无，b无的话就死循环了；
        static void Main(string[] args)
        {
            for (int num = 1; num <= 10;num++ )//先初始化int ,再判断,再进行语句，最后num++;!!!!!!!!!
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
