using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _052_函数的重载
{


    class Program
    {
        static int MaxValue(params int[] array)
        {

            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                      max=max>array[i]?max:array[i];
            }
            return max;
        }
        static double MaxValue(params double[] array)
        {

            double max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                max = max > array[i] ? max : array[i];
            }
            return max;
        }
        static void Main(string[] args)
        {
            //函数名相同，参数不同，这个叫做函数的重载（编译器通过不同的参数去识别应该调用哪一个函数）
            //编译器会根据你传递过来的实参的类型去判定调用哪一个函数；
            int max1 = MaxValue(26,5,321,54,24,5,15,4,56,54247,6);
            double max2 = MaxValue(54.6456,456445,415212,245.5454,54545.45,54544,4878752.54,457);
            Console.WriteLine(max1);
            Console.WriteLine(max2);
            Console.ReadKey();
        }
    }
}
