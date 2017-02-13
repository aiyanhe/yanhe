using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conture
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool boom = true;
            //int i = 2;
            //int num = 100;
            //do
            //{
            //    boom = true;
            //    do
            //    {
            //        if (num%i==0)
            //        {
            //            //非素数；
            //            boom = false;
            //            break;
            //        }
            //        i++;
            //    } while (i<num);
            //    if (boom)
            //    {
            //        Console.WriteLine(num+"为素数");
            //    }
            //    num++;
            //    i = 2;
            //} while (num<=200);
            int[] array = new int[10];
            int[] array1 = new int[] {10,20,16,12,21 };
            int[] array2 = {10,215,4,152,4,125,45,2156,4,65 };
            for (int i = array2.Length-1; i >= 0; i--)
            {
                Console.WriteLine(array2[i]);
            }
            Console.ReadKey();
        }
    }
}
