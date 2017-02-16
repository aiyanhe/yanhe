using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_创建我们自己的列表MyList
{
    class MyList<T>
    {
        
        private static T[] array;//建立一个T类型的数组
        private int count=0;
        public MyList()//判断声明MyList<>(index)的index有参和无参情况；
        {
            array=new T[0];
        }
        public MyList(int name)
        {
            if (name >= 0)
            {
                array = new T[name];
            }
            else {
                array = new T[0];
            }
        }
        public int Capacity
        {
           get { return array.Length; } 
        }
        public int Count
        {
            get { return count;  }
        }





    }
}
