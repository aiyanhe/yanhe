using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010____虚方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Woman yanhe = new Woman();
            yanhe.AI();
            yanhe.Move();
            if (yanhe.IsGril)
            {
                Console.WriteLine("言和是可爱的女孩子");
            }
            else
            {
                Console.WriteLine("言和是帅气的男孩子");    
            }
            Console.ReadKey();
        }
    }
}
