using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012____虚假方法
{
    class person
    {
        private bool isGril{get;set;}
        private string name { get; set; }
        private float tall { get; set; }

        public void Move()
        {
            Console.WriteLine("这里是person的Move");
        }
        public void Do()
        {
            Console.WriteLine("这里是person的Do");
        }
    }
}
