using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_
{
    class Program
    {
        static void Main(string[] args)
        {
        cong: Console.WriteLine("请问你考了多少分(0~100)");
            string sore1 = Console.ReadLine();
            int sore = Convert.ToInt32(sore1);
            if (sore >= 90)
            {
                Console.WriteLine("你的成绩是优");
                    }
            else if (sore >=80)
            {
                Console.WriteLine("你的成绩是良");
                }
            else if (sore >= 70)
            {
                Console.WriteLine("你的成绩是中");
            }
            else if (sore >= 60)
            {
                Console.WriteLine("你的成绩是差");
            }
            else if (sore <60)
            {
                Console.WriteLine("你的成绩是不及格");
            }
            goto cong;
        }
    }
    }
