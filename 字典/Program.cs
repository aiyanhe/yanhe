using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字典
{
    class Program
    {
        //字典（键值对）
        
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(8, "八");//键8————值八
            dic.Add(2, "二");
            dic.Add(3, "三");
            dic.Add(4, "四");
            dic.Add(5, "五");
            dic.Add(6, "六");
            dic.Add(7, "七");
            dic.Remove(8);//通过键来移除键值对；
            //键Key————值value
            foreach (var Key in dic.Keys)//字典的第一种遍历
            {
                Console.WriteLine(dic[Key]);
            }
            foreach (KeyValuePair<int,string> item in dic)//字典的第二种遍历；
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key+":"+item.Value);
            }
            Console.ReadKey();


            dic.Clear();
        }
    }
}
