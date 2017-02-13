using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_属性get_set
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cus1 = new Customer();
            cus1.Age = 12;
            string str1 = cus1.BuyName;
            cus1.YanHe = "爱言和";
            Console.WriteLine(cus1.YanHe);
            Console.ReadKey();
        }
    }
}
