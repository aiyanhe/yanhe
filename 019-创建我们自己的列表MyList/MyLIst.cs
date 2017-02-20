using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_创建我们自己的列表MyList
{
    class MyList<T>where T:IComparable//一个比较的接口
    {
        
        private static T[] array;//建立一个T类型的数组
        private int count=0;
        private T temp;
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
        public int Capacity//随数组大小而变化
        {
           get { return array.Length; } 
        }
        public int Count
        {
            get { return count;  }
        }
        public void Add(T item)//添加Add方法
        {
            if (Capacity==Count)//当列表满了
            {
                if (Capacity ==0)//当列表容量为0时
                {
                    array = new T[4];//数组扩容
                }
                else
                {
                    T[] newArray = new T[Capacity * 2];//其他情况下新建一个数组，容量为旧的2倍
                    Array.Copy(array,newArray,Count);//把旧的东西放到新的数组
                    array = newArray;//新的替掉旧的
                }
            }
            array[Count] = item;//数组加新的元素
            count++;//计数加一；
        }
        public T this[int index]
        {
            get { return array[index]; }
            set
            {
                if (index >= 0 && index < count)
                {
                    array[index] = value;
                }
                else
                {
                    throw new Exception("索引超出范围");
                }
            }
        }//添加访问元素[索引器]
        public void Insert(int index,T temp)
        {
            if (index>=0&&index<Capacity)//判断索引值是否正确
            {
                if (count == Capacity)//容量不够，扩容
                {
                    if (Capacity == 0)
                    {
                        array = new T[4];
                    }
                    else
                    {
                        T[] newArray = new T[Capacity * 2];//其他情况下新建一个数组，容量为旧的2倍
                        Array.Copy(array, newArray, Count);//把旧的东西放到新的数组
                        array = newArray;//新的替掉旧的
                    }
                    count++;
                }
                for (int i = count - 1; i >= index; i--)//从后往前挪
                {
                    array[i + 1] = array[i];
                }
                array[index] = temp;
            }
            else
            {
                throw new Exception("索引超出范围");
            }
          
        }//添加Index插入元素
        public void RemoveAt(int index)
        {
            if (index>=0&&index<count)
            {
                for (int i = index; i <= count; i++)//前一个替换后一个
                {
                    array[i] = array[i + 1];
                }
            }
            else
            {
                throw new Exception("索引超出范围");  
            }
        
        }//添加RemoveAt移除指定元素
        public int IndexOf(T temp)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(temp))
                {
                    return i;
                }
                
            }
            return -1;   
            }//从前往后查找指定元素的索引
        public int LastIndexOf(T temp)
        {
            for (int i = count-1; i <0; i--)
            {
                if (array[i].Equals(temp))
                {
                    return i;
                }

            }
            return -1;
        }//从后往前查找指定元素的索引
        public void Sort()//添加Sort自动排序  内部采用冒泡排序
        {
            for (int i = 0; i < count-1; i++)
            {
                for (int j = i; j < count-1; j++)
                {
                    if (array[i].CompareTo(array[i+1])>0)
                    {
                        temp =array[i + 1];
                        array[i+1]= array[i];
                        array[i] = temp;
                    }
                }
            }
        }
    }
}
