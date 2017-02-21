using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "sdsad";//string是System.String的别名
            StringBuilder sb = new StringBuilder("yanhe");//利用构造函数创建stringbuilder
            StringBuilder sb2 = new StringBuilder(200);//初始一个空的stringbuilder对象，占有100个字符的大小；
            StringBuilder sb3 = new StringBuilder("tianyi",100);//创建一个初始字符为"tianyi"的大小有100的字符串，当有剩余空间时，添加字符不创建新字符；
            //当stringbuilder对象的字符容量满了后，扩容方式和列表类似；


            sb.Append("/tianyi");//当需要反复添加和修改字符串的时候，用stringbuilder效率比较高；
            Console.WriteLine(sb.ToString());//ToString()把当前stringbuilder储存的字符串，提取成一个不可变额的字符串；

            sb.Insert(0,"ai");//在0索引处插入一个"ai"字符串；
            sb.Remove(5,2);//从5索引处开始移除2个字符；
            sb.Replace("yanhe","tianyi");//将yanhe 字符替换成tianyi字符；
            Console.WriteLine(sb);





            Console.ReadKey();
        }
    }
}
