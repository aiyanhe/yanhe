using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores={121,54,1241,5,45,45,415,4,524,5};//使用这种方式赋值的时候，一定要注意在数组声明的时候赋值；
            int[] scores1;
            scores1=new int[10];
            int[] scores2 = new int[10]{54,521,54,524,65,1354,535,465,545,454};
            int f = scores2.Length;
            //for循环
            for (int i = 0; i < f; i++)
            {
                Console.WriteLine(scores2[i]);
                
            }
            Console.ReadKey();
            //while循环
            int t = 0;
            while (t<f)
            {
                
                Console.WriteLine(scores2[t]);//当我们访问一个索引不存在的值得时候，会出现异常exception;
                t++;//所以t++要放在下面！！！
            }
            Console.ReadKey();
            //do while循环
            int n = 0;
            do
            {
               
                Console.WriteLine(scores2[n]);
                n++;
            } while (n<f);
            Console.ReadKey();
            //数组遍历专用；
            foreach (var temp in scores2)
            {
                Console.WriteLine(temp);//直接转出数组
            }
            Console.ReadKey();
        }
    }
}
