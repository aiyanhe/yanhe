using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 10;//0~255;
            int myInt = 6000;
            long myLong = 1000000000;
            float myFloat = 12.5f;
            double myDouble = 33.4;
            char myChar = 'a';//储存单字符，用单引号'';
            string myString = "a";
            string myString2 = "";
            bool myBool = false;
            Console.WriteLine("byte={0},int={1},long={2},float={3},double={4}", myByte,myInt,myLong,myFloat,myDouble);
            Console.WriteLine("char={0},string={1},string2={2},bool={3}", myChar, myString, myString2, myBool);
            Console.ReadKey();

        }
    }
}
