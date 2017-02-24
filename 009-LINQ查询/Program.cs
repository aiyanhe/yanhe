using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_LINQ查询
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StudeGanden> studeGanden = new List<StudeGanden>()
            {
            new StudeGanden(){name ="言和",age  =15,Class = "中V部",yuwen = 88,math = 98,english=95},
            new StudeGanden(){name ="天依",age  =13,Class = "中V部",yuwen = 55,math = 44,english=66},
            new StudeGanden(){name ="乐正绫",age  =14,Class = "中V部",yuwen = 69,math = 85,english=57},
            new StudeGanden(){name ="乐正龙牙",age  =18,Class = "中V部",yuwen = 87,math = 86,english=88},
            new StudeGanden(){name ="心华",age  =17,Class = "中V部",yuwen = 75,math = 75,english=92},
            new StudeGanden(){name ="星尘",age  =10,Class = "中V部",yuwen = 98,math = 79,english=85} 
            };
            var sumGanden = new List<SumGanden>()
            {
            new SumGanden(){ SumEnglish = 85,SumMath = 85,Sumyuwen=50} 
            };
            //使用LINQ做查询
            //第一种写法
            var res = from m in studeGanden//from后面设置查询的集合
                      where m.age > 12&&m.english>80//where后面跟上查询的条件
                      select m.name;//表示m的结果并返回
            //第二种写法
            var res2 = studeGanden.Where(Test1);
            //第三种写法
            var res3 = studeGanden.Where(m => m.age > 12 && m.english > 80);//利用lambda表达式
            //LINQ 联合查询
            var res4 = from m in studeGanden
                       from k in sumGanden
                       select new { studeGanden = m,sumGanden = k};
            var res5 = from m in studeGanden
                       from k in sumGanden
                       where m.english > k.SumEnglish && m.math > k.SumMath && m.yuwen > k.Sumyuwen//查找三科及格的学员
                       select m.name;
            //LINQ 联合查询 的扩展方法
            var res6 = studeGanden.SelectMany(,)





            foreach (var item in res5)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        public static bool Test1(StudeGanden aa)
        {
            if (aa.age > 12 &&aa.english > 80)
            {
                return true;
            }
            return false;
        }
    }
}
