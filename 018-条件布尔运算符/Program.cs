using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_条件布尔运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            bool var = true;
            bool var1 = false;
            bool var2 = var & var1;//如果var和var1都是true,var1的值就是true,否则为false(逻辑与);
            bool var3 = var | var1;//如果var或var1是ture(或两者都是)，var3的值就是true,否则为false(逻辑或);
            bool var4 = var ^ var1;//如果var 或var1中有且仅有一个是true,var4的值就是true,否则为false(逻辑异或);
            bool var5 = !var;//如果var是false,var5的值就是true,否则为false（逻辑非）;
            bool var6 = var && var1;//如果var和var1都是true,var6的值就是true,否则为false(逻辑与);
            bool var7 = var || var1;//如果var或var1是true(或两者都是),var7的值就是true,否则为false(逻辑或);
            Console.WriteLine(var2);
            Console.WriteLine(var3);
            Console.WriteLine(var4);
            Console.WriteLine(var5);
            Console.WriteLine(var6);
            Console.WriteLine(var7);
            Console.ReadKey();

        }
    }
}
