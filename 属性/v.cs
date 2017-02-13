using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 属性
{
    class V
    {
        private int age;
        private float tall{get;set;}
        private string name { get; set; }//自动属性

        public int Age//属性：作用：用来保护字段；
        {
            get//获取
            {
                if (age>100)
                {
                    return 50;
                }
                else
                {
                    return age;
                }
               
            }

            set//设置
            {
                if (value>120)
                {
                    Console.WriteLine("成精了？");
                }
                else if(value<0)
                {
                    Console.WriteLine("你脑子抽了？");
                }
                else
                {
                    age = value;
                }
            }
        }





    }
}
