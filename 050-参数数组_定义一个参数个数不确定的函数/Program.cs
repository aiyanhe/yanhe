using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050_参数数组_定义一个参数个数不确定的函数
{
    class Program
    {
        static int Sum(int[] array) {

            int max = 0;
            for (int i = 0; i <array.Length; i++)
            {
                max=max>array[i]?max:array[i];
            }
            return max;
        }
        static int Poln(params int[] array)//params  是参数数组，让外部直接传递参数，不用新建参数类型；
        {

            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                max = max > array[i] ? max : array[i];
            }
            return max;
        }
        static void Main(string[] args)
        {
            //int max = Sum(545414,54,54,5,54,51,5,48,1,54,8,4);这样不行！
            int max = Sum(new int[]{216545,645,5,45,45,48,48,45,489,7,4564,98,77,8456,48,48,64});//这样才行！！
            int max2 = Poln(2,5,1,165,165,165,165,48,65,1,168,54561,561,64,84,841,651,526,414);//或者这样用参数数组，这样就不用新建数组了，可直接传递参数；
            Console.WriteLine(max+"\n"+max2);
            Console.ReadKey();
        }
    }
}
