using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012____虚假方法
{
    class yanhe:person
    {
        public new void Move()
            //当子类里面有一个签名和父类相同的方法的时候，就会把父类中的方法隐藏；
            //隐藏：只是把父类中的方法隐藏了，看不到了，实际这个方法还存在；
        {
            Console.WriteLine("这里是yanhe的Move");
        }
    }
}
