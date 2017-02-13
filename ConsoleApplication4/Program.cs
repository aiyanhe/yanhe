using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        public static void SearchMax(List<int> theList)
        {
            int temp = theList[0] ;
            for (int i = 1; i < theList.Count; i++)
            {
                if (temp < theList[i])
                {
                    temp = theList[i];
                }
            }
            Console.WriteLine("最大值为" + temp);
        }
        static void Main(string[] args)
        {
            List<int> listInput = new List<int>();

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("请输入第{0}个整数：", i);
                listInput.Add(int.Parse(Console.ReadLine()));
            }
            SearchMax(listInput);
            Console.ReadKey();
        }
    }
}
