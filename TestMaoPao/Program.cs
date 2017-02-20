using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaoPao
{
    class Program
    {
        public static void GetArray<T>(T[] aa, Func<T, T, bool> sasa)
        {
            bool boom = true;
            do
            {
                boom = false;
                for (int i = 0; i < aa.Length - 1; i++)
                {
                    if (sasa(aa[i], aa[i + 1]))
                    {
                        T temp = aa[i];
                        aa[i] = aa[i + 1];
                        aa[i + 1] = temp;
                        boom = true;
                    }
                }

            } while (boom);


        }
        static void Main(string[] args)
        {
            Class[] kkk = new Class[]
            {
            new Class("sas",524752),
            new Class("sd",21123),
            new Class("fsdf",213),
            new Class("gsd",45630),
            new Class("wr",123546),
            new Class("fg",52452)
            };
            GetArray<Class>(kkk, Class.GetClass);
            Over(kkk);
            Console.ReadKey();

        }
        public static void Over(Class[] ds)
        {
            foreach (var item in ds)
            {
                Console.WriteLine(item.OO());
            }
        }
    }
}
