using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016__列表List的创建和使用
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> score1 = new List<int>();//创建一个空的列表 通过类型后面的<>来表示这个列表存储的数据类型
            var score2 = new List<int>();//通过匿名函数来声明列表；
            var score3 = new List<int>(){1,2,3};//创建了一个列表，里面有初始值
            score1.Add(12);//向列表中插入数据
            Console.WriteLine(score1[0]);//根据索引访问数据
            //Console.WriteLine(score1[2]);//索引不存在的时候，会出现异常；

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Capacity(列表的容量):" + score2.Capacity + "            Count(列表的成员数)" + score2.Count);
                score2.Add(10);
                //当超出容量时，列表的新容量扩大为旧容量的两倍；
            }
            Console.WriteLine("Capacity(列表的容量):" + score2.Capacity + "            Count(列表的成员数)" + score2.Count);
            //每次列表扩容时，都是创建一个新的数组，使用Array.Copy()方法将旧数组中的元素复制到新数组中，为了节省性能，可以先规定好列表的容量；
            Console.ReadKey();
        }
    }
}
