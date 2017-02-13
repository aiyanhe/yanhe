using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010____虚方法
{
    class Person
    {
        private string name;
        private int age;
        private bool isGril = false;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public bool IsGril
        {
            get
            {
                return isGril;
            }

            set
            {
                isGril = value;
            }
        }

        public virtual void Move()//加上virtual后，让该方法变成虚方法；要成功使用，还要与子类对应；
        {
            Console.WriteLine("Person的Move");
        }
        public void AI()
        {

            Console.WriteLine("Person的AI");
        }
    }
}
