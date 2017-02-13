using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _048_函数的定义
{
    class Program
    {
        //static void Write() //void 表示空的返回值，就是不需要返回值
        //{
        //    //这里是函数体也叫做方法体，这里可以写0行，一行或者多行语句；
        //    Console.WriteLine("Text out from function");
        //    return;//这个语句用来结束当前函数；
        //}
        //static int Plus(int num1, int num2)//函数定义的时候，参数我们叫做形式参数（形参），num1跟num2在这里就是形参，形参的值是不确定的
        //{
        //    int sum = num1 + num2;
        //    return sum;
        //}
        //static int[] numVisitor(int num)
        //{
        //    int sum = 0;
        //    for (int i = 1; i <= num; i++)
        //    {
        //        if (num % i == 0)
        //        {
        //            sum++;
        //        }
        //    }
        //    int[] array = new int[sum];
        //    int sumNum = 0;
        //    for (int i = 1; i <= num; i++)
        //    {
        //        if (num % i == 0)
        //        {
        //            array[sumNum] = i;
        //            sumNum++;
                    
        //        }
        //    }
        //    sumNum = 0;
        //    sum = 0;
        //    return array;
        //}


        static int Array(int[] array)
        {
            int max = 0;
        for (int i = 0; i < array.Length; i++)
			{
            max = max>array[i]?max:array[i];
			}
            return max;
        }   


        static void Main(string[] args)
        {
            //Write();//函数的调用 函数名加上括号，括号内写参数
            //int num1 = 45;
            //int num2 = 90;
            //int a = Plus(num1, num2);//当调用函数的时候，这里传递的参数就是实际参数（实参），实参的值会传递给形参做运算
            //int b = Plus(30, 20);//这里定义了a和b 来接受方法的返回值
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //int[] array2 = numVisitor(num3);
            //foreach (var item in array2)
            //{
            //    Console.Write(item + " ");
            //}
            Console.WriteLine("输入一个数组,用逗号隔开");
            string a =Console.ReadLine();
            string[] b=a.Split(',');
            int[] c =new int[a.Length];
            for (int i = 0; i < b.Length; i++)
			{
			 c[i]= Convert.ToInt32(b[i]);
			}
            int e = Array(c);
            Console.WriteLine("最大数为"+e);
            Console.ReadKey();
        }
    }
}
