using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blbl
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
            //int i = 0;
            //bool boom = true;
            for (int i = 1; i <= num; i++)
            {
                sum *= i;

            }
            return sum;


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
        static void Main(string[] args)
        {
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
        }
    }
}
