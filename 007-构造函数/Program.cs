using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _007_构造函数
{
    public  class Program
    {
        static void Main(string[] args)
        {
            //声明的时候直接赋值！！
            Vector3 vec = new Vector3(10,20,30);
            Console.WriteLine(vec.length);
            Console.ReadKey();
        }
    }
}
