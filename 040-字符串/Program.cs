using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040_字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "          ai YanHe                |               ";
            int length = str.Length;//字符串的长度；
            string strLow = str.ToLower();//把字符串转化成小写并返回，对原字符串没有影响；
            string strUp = str.ToUpper();//把字符串转化成大写并返回，对原字符串没有影响；
            string strTrim = str.Trim();//去掉字符串前面和后面的空格，对原字符串没有影响；
            string strStart = str.TrimStart();//去掉字符串前面的空格，对原字符串没有影响；
            string strEnd = str.TrimEnd();//去掉字符串后面的空格，对原字符串没有影响；
            String[] strArray = str.Split();//把原字符串按照指定的字符进行拆分，得到一个拆分后的字符串的数组；！！！
            Console.WriteLine( length);
            Console.WriteLine(strLow);
            Console.WriteLine(strTrim);
            Console.WriteLine(strUp);
            Console.WriteLine(strEnd);
            Console.WriteLine(strStart);
            foreach (var item in strArray)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
