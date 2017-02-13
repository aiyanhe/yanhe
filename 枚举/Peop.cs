using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举
{
    //枚举（如果要限定一个取值范围）
    enum EDictation {
        up=10,//默认为0
        down,//11
        left,//12
        right//13
    }
    class Peop
    {
        //类里面可以写什么？变量 方法 枚举
        public EDictation ed = EDictation.up;
        string theDd = "left";

        public void ShowDir()
        {
            int index = (int)ed;
            Console.WriteLine(index);
            //把字符串转换为枚举类型
            EDictation result =(EDictation)Enum.Parse(typeof(EDictation),theDd,true);
                                                    //typeof(x) 返回 ：x类型
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
