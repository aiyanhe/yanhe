using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 构造函数
{
    class fruit
    {
        //编译的时候，是不会给变量赋值，运行的时候才赋值
        public string name = "桃子";
        public string height = "1.5";
        public string color = "粉色";
        public int weitht = 100;

        //编译的时候，如果类里面没有写构造函数，那么编译器会自动添加一个无参的构造函数；
        public void GetFruit()
        {
            Console.WriteLine("只是一个{0}的{1}，有{2}斤重",color,name,height);

        }
        public fruit(int weitht)//运行的时候先运行构造函数，就开始给变量赋值了；
        {
            this.weitht = weitht;
            Console.WriteLine("有{0}斤重",weitht);
        }
    }
}
