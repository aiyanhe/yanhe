using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 课堂练习
{
    class Program
    {
        static void Main(string[] args)
        {
        //   1.提示用户输入用户名，然后再提示输入密码，如果用户名是“admin”并且密码是“888888”，就提示正确
        //   否则提示到底是谁错了.
        //   用户名错了.
        //   密码错了
        //   用户名密码都错.



        //Attribute:
        //Console.WriteLine("请输入用户名");
        //string userName = Console.ReadLine();
        //Console.WriteLine("请输入密码");
        //string password = Console.ReadLine();
        //if (userName == "admin")
        //{
        //    if (password == "888888")
        //    {
        //        Console.WriteLine("输入正确");
        //    }
        //    else
        //    {
        //        Console.WriteLine("密码错误");
        //    }
        //}
        //else
        //{
        //    if (password == "888888")
        //    {
        //        Console.WriteLine("用户名错误");
        //    }
        //    else
        //    {
        //        Console.WriteLine("用户名和密码错误");
        //    }
        //    goto Attribute;
        //    Console.ReadKey();






        //2.提示用户输入年龄，如果大于等于18，则告知用户可以查看，
        //   如果小于10岁，则告知不允许查看，
        //   如果大于等于10岁并且小于18，
        //   则提示用户是否继续查看（yes、no），如果输入的是yes则提示用户请查看，否则提示"退出,你放弃查看"。
        //args:
        //string chess = "";
        //Console.WriteLine("请输入年龄");
        //int age = int.Parse(Console.ReadLine());
        //if (age>=18)
        //{
        //    Console.WriteLine("可以查看");
        //}
        //else
        //{
        //    if (age>=10)
        //    {
        //        Console.WriteLine("确定查看？请输入yes或者no");
        //        chess=Console.ReadLine();
        //        switch (chess)
        //        {
        //            case "yes":
        //                Console.WriteLine("请查看");
        //                break;
        //            case "no":
        //                Console.WriteLine("退出,你放弃查看");
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("不允许查看");
        //    }
        //}
        //goto args;
        //Console.ReadKey();









        //3.输入一个字符，判定它是什么类型的字符（大写字母，小写字母，数字或者其它字符）

        //Attribute:
        //Console.WriteLine("请输入一个字符");
        //int ASCIInum =Convert.ToChar(Console.ReadLine());
        //if (ASCIInum >= 48 && ASCIInum <= 57)
        //{
        //    Console.WriteLine("输入的字符为数字");
        //}
        //else
        //{
        //    if (ASCIInum >= 97 && ASCIInum <= 122)
        //    {
        //        Console.WriteLine("输入的字符为小写字符");
        //    }
        //    else
        //    {
        //        if (ASCIInum >= 65 && ASCIInum <= 90)
        //        {
        //            Console.WriteLine("输入的字符为大写字符");
        //        }
        //        else
        //        {
        //            Console.WriteLine("输入的字符为其它字符");
        //        }
        //    }
        //}
        //goto Attribute;














        //4.对学员的结业考试成绩做出评测 成绩 >= 90 ：A, 成绩 >= 80 ：B,成绩 >= 70 ：C,  成绩 >= 60 ：D  , 成绩 < 60   ：E

        //Attribute:
        //    Console.WriteLine("请你的成绩");
        //    float grade = Convert.ToSingle(Console.ReadLine());
        //    if (grade>=90)
        //    {
        //        Console.WriteLine("你的成绩为A");
        //    }
        //    else
        //    {
        //        if (grade >= 80)
        //        {
        //            Console.WriteLine("你的成绩为B");
        //        }
        //        else
        //        {
        //            if (grade >= 70)
        //            {
        //                Console.WriteLine("你的成绩为C");
        //            }
        //            else
        //            {
        //                if (grade >= 60)
        //                {
        //                    Console.WriteLine("你的成绩为D");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("你的成绩为E");
        //                }
        //            }
        //        }
        //    }
        //    goto Attribute;









        //5.编一个程序，输入一个整数,如果该数大于0，则加上100，如果小于0加上500，如果等于0,则什么都不做输出结果
        //Attribute:
        //    Console.WriteLine("请输入一个整数");
        //    float num = Convert.ToSingle(Console.ReadLine());
        //    if (num > 0)
        //    {
        //        num += 100;
        //        Console.WriteLine(num);
        //    }
        //    else if (num < 0)
        //    {
        //        num += 500;
        //        Console.WriteLine(num);
        //    }
        //    else
        //    {
        //        Console.WriteLine(num);
        //    }
        //    goto Attribute;













            // 6.由用户输入鸡蛋的总数量,如果坏蛋率小于10 %,则吃掉,否则找超市去退货.坏蛋的数量随机产生
            //    坏蛋率: 坏蛋的数量 / 鸡蛋的总数量.
            //100
            //5
            //Attribute:
            //    Console.WriteLine("请输出你买了几个鸡蛋");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    Random a = new Random();
            //    int bad = a.Next(0, num + 1);
            //    float badnum = bad * 1f / num;
            //    switch (badnum < 0.1)
            //    {
            //        case true:
            //            Console.WriteLine("坏蛋率:" + badnum);
            //            Console.WriteLine("坏蛋不多");
            //            break;
            //        case false:
            //            Console.WriteLine("坏蛋率:" + badnum);
            //            Console.WriteLine("坏蛋太多，去退货");
            //            break;
            //        default:
            //            break;
            //    }
            //    goto Attribute;











            //7.输入一个正数，对该数进行四舍五入到个位数的运算。
            //   例如，实数12.56经过四舍五入运算，得到结果13；而12.46经过四舍五入运算，得到结果12。 
            //int newNum;
            //bool boom = true;
            //float num = 0;
            //do
            //{
            //    Console.WriteLine("请输入一个正数");
            //    num = Convert.ToSingle(Console.ReadLine());
            //    if (num > 0)
            //    {
            //        newNum = Convert.ToInt32(num);
            //        Console.WriteLine("结果为" + newNum);
            //        boom = false;
            //    }
            //} while (boom);
            //Console.ReadKey();













            //8.判断输入的年份是否是闰年.年份要求由用户输入
            //润年的判定(符合下面两个条件之一):
            //   a.让用户年份能够被400整除.
            //   b.年份能够被4整除但不能被100整除.
            //   如果是闰年 就打印是闰年 如果不是闰年 就打印不是闰年,
            //a:
            //Console.WriteLine("请输入年份");
            //int years = Convert.ToInt32(Console.ReadLine());
            //if (years % 400 == 0 || (years % 4 == 0 && years % 100 != 0))
            //{
            //    Console.WriteLine(years + "年是闰年");
            //}
            //else
            //{
            //    Console.WriteLine(years + "年不是闰年");
            //}
            //goto a;



            //9.编一个程序，从键盘上输入三个数，把最大数找出来。
            //a:
            //Console.WriteLine("请输入三个数");
            //Console.WriteLine("请输入第一个数");
            //float num1 = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("请输入第二个数");
            //float num2 = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("请输入第三个数");
            //float num3 = Convert.ToSingle(Console.ReadLine());
            //float max1 = num1 > num2 ? num1 : num2;
            //float max = max1 > num3 ? max1 : num3;
            //Console.WriteLine("最大数为"+max);
            //goto a;


            //10、盖茨买了一筐鸡蛋，如果坏蛋少于5个，他就吃掉，否则他就去退货(坏蛋的数量随机产生)


            //Attribute:
            //Console.WriteLine("盖茨买了几个鸡蛋");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Random a = new Random();
            //int bad = a.Next(0, num + 1);
            //switch (bad < 5)
            //{
            //    case true:
            //        Console.WriteLine("坏蛋不多");
            //        Console.WriteLine("吃到");
            //        break;
            //    case false:
            //        Console.WriteLine("坏蛋太多，去退货");
            //        break;
            //    default:
            //        break;
            //}
            //goto Attribute;


            //11、 要求用户输入两个数a、b，如果a能被b整除或者a加b大于100，则输出a的值，否则输出b的值
            //a:
            //Console.WriteLine("请输入二个数");
            //Console.WriteLine("请输入第一个数");
            //float a = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("请输入第二个数");
            //float b = Convert.ToSingle(Console.ReadLine());
            //switch (a%b==0||a+b>100)
            //{
            //    case true:
            //        Console.WriteLine(a);
            //        break;
            //    case false:
            //        Console.WriteLine(b);
            //        break;
            //    default:
            //        break;
            //}
            //goto a;


            //1. 循环录入5个人的年龄并计算平均年龄,如果录入的数据出现负数或大于100的数,立即停止输入并报错.
            //a:
            //Console.WriteLine("计算几个人的平均年龄");
            //int pNum = Convert.ToInt32(Console.ReadLine());
            //float sum=0,meanAge=0,iAge=0;
            //for (int i = 1; i <= pNum; i++)
            //{
            //    Console.WriteLine("请输入第" + i + "个人的年龄");
            //    iAge=Convert.ToSingle(Console.ReadLine());
            //    sum += iAge;
            //    meanAge = sum/i;
            //    if (iAge<0||iAge>100)
            //    {
            //        Console.WriteLine("输入的年龄有错误！");
            //        break;
            //    }
            //    Console.WriteLine("平均年龄为"+meanAge);
            //}
            //goto a;




            //2  实现要求用户一直输入用户名和密码，只要不是admin、888888就一直提示要求重新输入,如果正确则提登录成功.

            //bool boom = true;
            //bool boom2 = true;
            //string password = "";

            //string userName;
            //do
            //{
            //    Console.WriteLine("请输入用户名");
            //    userName = Console.ReadLine();

            //    if (userName == "admin")
            //    {
            //        do
            //        {
            //            Console.WriteLine("请输入密码");
            //            password = Console.ReadLine();
            //            if (password == "888888")
            //            {
            //                Console.WriteLine("输入正确");
            //                boom = false;
            //                boom2 = false;
            //            }
            //            else
            //            {
            //                Console.WriteLine("密码错误,请重新输入");
            //                boom2 = true;
            //            }
            //        } while (boom2);

            //    }
            //    else
            //    {
            //        Console.WriteLine("用户名错误，请重新输入");
            //        boom = true;
            //    }
            //} while (boom || boom2);

            //Console.ReadKey();






            //3. 1~100之间的整数相加，得到累加值大于20的当前数 1+2+3+4+5+6 break.

            //a:
            //Console.WriteLine("请输入临界值");
            //int Num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入最大整数");
            //int maxNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入最小整数");
            //int minNum = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (int i = minNum; i <= maxNum; i++)
            //{
            //    sum += i;
            //    if(sum>Num)
            //    {
            //        Console.WriteLine("当前数为"+i);
            //        break;
            //    }
            //}
            //goto a;



            //4. 计算1到100(含)之间的除了能被7整除之外所有整数的和。 1-100之间不能够被7整除的数的和.
            //a:
            //Console.WriteLine("请输入最大值");
            //int maxNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入最小值");
            //int minNum = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (int i = minNum; i <= maxNum; i++)
            //{
            //    if (i%7!=0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(minNum+"~"+maxNum+"之间不能够被7整除的数的和"+sum);
            //goto a;


            //5 .求1-10的累加和

            //a:
            //Console.WriteLine("请输入最大值");
            //int maxNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入最小值");
            //int minNum = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (int i = minNum; i <= maxNum; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(minNum + "~" + maxNum + "的累加和" + sum);
            //goto a;


            //6 .求1-100之间6的倍数的个数


            //a:
            //Console.WriteLine("请输入最大值");
            //int maxNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入最小值");
            //int minNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入临界数");
            //int Num = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (int i = minNum; i <= maxNum; i++)
            //{
            //    if (i % 6 == 0)
            //    {
            //        sum += 1;
            //    }
            //}
            //Console.WriteLine(minNum + "~" + maxNum + "之间"+Num+"的倍数的个数为" + sum);
            //goto a;







            //7 .输入班级人数,然后依次输入学员成绩，计算班级学员的平均成绩和总成绩

            //a:
            //Console.WriteLine("请输入班级人数");
            //int pNum = Convert.ToInt32(Console.ReadLine());
            //float sumGrade = 0, meanGrade = 0, grade = 0;
            //for (int i = 1; i <= pNum; i++)
            //{
            //    Console.WriteLine("请输入第" + i + "个人的成绩");
            //    grade = Convert.ToSingle(Console.ReadLine());
            //    sumGrade += grade;
            //    meanGrade = sumGrade / i;
            //}
            //Console.WriteLine("平均成绩为" + meanGrade);
            //Console.WriteLine("总成绩为" + sumGrade);
            //goto a;








            //4. 2006年培养学员80000人，每年增长25%，请问按此增长速度，到哪一年培训学员人数将达到20万人？

            //a:
            //Console.WriteLine("请输入起始年数");
            //int years = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入起始人数");
            //float startNum = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("请输入增长速度");
            //float speed = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("请输入结束人数");
            //float endNum = Convert.ToSingle(Console.ReadLine());
            //float pNum = startNum;
            //int lei = 0;
            //for (int i = 1;pNum<endNum;i++)
            //{
            //    pNum = pNum*(1+speed);
            //    lei = i+years;
            //}
            //Console.WriteLine("到"+lei+"年培训学员人数将达到"+endNum+"万人");
            //goto a;



            //5.从键盘输入10个数,求出最大数.
            //a:
            //    Console.WriteLine("请输入总个数");
            //    int sumNum = Convert.ToInt32(Console.ReadLine());
            //    int max = 0;
            //    for (int i = 1; i <= sumNum; i++)
            //    {
            //        Console.WriteLine("请输入第" + i + "个数");
            //        int num = Convert.ToInt32(Console.ReadLine());
            //        max = max > num ? max : num;
            //    }
            //    Console.WriteLine("最大数为" + max);
            //    goto a;








            //6.1000~ 9999之间有多少整数，其各位数字之和为5，分别是哪些数（例如整数2003的各位数字之和为 2+0+0+3 ，等于5）），并统计满足条件的整数有多少个。


            //b:
            //    Console.WriteLine("请输入最大整数");
            //    int maxNum = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("请输入最小整数");
            //    int minNum = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("请输入临界数");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    int sum = 0;
            //    int num1 = 0;
            //    string str = "";
            //    int length = 0;
            //    int f = 0;
            //    for (int i = minNum; i <= maxNum; i++)
            //    {
            //        sum = 0;
            //        str = Convert.ToString(i);
            //        length = str.Length;
            //        //sum = (i / 1000) % 10 + (i / 100) % 10 +( i / 10) % 10 + i % 10
            //        for (int b = 0; b <= length; b++)
            //        {
            //            f = Convert.ToInt32(Math.Pow(10, b));
            //            sum += i / f %10;
            //        }
            //        if (sum==num)
            //        {
            //            Console.WriteLine(i);
            //            num1++;
            //        }

            //    }
            //    Console.WriteLine("满足条件的整数有" + num1 + "个");
            //    goto b;



            //b:
            //    Console.WriteLine("请输入最大整数");
            //    int maxNum = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("请输入最小整数");
            //    int minNum = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("请输入临界数");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    int sum = 0;
            //    int num1 = 0;
            //    string str2 = "";
            //    string str = "";
            //    int length = 0;
            //    for (int i = minNum; i <= maxNum; i++)
            //    {
            //        str = Convert.ToString(i);
            //        length = str.Length;
            //        for (int a = 0; a <length; a++)
            //        {
            //            str2 = Convert.ToString(str[a]);
            //            num1 += Convert.ToInt32(str2);
            //        }
            //        if (num1 == num)
            //        {
            //            Console.WriteLine(i);
            //            sum++;
            //        }
            //        num1 = 0;
            //    }
            //    Console.WriteLine("满足条件的整数有" + sum+"个");
            //    goto b;





            //7. 判断101-200之间有多少个素数，并输出所有素数。  素数指在一个大于1的自然数中，除了1和此整数自身外，不能被其他自然数整除的数 ***** 
            //   20  拿出2-19中的每1个整数.拿去被20模 只要有1个为0 就说明不是素数.    
            //   111.   1  111    2-110 
            //b:
            //    Console.WriteLine("请输入最大整数");
            //    int maxNum = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("请输入最小整数(请大于1)");
            //    int minNum = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("下面的为结果");
            //    int s = 0;
            //    int sum = 0;
            //    for (int i = minNum; i <= maxNum; i++)
            //    {
            //        s = 0;
            //        for (int t = 2; t <= i; t++)
            //        {
            //            if (i % t == 0)
            //            {
            //                s += t;
            //            }
            //        }
            //        if (s == i)
            //        {
            //            sum ++;

            //            Console.WriteLine(i);
            //        }
            //    }
            //    Console.WriteLine("有{0}个素数",sum);

            //    goto b;











            //12. 求1-100中 是7的倍数 的数值之和
            //Attribute:
            //Console.WriteLine("请输入最大整数");
            //int maxNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入最小整数");
            //int minNum = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (int i = minNum; i <= maxNum; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine("7的倍数 的数值之和为" + sum);
            //goto Attribute;












            //9. 求1-1000之间的所有的奇数之和


            //Attribute:
            //    Console.WriteLine("请输入最大整数");
            //    int maxNum = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("请输入最小整数");
            //    int minNum = Convert.ToInt32(Console.ReadLine());
            //    int sum = 0;
            //    for (int i = minNum; i <= maxNum; i++)
            //    {
            //        if (i % 2 != 0)
            //        {
            //            sum += i;
            //        }
            //    }
            //    Console.WriteLine(minNum+"之间"+maxNum+"所有的奇数之和" + sum);
            //    goto Attribute;








            //14. 猜数字游戏.  随机产生1个1-100之间的数 让用户猜  当用户输入的数比产生的随机数大 就输出 猜小了。当用户输入的数比产生的随机数小的时候 就输出 猜大了。。。当用户刚好输入的就是这个随机数的时候 提示成功  并显示用户猜了多少次.
            //   a.  产生1个随机数.
            //   b.  反复的让用户去猜这个数.


            //Console.WriteLine("请输入最大整数");
            //int maxNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入最小整数");
            //int minNum = Convert.ToInt32(Console.ReadLine());
            //int sum = 1;
            //Random r = new Random();
            //int newNum = r.Next(minNum, maxNum + 1);
            //int userNum = 0;
            //bool boom = true;
            //do
            //{
            //    Console.WriteLine("请输入你的整数(请在最大整数~最小整数之内)");
            //    userNum = Convert.ToInt32(Console.ReadLine());
            //    if (userNum > newNum)
            //    {
            //        Console.WriteLine("用户输入的数比产生的随机数大");
            //        sum++;
            //        boom = true;
            //    }
            //    else if (userNum < newNum)
            //    {
            //        Console.WriteLine("用户输入的数比产生的随机数小");
            //        sum++;
            //        boom = true;

            //    }
            //    else
            //    {
            //        Console.WriteLine("猜对了，但没奖励！而且你猜了" + sum + "次");
            //        boom = false;
            //    }

            //} while (boom);
            //Console.ReadKey();








            //15. 编一个程序，输入用户名和密码，实现用户登录程序的功能，至多允许输入三次，超过三次不允许登录就退出程序.

            //            Console.WriteLine("允许尝试次数");
            //            int maxNum = Convert.ToInt32(Console.ReadLine());
            //            int sum = maxNum;
            //            bool boom = true;
            //            bool boom2 = true;
            //            string password = "";

            //            string userName;
            //            do
            //            {
            //                Console.WriteLine("请输入用户名");
            //                userName = Console.ReadLine();

            //                if (userName == "admin")
            //                {
            //                    do
            //                    {
            //                        Console.WriteLine("请输入密码");
            //                        password = Console.ReadLine();
            //                        if (password == "888888")
            //                        {
            //                            Console.WriteLine("输入正确");
            //                            boom = false;
            //                            boom2 = false;
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("密码错误,请重新输入");
            //                            boom2 = true;
            //                            sum -= 1;
            //                            Console.WriteLine("允许尝试次数"+sum);
            //                            if (sum<=0)
            //                            {
            //                                return;
            //                            }
            //                        }
            //                    } while (boom2);

            //                }
            //                else
            //                {
            //                    Console.WriteLine("用户名错误，请重新输入");
            //                    boom = true;
            //                    sum -= 1;
            //                    Console.WriteLine("允许尝试次数" + sum);
            //                    if (sum <= 0)
            //                    {
            //                        return;
            //                    }
            //                }
            //            } while (boom || boom2);

            //            Console.ReadKey();




        }
    }
}
