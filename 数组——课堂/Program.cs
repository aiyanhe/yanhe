using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组__课堂
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[] { 10, 21, 21, 54, 21, 58 };
            //int[] array2;
            //array2 = array;//把array的地址复制一份给array2；
            //array2[0] = 1888;//所以当array2的值被改变时，array也被影响；因为两者指向同一值；
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //    Console.WriteLine(array2[i]);
            //}
            //string str = "ww";
            //string str2 = str;//string是特殊的引用类型，不会被影响；
            ////1.字符串做参数，传递的是引用，只是一个指针的复制，你修改参数的指向，影响不到调用它的函数中的那个指针所指向的内容
            ////2.字符串不可修改。你以任何一种形式修改了字符串(+,= 等操作)，源字符串其实还在的，只是根据你的修改重新生成了一个新的字符串
            ////3.如果需要修改，两种方案，一是将修改后的字符串返回；二是作参数传字符串时使用 ref 传递，这样子函数中可以直接修改掉主函数中的指针指向，从而指向新的字符串。
            ////4  定义字符串时，会先查CLR内部的散列表。
            //str2 = "qq";
            //Console.WriteLine(str);
            //Console.WriteLine(str2);

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item+1);
            //}
            GetSum(10,20);//方法的调用；
            String("5345615452uih","sagdiushaudhashd");
            Console.ReadKey();
        }
        //public是一个访问修饰符--公共的，无访问限制的
        //private--私有的
        //protected --受保护的
        //方法（函数）
        public static void GetSum(int num1,int num2)//带参数
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);

        }

        public static void String(string str,string str2)
        {
            Console.WriteLine(str+str2);


        }
    }


}
 