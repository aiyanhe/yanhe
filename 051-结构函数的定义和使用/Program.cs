using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _051_结构函数的定义和使用
{
    class Program
    {
        struct Vector3        {
            public float x;
            public float y;
            public float z;
            public double distance () 
            {
                return Math.Sqrt(x*x+y*y+z*z);
            }      
        }
        static void Main(string[] args)
        {
            Vector3 distance;
            distance.x = 50;
            distance.y = 40;
            distance.z = 30;
            Console.WriteLine(distance.distance());
            Console.ReadKey();
        }
    }
}
