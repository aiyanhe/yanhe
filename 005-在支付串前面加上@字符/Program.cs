using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_在支付串前面加上_字符
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "yanhe";
            int hp = 100;
            int level = 8;
            float exp = 6545.52f;
            //当在字符串前面加上一个@字符的时候，我们就可以把一个字符串定义在多行
            //编译器不会再去识别字符串中的转义字符
            //如果需要在字符串中表示一个引号的话，需要使用两个双引号
            //@字符可以用来表示路径，这样比较简练;
            Console.WriteLine(@"主角的名字:\'{0}\'\n \t生命值:{1}\n 等级:{2}\n 经验值:{3}", name, hp, level, exp);
            Console.WriteLine(@"主角的名字:{0}
生命值:{1}等级:{2}经验值:{3}", name, hp, level, exp);
            Console.WriteLine(@"主角的名字:""{0}""生命值:{1}等级:{2}经验值:{3}", name, hp, level, exp);
            string path = "c:\\xxx\\xx\\xxx.doc";
            string path2 = @"c:\xxx\xx\xx.doc";
            Console.WriteLine(path);
            Console.WriteLine(path2);
            Console.ReadKey();
        }
    }
}
