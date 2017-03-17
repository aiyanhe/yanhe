using ConsoleApplication7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _010__反射和特性
{
    class Program
    {
        static void Main(string[] args)
        {
            //每一个类对应一个type对象，这个type对象存储了这个类有那些方法跟哪些数据 哪些成员
            MyClass my = new MyClass();//一个类中的数据是存储在对象中的，但是type对象只存储类的成员
            Type type = my.GetType();//通过对象获取这个对象所属类的Type对象
            Console.WriteLine(type.Name);//获取类的名字
            Console.WriteLine(type.Namespace);//获取所在的命名空间
            Console.WriteLine(type.Assembly);//获取所在的程序集
            FieldInfo[] array = type.GetFields();//只能获取public字段
            foreach (FieldInfo info in array)
            {
                Console.Write(info.Name + "");
            }
            PropertyInfo[] array2 = type.GetProperties();
            foreach (PropertyInfo info in array2)
            {
                Console.Write(info.Name + "");
            }
            Console.WriteLine("*************************");
            Assembly assem = my.GetType().Assembly;//通过类的type对象获取它所在的程序集Assembly
            Console.WriteLine(assem.FullName+ " ******assem.FullName");//程序集的全名
            Type[] types = assem.GetTypes();//获取程序集的所有类
            foreach (var type2 in types)
            {
                Console.WriteLine(type2+"*********");
            }
            Console.ReadKey();
        }
    }
}
