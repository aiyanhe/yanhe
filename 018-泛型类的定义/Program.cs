using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_泛型类的定义
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var fan = new Fanxing<int>(100,20);//当我们利用泛型类构造时，需要指定泛型类的类型
            Console.WriteLine(fan.Sum());
            Console.ReadKey();
        }
    }
}

