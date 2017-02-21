using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 冒泡排序的扩展
{
    class Employee
    {
        private string name{get;set;}
        private float Salary { get; set; }
        public Employee(string name,float Salary)
        {
            this.name = name;
            this.Salary = Salary;
        }
        public static bool Compare(Employee e1,Employee e2)
        {
            if (e1.Salary>e2.Salary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string Get(Employee e)
        {
            return e.name + ":" + e.Salary;
        }
    }
}
