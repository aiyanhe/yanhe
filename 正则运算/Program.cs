using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 正则运算
{
    class Program
    {
        static void Main(string[] args)
        {
            string Elisa = "aiSASA";
            string res = Regex.Replace(Elisa,"^","开头");//搜索字符串，符合正则表达式的情况，然后把所有符合的位置，替换成后面的字符串；
            string res2 = Regex.Replace(Elisa,"$","结尾");
            Console.WriteLine(res+"********"+res2);

            string shu = "54552124";
            string zheng = @"^\d*$";//这个正则表达式的意思为：“^\d”是开头为数字，“\d*”是有任意个数字，"\d$"是结尾为数字，这三个条件；
                                                   //“*”意思为   匹配前面的子表达式任意次。例如，zo*能匹配“z”，“zo”以及“zoo”。*等价于{0,}。
            bool isNum = Regex.IsMatch(shu,zheng);


            string fanyi = @"[^sdfqaAi]";//条件为， 除了sdfqaAi的任意一个字符；（它表示一个字符，除了sdfqaAi之外的任意一个字符）;“[^]”中的^表示除了，"[xy]"表示xy中任意字符；
            string s = Regex.Replace(Elisa,fanyi,"***");//将Elisa符合fanyi正则表达式的字符替换成"***";
            Console.WriteLine(isNum);
            Console.WriteLine(s);


            string qq = "s5454215242";
            string qq1 = "5451154";
            string qq2 = "5441541214151154";
            string qqpr = @"^\d{5,12}$";//条件：开头和结尾中间是否为5~12之间的数字；
            Console.WriteLine(Regex.IsMatch(qq,qqpr));
            Console.WriteLine(Regex.IsMatch(qq1, qqpr));
            Console.WriteLine(Regex.IsMatch(qq2, qqpr));


            string z1 = "sahd65465*&(**/*lsjd41c";
            string zp = @"\d|[a-z]";
            MatchCollection ma =  Regex.Matches(z1,zp);//将z1符合zp条件的字符分割输出；
            foreach (Match item in ma)//item是Match类型
            {
                Console.WriteLine(item);
            }

            string name = "tianyi;yanhe,yuezhenglin";
            string nameP =@"[;,]";//[;,]==[;]|[,]!=[;][,];
            string nameP2 = @"[;]|[,]";//"|"相当于或（||）
            string[] nameStr = Regex.Split(name,nameP);
            string[] nameStr2 = Regex.Split(name,nameP2);
            foreach (var item in nameStr)
            {
                Console.WriteLine(item);
            }
            foreach (var item in nameStr2)
            {
                Console.WriteLine(item);
            }

            //0~255.0~255.0~255.0~255
            //情况：2[0~4]\d    25[0~5]   1？\d\d？
            string dns = @"^((([01]?\d\d?)|(2[0~4]\d|(25[0~5]))\.){3}(([01]?\d\d?)|(2[0~4]\d|(25[0~5])$";//"0~255,0~255,0~255,0~255"


            Console.ReadKey();
        }
    }
}
