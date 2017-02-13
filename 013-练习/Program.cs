using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_练习
{
    class Program
    {
        static void Main(string[] args)
        {
            string diRenName = "";
            int diRenLevel;
            float diRenHp;
            float diRenKonjili;
            Console.WriteLine("自定义敌人的名字");
            diRenName = Console.ReadLine();
            Console.WriteLine("自定义敌人的等级");
            diRenLevel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("自定义敌人的血量");
            diRenHp = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("自定义敌人的攻击力");
            diRenKonjili = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("敌人名字:" + diRenName);
            Console.WriteLine("敌人等级:" + diRenLevel);
            Console.WriteLine("敌人血量:" + diRenHp);
            Console.WriteLine("敌人攻击力:" + diRenKonjili);
            Console.WriteLine("自定义敌人的四段击效果");
            Console.WriteLine("第一击攻击力乘积");
            float diYi = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("第二击攻击乘积");
            float diEr = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("第三击攻击力乘积");
            float diSan = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("第四击攻击力乘积");
            float diSe = Convert.ToSingle(Console.ReadLine());
            float zongShuChu = diRenKonjili * (diYi + diEr + diSan + diSe);
            Console.WriteLine("总输出量:"+zongShuChu);


            Console.WriteLine("计算梯形面积");
            Console.WriteLine("梯形的上底");
            float sanDi = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("梯形的下底");
            float xiaoDi = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("梯形的高");
            float height = Convert.ToSingle(Console.ReadLine());
            float mianJi = (sanDi+xiaoDi)*height/2;
            Console.WriteLine("梯形的面积:" + mianJi);

            Console.WriteLine("计算圆的面积");
            Console.WriteLine("圆的半径");
            float banJing = Convert.ToSingle(Console.ReadLine());
            float zhouChang = Convert.ToSingle(banJing * 2 * 3.14);
            float yuanMianJi = Convert.ToSingle(banJing*banJing*3.14);
            Console.WriteLine("圆的周长:"+zhouChang);
            Console.WriteLine("圆的面积:"+yuanMianJi);


            Console.WriteLine("请输入一个三位数的数字");
            int shuZi=Convert.ToInt32(Console.ReadLine());
            int geWei = shuZi % 10;//一个数字跟10求余得到是这个数字的个分位；
            int shiWei = (shuZi/10)%10;//一个数字跟10相除的话，相当于去掉这个数字的个分位(xyz/10=xy)
            int baiWei = shuZi / 100;
            int daoShu = geWei*100 + shiWei * 10 + baiWei;
            Console.WriteLine(daoShu);
            Console.ReadKey();
        }
    }
}
