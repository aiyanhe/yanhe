using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017__操作列表的属性和方法
{
    class Program
    {
        static void Main(string[] args)
        {
            var lis = new List<int>();
            lis.Add(100);
            lis.Add(200);
            lis.Add(500);
            lis.Add(200);
            lis.Add(300);
            lis.Insert(3,300);
            foreach (var item in lis)
            {
                Console.Write("  "+item);
            }
            Console.WriteLine("");
            Console.WriteLine("Capacity(列表的容量):" + lis.Capacity + "    Count(列表的元素个数)：" + lis.Count);
            Console.WriteLine("从前往后搜索，元素为300的索引位置为"+lis.IndexOf(300)+ "从后往前搜索，元素为300的索引位置为"+lis.LastIndexOf(300));
            Console.WriteLine("");
            lis.Remove(200);//从前往后搜索，第一个元素为200的元素被移除；
            lis.RemoveAt(2);//移除指定索引位置的元素；
            foreach (var item in lis)
            {
                Console.Write("  " + item);
            }
            Console.WriteLine("");
            lis.Sort();//让列表元素按从小到大排序
            foreach (var item in lis)
            {
                Console.Write("  " + item);
            }
            Console.ReadKey();
        }
    }
}
