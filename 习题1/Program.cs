using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 习题1
{
    class Program
    {


        public static bool Year(int years)
        {
            if ((years%4==0&&years%100!=0)||years%400==0||(years%3200==0&&years%172800==0))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public static string Str(string str)
        {
            if ('a'<= str[0] && str[0] <= 'z')
            {
                str = str.ToUpper();
                return str;
            }
            else if ('A' <= str[0] && str[0] <= 'Z')
            {
                str = str.ToLower();
                return str;
            }
            else
            {
                return str;
            }

        }
        public static float Max(string str)
        {
            
            string[] str1 = str.Split(' ');
            float max =Convert.ToSingle(str1[0]);
            float min = 0;
            for (int i = 1; i < str1.Length; i++)
            {
                min = Convert.ToSingle(str1[i]);
                max = max > min ? max : min;
            }
            return max;
        }
        public static bool IsPositive(float num) 
        {
            bool boom = true;
            if (num>0)
            {
                boom = true;
            }
            else
            {
                boom = false;
            }
            return boom;
        }
        public static bool IsAdult(int num)
        {
            bool boom = true;
            if (num>=18)
            {
                boom = true;
            }
            else
            {
                boom = false;
            }
            return boom;
        }
        public static string Score(float num)
        {
            if (num>=90)
            {
                return "A";
            }
            else if (num>=80)
            {
                return "B";
            }
            else if (num>=70)
            {
                return "C";
            }
            else if (num>=60)
            {
                return "D";
            }
            else
            {
                return "E";
            }
        
        
        }
        public static int Sum(int num1,int num2)
        {
            int sum = 0;
            for (int i = num1; i <= num2; i++)
            {
                sum += i;
            }
            return sum;
        }
        public static int primeNum(int num1, int num2)
        {
            int sum = 0;
            bool isPrime = true;
            for (int i = num1; i <= num2; i++)
            {
                for (int a = 2; a < i; a++)
                {
                    if (i%a==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    sum++;
                }
                isPrime = true;
            }
            return sum;
        }
        public static int OddSum(int num1, int num2)
        {
            int sum = 0;
            for (int i = num1; i <= num2; i++)
            {
                if (i%2!=0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        public static int[] narcissisticNum(int adNum,int edNum)
        {
            List<int> lis = new List<int>();
            string str = "";
            string ad = "";
            int length =0;
            int temp =0;
            int sum =0;
            for (int i = adNum; i <= edNum; i++)
            {
                sum =0;
                ad = i.ToString();
                length = ad.Length;
                for (int a = 0; a < length; a++)
			{
                str = Convert.ToString(ad[a]);
                    temp =Convert.ToInt32(str);
                    temp =Convert.ToInt32(Math.Pow(temp,length));
                    sum+=temp;
			}
                if (sum==i)
                {
                    lis.Add(i);
                }
            }
             int[] arr =new int[lis.Count];
             for (int i = 0; i < arr.Length; i++)
             {
                 arr[i] = lis[i];
             }
             return arr;
        
        }
        public static string ShengXiao(int year)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(0,"鼠");
            dic.Add(1,"牛");
            dic.Add(2,"虎");
            dic.Add(3,"兔");
            dic.Add(4,"龙");
            dic.Add(5,"蛇");
            dic.Add(6,"马");
            dic.Add(7,"羊");
            dic.Add(8,"猴");
            dic.Add(9,"鸡");
            dic.Add(10,"狗");
            dic.Add(11,"猪");
            int num = (year-4) % 12;
            return dic[num];
        }
        public static int[] MaxMin(string str)
        {
            int[] array =new int[2];
            string[] arr = str.Split(' ');
            //List<int> lis = new List<int>();
            //foreach (var item in arr)
            //{
            //    lis.Add(Convert.ToInt32(item));
            //}
            //int max = lis[0];
            //int num = 0;
            //while (num<2)
            //{
            //    for (int i = 1; i < lis.Count; i++)
            //    {
            //        max = max > lis[i] ? max : lis[i];
            //    }
            //    array[num] = max;
            //    lis.Remove(max);
            //    num++;
            //}



            //冒泡排序
            int temp = 0;
            int[] arr1 = new int[arr.Length];
            for (int i = 0; i <arr.Length; i++)
            {
                arr1[i] = Convert.ToInt32(arr[i]);
            }
            for (int i = 1; i < arr1.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr1[j]<arr1[i])
                    {
                        temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;
                    }
                }
            }
            return arr1;
            
            
        }
        public static int Arr(int[] arrInt,int num)
        {;
            for (int i = 0; i < arrInt.Length; i++)
            {
                if (num==arrInt[i])
                {
                    return i;//return 1.返回数据  2.跳出方法！
                }

            }
            return -1;
        }
        public static List<int> PerfectNum(int adNum,int edNum)
        {
            List<int> lis = new List<int>();
            int sum = 0;
            for (int i = adNum; i <= edNum; i++)
            {
                sum = 0;
                for (int a = 1; a < i; a++)
                {
                    if (i%a==0)
                    {
                        sum += a;
                    }
                }
                if (sum == i)
                {
                    lis.Add(i);
                }
            }
            return lis;


        }
        public static float AverageNum(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            float average = sum*1.0f / (arr.Length);
            return average;

        }
        static void Main(string[] args)
        {
            #region 第一题
            // 1.写1个方法 判断1个年份是不是闰年.
            //普通年能被4整除且不能被100整除的为闰年。（如2004年就是闰年,1900年不是闰年）
            //世纪年能被400整除的是闰年。(如2000年是闰年，1900年不是闰年)
            //对于数值很大的年份,这年如果能整除3200,并且能整除172800则是闰年
            // Console.WriteLine("请输入一个年份，判断该年份是不是闰年.");
            //int num = Convert.ToInt32(Console.ReadLine());
            //bool boom = Year(num);
            //if (boom)
            //{
            //    Console.WriteLine(num + "年是闰年");
            //}
            //else
            //{
            //    Console.WriteLine(num + "年不是闰年");
            //}
            #endregion
            #region 第二题
            //2.写1个方法 传入1个字符 如果是大写字母就转换为小写字母 如果是小写字母就转换为大写字母 如果都不是则原样返回.


            //Console.WriteLine("请输入一个字符");
            //string str = Console.ReadLine();
            //str = Str(str);
            //Console.WriteLine("转化后的结果:" + str);
            #endregion
            #region 第三题
            //3.写1个方法,找出三个数中的最大数

            //Console.WriteLine("请输入三个数");
            //string threeNum = Console.ReadLine();
            //float max = Max(threeNum);
            //Console.WriteLine("最大数为"+max);

            #endregion
            #region 第四题
            //4.写1个方法 判断1个数 是否是 正数.
            //Console.WriteLine("请输入一个数，判断是否为正数");
            //float num = Convert.ToSingle(Console.ReadLine());
            //bool boom = IsPositive(num);
            //if (boom)
            //{
            //    Console.WriteLine("是正数");
            //}
            //else
            //{
            //    Console.WriteLine("是负数");
            //} 
            #endregion
            #region 第五题
            //5.写1个方法,根据用户的年龄判断是否适合查看网站的内容,大于等于18岁适合查看 否则不适合
            //Console.WriteLine("请输入你的年龄");
            //int year = Convert.ToInt32(Console.ReadLine());
            //bool boom = IsAdult(year);
            //if (boom)
            //{
            //    Console.WriteLine("可以观看");
            //}
            //else
            //{
            //    Console.WriteLine("小屁孩，回去喝奶");
            //} 
            #endregion
            #region 第六题
            ////6.写1个方法,根据分数返回这个分数的所在的等级 成绩>= 90 ：A, 成绩 >= 80 ：B,成绩 >= 70 ：C,  成绩 >= 60 ：D  , 成绩 < 60   ：E
            //Console.WriteLine("请输入你的成绩，判断等级");
            //float score = Convert.ToSingle(Console.ReadLine());
            //string str = Score(score);
            //Console.WriteLine("你的等级为" + str); 
            #endregion
            #region 第七题
            //7.写1个方法,求指定范围的整型数的累加和
            //Console.WriteLine("请输入起始整数");
            //int adNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入结束整数");
            //int edNum = Convert.ToInt32(Console.ReadLine());
            //int sum = Sum(adNum,edNum);
            //Console.WriteLine("累加和为"+sum); 
            #endregion
            #region 第八题
            //8.写1个方法，求指定范围中能被6整除的数的累加和
            //Console.WriteLine("请输入起始整数");
            //int adNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入结束整数");
            //int edNum = Convert.ToInt32(Console.ReadLine());
            //int sum = Sum6(adNum, edNum);
            //Console.WriteLine("能被6整除的数的累加" + sum);  
            #endregion
            #region 第九题
            //9.写1个方法.求指定范围中的素数的个数有多少个
            //Console.WriteLine("请输入起始整数");
            //int adNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入结束整数");
            //int edNum = Convert.ToInt32(Console.ReadLine());
            //int sum = primeNum(adNum, edNum);
            //Console.WriteLine("指定范围中的素数的个数有" + sum);   
            #endregion
            #region 第十题
            //10.写1个方法 求指定范围中所有奇数的累加和
            //Console.WriteLine("请输入起始整数");
            //int adNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入结束整数");
            //int edNum = Convert.ToInt32(Console.ReadLine());
            //int sum = OddSum(adNum, edNum);
            //Console.WriteLine("所有奇数的累加和" + sum);    
            #endregion
            #region 第十一题
            //11.写1个方法 求100 - 999之间的所有的水仙花数 并返回  返回多个数据（使用数组返回） 
            //Console.WriteLine("请输入起始整数");
            //int adNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入结束整数");
            //int edNum = Convert.ToInt32(Console.ReadLine());
            //int[] arr =narcissisticNum(adNum,edNum);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #region 第十二题
            //12.写1个方法 根据年份得到这个年份的生肖
            //2017-鸡，2018-狗，2019-猪，2020-鼠，3-猪，1-鸡；
            //Console.WriteLine("请输入年份（正整数），判断该年份所属的生肖");
            //int num = Convert.ToInt32(Console.ReadLine());
            //string str = ShengXiao(num);
            //Console.WriteLine("该年份所属的生肖为"+str); 
            #endregion
            #region 第十三题
            //13.写1个方法 返回1个整型数组中的最大值和次大值
            //Console.WriteLine("请输入一个整型数组(用空格隔开)");
            //string str = Console.ReadLine();
            //int[] arr = MaxMin(str);
            //int max = arr[0];
            //int nextMax = 0;
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i]!=max)
            //    {
            //        nextMax = arr[i];
            //        Console.WriteLine("整型数组中的次大值为" + nextMax);
            //        break;
            //    }
            //    if (i==arr.Length-1)
            //    {
            //        Console.WriteLine("没有次大值");
            //    }
            //}
            //Console.WriteLine("整型数组中的最大值为" + max);
           
            #endregion
            #region 第十四题
            //14.写1个方法 查找指定数组中指定的元素的下标是多少 没有则返回-1.
            //int[] arrInt = new int[]{32165,313,1,654,321,64,32,136,54};
            //int num = Arr(arrInt,32);
            //Console.WriteLine("该元素的下标是"+num); 
            #endregion
            #region 第十五题
            //15.写1个方法 查找指定范围内的所有的完数 并将这些完数返回. 
            //第一个完全数是6，它有约数1、2、3、6，除去它本身6外，其余3个数相加，1+2+3=6。
            //Console.WriteLine("请输入起始数");
            //int adNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入终止数");
            //int edNum = Convert.ToInt32(Console.ReadLine());
            //List<int> list = PerfectNum(adNum, edNum);
            //Console.WriteLine("完美数有：");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 第十六题
            //16.计算输入数组的平均值average：int Sum(int[] values)   
            //int[] lis = { 33, 36, 23, 12, 43, 15, 4, 13, 43 };
            //float aver = AverageNum(lis);
            //Console.WriteLine("该数组的平均值为" + aver);
            #endregion
            Console.ReadKey(); 
        }
    }
}
