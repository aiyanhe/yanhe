using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_类的定义和声明
{
    class Program
    {
        static void Main(string[] args)
        {
            Vectors3 vec1 = new Vectors3();
            vec1.SetX(55);
            vec1.SetY(22);
            vec1.SetZ(33);
            Console.WriteLine(vec1.Length());
            Console.ReadKey();
        }
    }
}
