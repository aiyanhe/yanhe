using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    interface IBankATM//接口(是一个特殊的抽象类)
                       //实现一个接口就必须实现接口里面的所有的抽象方法
                       //实现接口里面的方法，不需要加override关键字
                       //作用？是一个行为规范
    {
        void GetMoney();//抽象方法
        void SaveMoney();
        void ChangeMoney();
    }
}
