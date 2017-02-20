 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串的方法
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string str = "yan he";
            string str2 = "tia nyi";
            int index =   str.CompareTo(str2);//当两个字符串相等的时候，返回0，当s在字母表中的排序靠前的时候，返回-1，否则返回1
            Console.WriteLine("CompareTo(方法，比较字符串的内容):----------" + index);
            str = str.Replace("yan","tian");//可以用来消除空格Replace(" ","")//把指定的字符换成指定的字符或者把指定的字符串换成指定的字符串
            Console.WriteLine("Replace()----------"+str);
            string[] strar = str.Split(' ');
            Console.WriteLine("Split----------" + strar);
            string str3 =  str.Substring(3,2);
            Console.WriteLine("Substring----------" + str3);
            string  strL = str.ToLower();//小写
            string strU = str.ToUpper();//大写
            string strT = str.Trim();//删除首尾的空白
            //string strC = str.Concat();
            //string[] strCT = str.CopyTo();
            //string strF = str.Format();
            int num = str.IndexOf('a', 0, 2);
            Console.WriteLine("IndexOf----------" + num);
            //int num2 = str.IndexOfAny(,0,5);
            str = str.Insert(0,"ai");
            Console.WriteLine("Insert----------" + str);
            //string[] strJ = str.Join(); 
            Console.ReadKey();
        }
    }
}
