using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_从键盘上读取输入的字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string name="";
            string age="";
            string height = "";
            string Name = "请输入姓名";
            string Age = "请输入年龄";
            string Height = "请输入身高";


            Console.WriteLine(Name+":"+name);
            Console.WriteLine(Age+":"+age);
            Console.WriteLine(Height+":"+height);
            name=Console.ReadLine();//用来接收用户输入的一行文本，也叫一行字符串，按下换行（回车）的时候结束；
            age = Console.ReadLine();
            height = Console.ReadLine();
            Console.WriteLine("姓名"+ ":" + name);
            Console.WriteLine("年龄" + ":" + age);
            Console.WriteLine("身高" + ":" + height);
            int age1 = Convert.ToInt32(age)+10;//这个方法可以把一个整数的字符串转化成整数;
            double height1 = Convert.ToDouble(height) + 15;//这个方法可以把用户输入的小数的字符串转化成double浮点类型;
            //float f = Convert.ToFloat("32,34");注意，float转换是没有ToFloat的，应该用ToSingle;
            float f = Convert.ToSingle("32,34");//把一个float浮点类型的字符串转成一个float浮点字符;
            Console.WriteLine("10年后的年龄" + ":" + age1);
            Console.WriteLine("10年后的身高" + ":" + height1);
            Console.ReadKey();
        }
    }
}
