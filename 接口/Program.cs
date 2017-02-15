using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    class Program
    {
        static void Main(string[] args)
        {
            IBankATM bank = new IcbcATM();
            bank.ChangeMoney();//调用显式实现接口，要通过接口来调用

            IcbcATM bank2 = new IcbcATM();
            


        }
    }
}
