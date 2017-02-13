using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_属性get_set
{
    class Customer
    {
        private string name, buyName;
        private float cost, age;
        public string Name//属性--让私自属性的字段可以被读写，get为读，set为写;
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
        public float Cost
        {
            get
            {
                return cost;
            }
            private set    //让属性不可被赋值；
            {
                //通过set方法 在设置值之前做一些校验的工作 属性的好处之一；
                if (value>=0)
                {
                    cost = value;
                }
                
            }
        }
        public float Age
        {
            set//让年龄只写；
            {
                age =value;
            }
        }
        public string BuyName
        {
            get//让物品名字只读；
            {
                return buyName;
            }
        }
        public string YanHe { get; set; }//编译器会自动给我们提供一个字段，来存储值；//属性的快速读写；
    }
}
