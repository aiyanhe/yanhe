using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //1：编写一个程序，对输入的4个整数，求出其中的最大值和最小值，并显示出来；
            //Console.WriteLine("请输入4个整数");
            //Console.WriteLine("请输入第一个整数");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入第二个整数");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入第三个整数");
            //int num3 = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入第四个整数");
            //int num4 = int.Parse(Console.ReadLine());

            //int max1 = num1 > num2 ? num1 : num2;
            //int max2 = num3 > num4 ? num3 : num4;
            //int max = max1 > max2 ? max1 : max2;

            //int min1 = num1 < num2 ? num1 : num2;
            //int min2 = num3 < num4 ? num3 : num4;
            //int min = min1 < min2 ? min1 : min2;
            //Console.WriteLine("最大数:" + max + "\n" + "最小数:" + min);
            //Console.ReadKey();

            //2：让用户输入两个整数，然后再输入0~3之间的一个数，0代表加，1代表-，*代表乘法；

            //Console.WriteLine("请输入2个整数");
            //Console.WriteLine("请输入第一个整数");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入第二个整数");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("選擇0，1，*（0代表加，1代表-，*代表乘法）");
            //string str = Console.ReadLine();
            //int sum = 0;
            //if (str == "0") {
            //    sum = num1 + num2;
            //}
            //if (str == "1")
            //{
            //    sum = num1 - num2;
            //}
            //if (str == "*")
            //{
            //    sum = num1 * num2;
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();


            //3：求出1~1000之间的所有能被7整除的数，并计算和输出每5个的和；

            //int num = 0;
            //int n1 = 0, n2 = 0, n3 = 0, n4 = 0, sum = 0;
            //for (int i = 0; i <= 1000; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        num++;
            //        if (num == 1)
            //        {
            //            n1 = i;
            //        }
            //        if (num == 2)
            //        {
            //            n2 = i;
            //        }
            //        if (num == 3)
            //        {
            //            n3 = i;
            //        }
            //        if (num == 4)
            //        {
            //            n4 = i;
            //        }
            //        if (num == 5)
            //        {
            //            sum = n1 + n2 + n3 + n4 + i;
            //            Console.WriteLine(sum);
            //            num = 0;
            //        }
            //    }
            //}
            //Console.ReadKey();





            //4：编写一个控制台程序，分别输出1~100之间的平方、平方根；

            //double a, b;
            //for (int i =0;i<=100;i++) {
            //    a = i * i;
            //    b =Math.Sqrt(i);
            //    Console.WriteLine(i+"的平方:"+a);
            //    Console.WriteLine(i + "的平方根:" + b);

            //}
            //Console.ReadKey();



            //5：兔子繁殖问题，设有一对新生的兔子，从第三个月开始他们每个月都生一对兔子，新生的兔子从第三个月开始又每个月生一对兔子。按此规律，
            //并假定兔子没有死亡，20个月后共有多少个兔子？要求编写为控制台程序。
            //b:
            //    Console.WriteLine("请输入月数");
            //    string a = Console.ReadLine();
            //    int yueShu = Convert.ToInt32(a);
            //    int yue = 1;
            //    int duiSu = 1;
            //    bool chengNian = false;
            //    int chengShuo = 0;
            //    int shengZhizhouqi = 1;
            //    while (yue <= yueShu)
            //    {
            //        //在第三个月时
            //        if (yue >= 3)
            //        {
            //            if (shengZhizhouqi >= 3)
            //            {
            //                chengNian = true;
            //            }
            //            //计算成熟的兔子数；
            //            if (chengNian)
            //            {
            //                chengNian = false;
            //                chengShuo++;
            //                shengZhizhouqi = 1;
            //            }
            //            duiSu = duiSu + chengShuo;
            //        }

            //        yue++;
            //        shengZhizhouqi++;
            //    }
            //    Console.WriteLine(yueShu + "个月后共有" + duiSu * 2 + "个兔子");
            //    goto b;


            //6：编程输出1~100中能被3整除但不能被5整除的数，并统计有多少个这样的数。
            //int sum = 0;
            //for (int i = 0;i<=100; i++) {
            //    if (i % 3 == 0 && i % 5 != 0) {
            //        sum++;
            //    }
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();


            // 7：编程输出1000以内的所有素数；
            // int s = 0;
            //for (int i = 1; i <1000; i++)
            //{
            //    s = 0;
            //    for (int t = 2; t <= i; t++)
            //    {
            //        if (i % t == 0)
            //        {
            //            s += t;
            //        }
            //    }
            //    if (s == i)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadKey();





            //8：编程输出九九乘法表；
            //int sum;
            //for (int a = 0; a <= 9; a++)
            //{
            //    for (int b = a; b <= 9; b++)
            //    {

            //        sum = a * b;
            //        Console.Write(a + "乘" + b + "等于" + sum);
            //    }
            //}
            //Console.ReadKey();


            //9：编写一个投骰子100次的程序，并打印出各种点数的出现次数；
            //Random ran = new Random();
            //int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0;
            //for (int i = 0; i <= 100; i++)
            //{

            //    int RandKey = ran.Next(1, 7);
            //    switch (RandKey)
            //    {
            //        case 1:
            //            a++;
            //            break;
            //        case 2:
            //            b++;
            //            break;
            //        case 3:
            //            c++;
            //            break;
            //        case 4:
            //            d++;
            //            break;
            //        case 5:
            //            e++;
            //            break;
            //        case 6:
            //            f++;
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //Console.WriteLine("点数1出现的次数:" + a + "\n点数2出现的次数:" + b + "\n点数3出现的次数:" + c + "\n点数4出现的次数:" + d + "\n点数5出现的次数:" + e + "\n点数6出现的次数:" + f);
            //Console.ReadKey();



            //10：一个控制台应用程序，输出1~5的平方值，要求：用for语句实现。用while语句实现。用do-while语句实现；
            //int sum;
            //for (int i=1;i<=5;i++) {
            //    sum = i * i;
            //    Console.WriteLine(i+"的平方值为"+sum);
            //}
            //int i = 1;



            //while (i <= 5) {
            //    sum = i * i;

            //    Console.WriteLine(i + "的平方值为" + sum);
            //    i++;
            //}



            //do {
            //    sum = i * i;
            //    Console.WriteLine(i + "的平方值为" + sum);
            //    i++;

            //} while (i <= 5);
            //Console.ReadKey();




            ////11：一个控制台应用程序，要求用户输入5个大写字母，如果用户输入的信息不满足要求，提示帮助信息并要求重新输入。
            //    Console.WriteLine("请输入用户名(请输入大写字母)");
            //    string str = Console.ReadLine();
            //    int length = str.Length;
            //    int num;
            //    for (int i = 0; i <= length; i++) {
            //        num = str[i];
            ////        if (num <= 'Z' || num >= 'A') {
            //        if (num <= 65 || num >= 90) {
            //            str = "";
            //            Console.WriteLine("请重新输入（大写字母）");
            //            str = Console.ReadLine();
            //            i = 0;
            //        }

            //}

            //    Console.WriteLine("用户名为:"+str);
            //    Console.ReadKey();




            //12：一个控制台应用程序，要求完成写列功能。
            //1）接受一个整数n。
            //2）如果接收的值n为正数，输出1~n见的全部整数。
            //3）如果接收的值n为负值，用break或者return退出程序。
            //4）如何n为0的话，转到1继续接收下一个整数。
            //l:
            //Console.WriteLine("请输入一个正整数");
            //int n = Convert.ToInt32(Console.ReadLine());
            //if (n > 0) {
            //    for (int i = 1; i <= n;i++ ) {
            //        Console.WriteLine(i);
            //    }
            //    Console.ReadKey();
            //}
            //if (n < 0) {
            //    return;
            //}
            //if (n == 0) {
            //    goto l;
            //}





            //13：一个控制台应用程序，求1000之间的所有"完数"，所谓”完数“是指一个数恰好等于它的所以因子之和，例如6是完数，因为6=1+2+3；
            //            int s = 0;
            //            for (int i = 1; i < 1000; i++) {
            //                s = 0;
            //                for (int t = 1; t < i; t++) {
            //                    if (i % t == 0) {
            //                        s += t;
            //                    }
            //                }
            //                if (s == i)
            //                {
            //                    Console.WriteLine(i);
            //                }
            //            }
            //            Console.ReadKey();

        }
    }
}
