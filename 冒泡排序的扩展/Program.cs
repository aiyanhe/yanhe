using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 冒泡排序的扩展
{
    class Program
    {
        public static void Employee1<T>(T[] sortArray,Func<T,T,bool> compareMeth)//一个泛型方法，接受T数组和用一个委托接受处理T数组方法
        {
            bool swapped = true;
            
            do
            {
                swapped = false;
                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if (compareMeth(sortArray[i], sortArray[i + 1]))//用委托的方法检测
                    {
                        T temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        
        }

        static void Main(string[] args)
        {
            Employee[] ememd = new Employee[]//T数组
            {
            new Employee("sasa",10000),
            new Employee("tianyi",5000),
            new Employee("Yanhe",50000),
            new Employee("Yanhe",53000),
            new Employee("Yanhe",25000),
            new Employee("Yanhe",8700),
            new Employee("Yanhe",8000)
            };
            Employee1<Employee>(ememd,Employee.Compare);
            GetEnd(ememd);
            Console.ReadKey();
        }
        public static void GetEnd(Employee[] e)
        {
            foreach (var item in e)
            {
                Console.WriteLine(item.Get(item));
            }
        }
    }
}
