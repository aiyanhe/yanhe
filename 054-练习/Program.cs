using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _054_练习
{
    class Program
    {
                static int Digui2(int num)
        {
            if (num == 0)//这两个是函数终止递归的条件
            {
                return 2;
            }
            if (num == 1)
            {
                return 3;
            }
            return Digui2(num - 1) + Digui2(num - 2);//函数调用自身叫做递归调用；
        }
        struct Xuesheng
        {
            public string studentNumber;
            public string studentName;
            public bool isGril;
            public float grade;

            public void show()
            {
                Console.WriteLine("姓名" + studentName + "性别" + (isGril ? "女" : "男") + "学号" + studentNumber + "成绩" + grade);
            }

        }
        public static long Jecheng(long minNum, long maxNum)
        {
            long sum = 1;
            long all = 0;
            for (long a = minNum; a <= maxNum; a++)
            {
                sum = 1;
                for (int i = 1; i <= a; i++)
                {
                    sum *= i;
                }
                all += sum;
            }
            return all;


        }

        public static long Digui(int num)
        {
            long sum = 1;
            int i = 0;
            bool boom = true;
            for (int i = 1; i <= num; i++)
            {
                sum *= i;

            }
            return sum;
            //while (boom)
            //{
            //    sum *= i;
               
            //    if (i > num)
            //    {
            //        return sum;
            //        boom = false;
            //    }
            //    i++;

            //}


        }
        public static int Shu(float num)
        {
            int sum = 0;
            int num2 = 0;
            for (int i = 1; sum <= num; i++)
            {
                sum += i * i;
                num2 = i;
            }
            return num2;

        }
        public static int fn(int n)
        {
            int num1 = 2;
            int num2 = 3;
            int kong = 0;
            for (int i = 5; i <= n; i++)
            {
                kong = num2;
                num2 = num1 + num2;
                num1 = kong;
            }
            return num2;
        }
        static void Main(string[] args)
        {
            ////1.下列常量中，不是字符常量的是（A）。
            ////A.'\n'  B.'y' C.'x' D.'\7'
            //2.f(n)=f(n-1)+f(n-2) f(0)=2 f(1)=3,用程序求得f(40)
            //Console.WriteLine("请输出一个整数");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int num = 0;
            //switch (n)
            //{
            //    case 0: 
            //        n = 2;
            //        break;
            //    case 1:
            //        n = 3;
            //        break;
            //    default:
            //        num=fn(n);
            //        Console.WriteLine("按斐波那契数列结果为{0}",num);
            //        break;
            //}
            //Console.ReadKey();





            //3，将一个正整数分解质因数。例如：输入90，打印出90=2*3*3*5。测试数据有多组
            //Console.WriteLine("请输出一个正整数");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int sum =0;
            //for (int i = 2; i < num; i++)
            //{
            //    if (num / i == 0)
            //    {
            //        sum++;
            //    }
            //}
            //int[] array= new int[sum];
            //for (int i = 2; i < num; i++)
            //{
            //    if (num / i == 0)
            //    {
            //        array[i - 2] = i;
            //    }
            //}        





            //4，输入两个正整数m和n，求其最大公约数和最小公倍数
            //Console.WriteLine("请输入第一个正整数");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个正整数");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int min = num1 < num2 ? num1 : num2;
            //int max = num1 > num2 ? num1 : num2;
            //int a = 0;
            //int b = 0;
            //bool boom = true;
            //for (int i = 1; i <= min; i++)
            //{
            //    if (num1%i==0&&num2%i==0)
            //    {
            //        a = a > i ? a : i; 
            //    }
            //}
            //Console.WriteLine("两者的最大公约数为"+a);
            //for (int i = max;boom==true; i++)
            //{
            //    if (i%num1==0&&i%num2==0)
            //    {
            //        b = i;
            //        boom = false;
            //    }
            //}
            //Console.WriteLine("两者的最小公倍数为"+b);
            //Console.ReadKey();






            //5，一球从100米高度自由落下，每次落地后反跳回原高度的一半；再落下，求它在第10次落地时，共经过多少米？第10次反弹多高？
            //float length = 100;
            //float max = 10;
            //float sum = length;
            //for (int i = 1; i <= max; i++)
            //{
            //    length = length / 2;
            //    sum += length;
            //}
            //Console.WriteLine("在第10次落地时，共经过{0}米？第10次反弹有{1}？",sum,length);
            //Console.ReadKey();



            //6，题目：求1+2!+3!+...+20!的和？


            int res = Digui2(3);
            Console.WriteLine(res);
            //Console.WriteLine("请输入起始数字");
            //long minNum = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine("请输入结束数字");
            //long maxNum = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine("请输入数字");
            //int num = Convert.ToInt32(Console.ReadLine());
            //long all = Jecheng(minNum,maxNum);
            //long all2 = Digui(num);
            //Console.WriteLine("范围数字的阶乘结果为"+all);
            //Console.WriteLine(num+"的阶乘结果为" + all2);

            //Xuesheng student1;
            //student1.grade = 95;
            //student1.isGril = true;
            //student1.studentName = "言和";
            //student1.studentNumber = "20142605257";
            //student1.show();

            //Console.WriteLine("请输入一个正整数，进行四舍五入");
            //float num = Convert.ToSingle(Console.ReadLine());
            //int num2 = Convert.ToInt32(num);
            //Console.WriteLine("结果为"+num2);



            //Console.WriteLine("请输入终止数字");
            //float num = Convert.ToSingle(Console.ReadLine());
            //int num2 = Shu(num);
            //Console.WriteLine(num2);

            //百元买百鸡，公鸡5元一只，母鸡3元一只，小鸡1元3只，问各种方案！
            //int sumYuan = 100;
            //int sumNum = 100;
            //int gongJi = 0;
            //int muJi = 0;
            //int xiaoJi = 0;
            //int sum = 0;
            //int num=0;
            //for (int i = 0; i <= sumYuan/5; i++)
            //{
            //    for (int a = 0; a <=(sumYuan-i*5)/3; a++)
            //    {
            //        xiaoJi = (sumYuan - i * 5 - a * 3) * 3 / 1;
            //        muJi = a;
            //        gongJi = i;
            //        sum = xiaoJi + muJi + gongJi;
            //        if (sum==sumNum)
            //        {
            //            num++;
            //            Console.WriteLine("方案{0}有{1}只公鸡，{2}只母鸡，{3}只小鸡",num,gongJi,muJi,xiaoJi);
            //        }
            //    }
            //}
            Console.ReadKey();
     


            //7，利用递归方法求5!.`

            //8，编一个程序，定义结构类型(有学号，姓名，性别和程序设计成绩四个阶段)，声明该结构类型变量，用赋值语句对该变量赋值以后再输出。
            //9，编一个程序，输入一个正数，对该数进行四舍五入到个位数的运算。例如：实数12.56经过四舍五入运算，得到结果13；而12.46经过四舍五入运算，得到结果12
            //10，有关系式1*1+2*2+3*3+...+k*k<2000,编一个程序，求出满足此关系式的k的最大值
            //11.编一个程序，解决百钱买白鸡问题，某人又100元钱，要买100只鸡。公鸡5元钱一只，母鸡3元钱一只，小鸡一元钱3只，问可买到公鸡，母鸡，小鸡各为多少只，把所有的可能性打印出来。

        }
    }
}
