using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_switch语句
{
    class Program
    {
        static void Main(string[] args)
        {
            int state = 10;
            switch(state)
            {
                case 0://当state的值等于0时，输出“暂停”；
                    Console.WriteLine("暂停");
                    break ;
                case 1:
                    Console.WriteLine("开始界面");
                    break;
                case 2:
                    Console.WriteLine("战斗");
                    break;
                case 3:
                case 4:
                    //当取值在3或者4时，输出的结果都是"死亡";
                    Console.WriteLine("死亡");
                    break;
                default:
                    //当取值溢出时，执行这个语句“取值溢出”
                    Console.WriteLine("取值溢出");
                    break;
            }

        }
    }
}
