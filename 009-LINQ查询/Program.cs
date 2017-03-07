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
                      where m.age > 12 && m.english > 80//where后面跟上查询的条件
                      select m.name;//表示m的结果并返回
            //第二种写法
            var res2 = studeGanden.Where(Test1);
            //第三种写法
            var res3 = studeGanden.Where(m => m.age > 12 && m.english > 80);//利用lambda表达式
            //LINQ 联合查询
            var res4 = from m in studeGanden
                       from k in sumGanden
                       select new { studeGanden = m, sumGanden = k };
            var res5 = from m in studeGanden
                       from k in sumGanden
                       where m.english > k.SumEnglish && m.math > k.SumMath && m.yuwen > k.Sumyuwen//查找三科及格的学员
                       select m.name;
            //LINQ 联合查询 的扩展方法
            var res6 = studeGanden.SelectMany(m => sumGanden, (m, k) => new { studeGanden = m, sumGanden = k }).Where(x => x.studeGanden.english > x.sumGanden.SumEnglish && x.studeGanden.math > x.sumGanden.SumMath && x.studeGanden.yuwen > x.sumGanden.Sumyuwen);
            //对查询的结果做排序 orderby(descending)
            var res7 = from m in studeGanden
                       where m.age > 12 && m.english > 80
                       //orderby m.age//按照年龄由小到大排序
                       //orderby m.age descending//按照年龄由大到小排序（descending是倒序）
                       orderby m.age, m.Class//按照多个字段进行排序，如果字段的属性相同，就按照第二个属性排序
                       select m.name;
            //var res8=studeGanden.Where(m => m.age > 12 && m.english > 80).OrderBy(m=>m.age).OrderBy(m=>m.Class);//当用lambda表达式时，两个OrderBy会让它将结果排序两次，最后一次排序结果为最终结果
            var res8 = studeGanden.Where(m => m.age > 12 && m.english > 80).OrderBy(m => m.age).ThenBy(m => m.Class);//当用lambda表达式时,OrderBy接一个ThenBy时，就会接着排序

            //5.join on 集合联合
            var res9 = from m in studeGanden
                       join k in sumGanden on m.english equals k.SumEnglish//on接两个列表的条件，两个列表条件相同的成员才会被组合一起
                       where m.age > 8//符合On条件的成员的判断条件
                       select new { studeGanden = m, sumGanden = k };//结果


            foreach (var item in res9)
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
