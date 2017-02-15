using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TroubleTest2
{
    struct Student
    {
        public int age;
        public string name;
        public Student(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student(18, "小方");
            Student stu2 = new Student(24, "小刚");
            stu2 = stu1;//并没有把stu2的地址换为stu1;只是把18和小方的值传递了过去；
            //在c#中 结构体是值类型，在这里赋值只会赋值其中变量的值
            stu1.age = 30;
            stu1.name = "小燕";
            Console.WriteLine(stu2.age);
            Console.WriteLine(stu2.name);
            Console.ReadKey();
        }
    }
}

