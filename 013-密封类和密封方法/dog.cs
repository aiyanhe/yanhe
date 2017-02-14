using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_密封类和密封方法
{
    //class dog:Animal  无法从密封的类中继承
    class dog:Cat
    {
        public sealed override void Move()//我们可以把重写的方法声明为密封方法，表示该方法不能被再次重写；
        {
            Console.WriteLine("这里是dog的Move");
        }
    }
}
