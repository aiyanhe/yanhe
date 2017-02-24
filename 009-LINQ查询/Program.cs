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
            new StudeGanden(){name ="乐正绫",age  =14,Class = "中V部",yuwen = 88,math = 98,english=95},
            new StudeGanden(){name ="乐正龙牙",age  =18,Class = "中V部",yuwen = 88,math = 98,english=95},
            new StudeGanden(){name ="心华",age  =17,Class = "中V部",yuwen = 88,math = 98,english=95},
            new StudeGanden(){name ="星尘",age  =10,Class = "中V部",yuwen = 88,math = 98,english=95} 
            };
            var sumGanden = new List<SumGanden>()
            {
            new SumGanden(){ SumEnglish = 150,SumMath = 150,Sumyuwen=100} 
            };
            //使用LINQ做查询
            var res = from m in studeGanden//from后面设置查询的集合
                      where m.age > 12//where后面跟上查询的条件
                      select m.name;//表示m的结果并返回
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
