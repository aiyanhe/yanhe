using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "yanhe";
            int hp = 100;
            int level = 8;
            float exp = 6545.52f;
            Console.WriteLine("主角的名字:\'{0}\'\n \t生命值:{1}\n 等级:{2}\n 经验值:{3}", name, hp, level, exp);//\n是转义字符之一，字符间换行用；\'\'是为了显示‘’字符；\t是水平制表符，四个空格;
            Console.ReadKey();
        

        }
    }
}
