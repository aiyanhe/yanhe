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
            new SumGanden(){ SumEnglish = 85,SumMath = 85,Sumyuwen=50},
            new SumGanden(){ SumEnglish = 90,SumMath = 88,Sumyuwen=92}
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
            //反编译如下
            //var enumerable = source.SelectMany(((Func<StudeGanden, IEnumerable<SumGanden>>)(m => sumGanden)), (<> c.<> 9__0_1 ?? (<> c.<> 9__0_1 = new Func<StudeGanden, SumGanden, <>f__AnonymousType0 < StudeGanden, SumGanden >> (<> c.<> 9.< Main > b__0_1)))).Where(<> c.<> 9__0_2 ?? (<> c.<> 9__0_2 = new Func<<> f__AnonymousType0<StudeGanden, SumGanden>, bool > (<> c.<> 9.< Main > b__0_2)));

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



            //6，分组查询 into groups(把武林高手按照所学功夫分类，看一下哪个功夫修炼的人数最多)
            var res10 = from k in studeGanden
                        join m in sumGanden on k.english equals m.SumEnglish
                        into groups
                        orderby groups.Count()
                        select new { studeGanden = k, count = groups.Count() };

            //8.量词操作符 any all 判断集合中是否满足某个条件
            bool resb = studeGanden.Any(m=>m.age <18);//判断集合中是否有满足条件的成员，返回值为Bool;
            Console.WriteLine(resb);
            bool resAll = studeGanden.All(m=>m.age<18);//判断集合中是否所有成员都满足条件，返回值为Bool;
            Console.WriteLine(resAll);



            foreach (var item in res6)
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
