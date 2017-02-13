using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //1：找出100到999之间的水仙花数；“153=1*1*1+5*5*5+3*3*3”
            //string str = "";
            //string str1 = "";
            //int sum = 0;
            //int num = 0;
            //int length = 0;
            //for (int i = 100; i <= 999; i++)
            //{
            //    str = Convert.ToString(i);
            //    length =str.Length;
            //    for (int t = 0; t < length; t++)
            //    {
            //     str1=Convert.ToString(str[t]);
            //     num =Convert.ToInt32(str1);
            //     sum+= num * num * num;
            //    }
            //    if (sum==i)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    sum = 0;
            //}
            //Console.ReadKey();





            //2：3个可乐瓶可以换一瓶可乐，现在有364瓶可乐，问一共可以喝多少瓶可乐，剩下几个空瓶！

            //Console.WriteLine("请输入现有可乐数");
            //int num=Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <= num; i++)
            //{
            //    sum++;
            //    if (sum==3)
            //    {
            //        num++;
            //        sum = 0;
            //    }

            //}
            //Console.WriteLine("可以喝{0}瓶可乐",num);
            //Console.WriteLine(sum);
            //Console.ReadKey();






            //3：猜数字游戏，我有一个数，请你猜猜是多少？
            //请你输入一个0-50之间的数：20（用户输入数字）
            //您猜小了，这个数字比20大：30
            //您猜大了，这个数字比30小：25
            //恭喜您猜对了，这个数字为：25            

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





            //4：编写一个应用程序用来对输入的字符串进行加密，对于字母字符串加密规则如下：
            //‘a’→‘d’,‘b’→‘e’,‘w’→‘z’........‘x’→‘a’,‘y’→‘b’,‘z’→‘c’,‘A’→‘D’,‘B’→‘E’,‘W’→‘Z’.........‘X’→‘A’‘Y’→‘B’‘Z’→‘C’对于其他字符，不进行加密。
            //Console.WriteLine("请输入密码，进行加密程序");
            //string str = Console.ReadLine();
            //string newStr = "";
            //int length = str.Length;
            //int num = 0;
            //bool boom = true;
            //while (boom)
            //{
            //    for (int i = 0; i < length; i++)
            //    {
            //        num = str[i];
            //        if ((num >= 'a' && num <= 'z') || (num >= 'A' && num <= 'Z'))
            //        {
            //            boom = false;
            //            if ((num >= 'a' && num <= 'w') || (num >= 'A' && num <= 'w'))
            //            {
            //                newStr += (char)(num + 3);
            //            }
            //            else
            //            {
            //                newStr += (char)(num - 23);
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("非法字符，请重新输入密码");
            //            str = Console.ReadLine();
            //            boom = true;
            //        }
            //    }

            //}
            //Console.WriteLine("加密后的数据为" + newStr);
            //Console.ReadKey();


            //5：编写一个控制台程序，要求用户输入一组数字，对用户输入的数字从小到大输出；
            //冒泡排序法如下;
            //Console.WriteLine("请输入一组数字,用逗号隔开");
            //string str = Console.ReadLine();
            //string[] strArray = str.Split(',');
            //string str1 = "";
            //float num1 = 0;
            //float num = 0;
            //bool boom = true;
            //int length = strArray.Length;
            //float[] floatArray = new float[length];
            //string[] newStrArray = new string[length];
            ////for (int i = 0; i < length; i++)
            ////{
            ////    num =Convert.ToSingle(strArray[i]);
            ////    floatArray[i] = num;
            ////}
            ////Array.Sort(floatArray);//使用CLR给我们提供的方法进行排序（这个方法其实使用了快速排序算法）
            ////for (int i = 0; i < length; i++)
            ////{
            ////    Console.Write(floatArray[i] + " ");
            ////}
            //while (boom)
            //{
            //    for (int i = 0; i < length - 1; i++)
            //    {
            //        num = Convert.ToSingle(strArray[i]);
            //        num1 = Convert.ToSingle(strArray[i + 1]);
            //        if (num > num1)
            //        {
            //            str1 = strArray[i];
            //            strArray[i] = strArray[i + 1];
            //            strArray[i + 1] = str1;
            //        }
            //    }
            //    if (length == 0)
            //    {
            //        boom = false;
            //    }
            //    length--;
            //}
            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    Console.Write(strArray[i] + " ");
            //}

            //Console.ReadKey();



            //6：第一天悟空吃掉桃子总数一半多一个，第二天又将剩下的桃子吃掉一半多一个，以后每天吃掉前一天剩下的一半多一个。到第n天准备吃的时候只剩下一个桃子，请问初始桃子有几个？
            //用户输入n的值，计算出来他第一天吃的时候桃子是多少个？

            //Console.WriteLine("请输入猴子吃了几天");
            //int dayNum = Convert.ToInt32(Console.ReadLine());
            //int sum = 1;
            //for (int i = 1; i <= dayNum; i++)
            //{
            //    sum = 2 * (sum + 1);
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();


            //7：输入n（n<100）个数，找出其中最小的数，将它与最前面的数交换后的输出这些数；
            //Console.WriteLine("输入n（n<100）个数,用逗号隔开");
            //string str = Console.ReadLine();
            //string[] strArray = str.Split(',');
            //string str1 = "";
            //string str2 = "";
            //float num1 = 0;
            //float num = 0;

            //int index = 0;
            //bool boom = true;
            //int length = strArray.Length;
            //float[] floatArray = new float[length];
            //string[] newStrArray = new string[length];
            //while (boom)
            //{
            //    for (int i = 0; i < length - 1; i++)
            //    {
            //        num = Convert.ToSingle(strArray[i]);
            //        num1 = Convert.ToSingle(strArray[i + 1]);
            //        if (num > num1)
            //        {
            //            index = i+1;
            //            str1 = strArray[i+1];//把小的数塞进str1;
            //        }
            //    }
            //    if (length == 0)
            //    {
            //        boom = false;
            //    }
            //    length--;
            //}
            //str2=strArray[0];
            //strArray[0]=strArray[index];
            //strArray[index] = str2;
            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    Console.Write(strArray[i] + " ");
            //}

            //Console.ReadKey();






            //8：有n（n<=100）个整数，已经按照从小到大顺序排列好，现在另外给一个整数x，请将该数插入到序列中，并使新的序列仍然有序。输出新的序列
            //Console.WriteLine("请输入一组整数(用逗号隔开)");
            //string str = Console.ReadLine();
            //Console.WriteLine("请输入要插入的整数");
            //float num = Convert.ToSingle(Console.ReadLine());
            //string[] strArray = str.Split(',');
            //float[] numArray = new float[strArray.Length+1];
            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    numArray[i]=Convert.ToSingle(strArray[i]);
            //}
            //numArray[numArray.Length-1] = num;
            //Array.Sort(numArray);

            //for (int i = 0; i < strArray.Length+1; i++)
            //{
            //    Console.Write(numArray[i]);    
            //}
            //Console.ReadKey();






            //9：如果每个老师的工资额度都知道，最少需要准备多少张人民币，才能在给每位老师发工资的时候不用老师找零呢？
            //这里加上老师的工资都是正整数，单位元，人民币一共有100元，50元，10元，5元，2元和1元六种；
            //Console.WriteLine("请问有几个老师");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int bai = 0;
            //int wuShi = 0;
            //int shi = 0;
            //int wu = 0;
            //int er = 0;
            //int yi = 0;
            //for (int i = 1; i <= num; i++)
            //{
            //    Console.WriteLine("请输入第{0}个老师的工资", i);
            //    int momey = Convert.ToInt32(Console.ReadLine());
            //    bai += momey / 100;
            //    if ((momey / 10) % 10 >= 5)
            //    {
            //        wuShi += 1;
            //        shi += (momey / 10) % 10 - 5;
            //    }
            //    else
            //    {
            //        shi += (momey / 10) % 10;
            //    }
            //    if (momey % 10 >= 5)
            //    {
            //        wu += 1;
            //        er += (momey % 10 - 5) / 2;
            //        yi += (momey % 10 - 5) % 2;
            //    }
            //    else
            //    {
            //        er += (momey % 10) / 2;
            //        yi += (momey % 10) % 2;
            //    }
            //}
            //Console.WriteLine("要准备{0}张一百元，{1}张五十，{2}张十块，{3}张五块，{4}张两块，{5}张一块",bai,wuShi,shi,wu,er,yi);
            //Console.ReadKey();










            //10：输入一个字符串，判断其是否是C#的合法标识符；
            //Console.WriteLine("请输入一个字符串，判断其是否是C#的合法标识符");
            //string str = Console.ReadLine();
            //int length = str.Length;
            //bool boom = false;
            //if (str[0]=='_'||(str[0]>='a'&&str[0]<='z')||(str[0]>='A'&&str[0]<='Z'))
            //{
            //    for (int i = 1; i < length; i++)
            //    {
            //        if (str[i] == '_' || (str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= '0' && str[i] <= '9'))
            //        {
            //            boom = true;
            //        }
            //        else
            //        {
            //            Console.WriteLine("输入的字符{0}为非法字符", str);
            //            boom = false;
            //            break;
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("首字母为非法字符");
            //}
            //if (boom==true)
            //{
            //  Console.WriteLine("输入的字符{0}为合法字符",str);
            //}
            //Console.ReadKey();








            //11：“回文串”是一个正读和反读都一样的字符串，比如“level”或者“noon”等等就是回文串，请写一个程序判断读入的字符串是否是“回文串”；
            //Console.WriteLine("请输入一个字符串");
            //string  str = Console.ReadLine();
            //int length = str.Length;
            //for (int i = 0; i < length/2+1; i++)
            //{
            //    if (str[i]!=str[length-i-1])
            //    {
            //        Console.WriteLine("该字符串不是回文串");
            //        Console.ReadKey();
            //        return;
            //    }
            //}
            //Console.WriteLine("该字符串是回文串");
            //Console.ReadKey();


            //12：设置密码：要求：（1）：密码长度大于等于8，且不要超过16；（2）。密码中的字符应该来自下面“字符类别”中四组中的 至少三组。
            //这四个字符类别分别为：1：大写字母：A,B,C.......Z;2:小写字母：a,b,c.......z;3:数字：0，1，2，3.......9；4：特殊符号：~，！，@，#，￥，%，^:
            //给你一个密码，你的任务就是判断它是不是一个安全的密码。

            //Console.WriteLine("请输入一个密码");
            //string str = Console.ReadLine();
            //bool bool1 = false;
            //bool bool2 = false;
            //bool bool3 = false;
            //bool bool4 = false;
            //if (str.Length >= 8 && str.Length < 16)
            //{
            //    for (int i = 0; i < str.Length; i++)
            //    {
            //        if (str[i] >= 'a' && str[i] <= 'z')
            //        {
            //            bool1 = true;
            //        }
            //        else if (str[i] >= 'A' && str[i] <= 'Z')
            //        {
            //            bool2 = true;
            //        }
            //        else if (str[i] >= '0' && str[i] <= '9')
            //        {
            //            bool3 = true;
            //        }
            //        else if (str[i] == '~' || str[i] == '!' || str[i] == '@' || str[i] == '#' || str[i] == '￥' || str[i] == '%' || str[i] == '^')
            //        {
            //            bool4 = true;
            //        }
            //        else
            //        {
            //            Console.WriteLine("第{0}个字符为非法字符", i);
            //        }
            //    }
            //    //if ((bool1 && bool2 && bool3) || (bool1 && bool2 && bool4) || (bool1 && bool4 && bool3) || (bool2 && bool3 && bool4))
            //    //{
            //    //    Console.WriteLine("该密码是安全密码");
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine("该密码不安全");
            //    //}
            //    int num = 0;
            //    if (bool1)
            //    {
            //        num++;
            //    }
            //    if (bool2)
            //    {
            //        num++;
            //    }
            //    if (bool3)
            //    {
            //        num++;
            //    }
            //    if (bool4)
            //    {
            //        num++;
            //    }
            //    if (num>=3)
            //    {
            //        Console.WriteLine("该密码是安全密码");
            //    }
            //    else
            //    {
            //        Console.WriteLine("该密码不安全");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("不符合密码要求");
            //}
            //Console.ReadKey();


            //13：龟兔赛跑，兔子能以恒速(VR m/s)一直跑，跑道长度L米，乌龟有电动车，能以VT1 m/s的速度行驶，一次最多行驶C米距离，之后只能以VT2 m/s的速度行驶，路上有N个充电站，每次充电花费T秒。当然，乌龟可以选择充不充电。
            //判断乌龟用最佳方案进军时，能不能赢兔子；
            //输入：本题目包含多组测试，请处理到文件结束。每个测试包括四行：
            //第一行是一个整数L代表跑道的总长度；
            //第二行包含三个整数N,C,T，分别表示充电站的个数，电动车充满电以后能行驶的距离以及每次充电所需要的时间
            //第三行也三个整数VR,VT1，VT2，分别表示兔子跑步的速度，乌龟开电动车的速度，乌龟脚蹬电动车的速度
            //第四行包含了N(N<=100)个整数p1,p2,....pn,分别表示各个充电站离跑道起点的距离，其中0<p1<p2<.....其中每个数都在32位整型范围之内。
            //输出：当乌龟有可能赢的时候输出一行“What a pity rabbit!”。否则输出一行"Good job ,rabbit!";（保证不会出现乌龟和兔子同时到达的情况）

            //Console.WriteLine("请输入跑道总长度(m)");
            //float runRoad = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("请输入充电站的个数");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入电动车充满电以后能行驶的距离(m)");
            //float runLength = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("每次充电所需要的时间(秒)");
            //int miao = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入兔子跑步的速度(m/s)");
            //float ridditSpeed = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("请输入乌龟开电动车的速度(m/s)");
            //float carSpeed = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("请输入乌龟脚蹬电动车的速度(m/s)");
            //float runSpeed = Convert.ToSingle(Console.ReadLine());
            //int wuTime = 0;
            //int[] length = new int[num];
            //for (int i = 0; i <= num; i++)
            //{
            //    Console.WriteLine("请输入第{0}个充电站离跑道起点的距离",i);
            //    length[i]=Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 1; i <=num; i++)
            //{

            //}
            //if (length[i]-length[i-1])
            //{

            //}








        }
    }
}
