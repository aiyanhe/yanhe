using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 列表Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();//不限元素的类型，也不限元素的个数（存在不安全类）
            list.Add(5555.1514);
            list.Add(true);
            list.Add("jskahdiu");
            list.Add('d');
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            list.Remove('d');//传入将要移除的元素，第一种移除的方法；当移除的元素不存在时，不会报错；
            Console.WriteLine("移除'd‘后");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            list.RemoveAt(2);//传入要移除元素的索引，第二种移除的方法；当要移除元素的索引不存在时，会报错；
            Console.WriteLine("移除第3个元素后");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            list.Clear();//清空！
            


            List<int> list2 = new List<int>();//限制类型的列表，但不限制元素的个数；
            list2.Add(2);
            list2.Add(5545);
            list2.Add(3434);
            list2.Add(26546);
            list2.Add(23);
            list2.Add(233);
            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i]);
            }
            list2.Remove(23);//传入将要移除的元素；//当移除的元素不存在时，不会报错；
            list2.RemoveAt(3);//传入要移除元素的索引；//当要移除元素的索引不存在时，会报错；
            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i]);
            }
            list2.Clear();//清空；
            Console.ReadKey();





        }
    }
}
