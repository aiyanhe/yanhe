using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    class IcbcATM : IBankATM,ITest//实现接口，实现接口里面的方法，不需要加override关键字；
        //类可以实现多个接口；
    {

        void IBankATM.ChangeMoney()//显式实现接口，可以清楚的看出实现对应接口的对应抽象方法；//调用显式实现接口，要通过接口来调用
        {
            throw new NotImplementedException();
        }

        void IBankATM.GetMoney()
        {
            throw new NotImplementedException();
        }

        void ITest.GetMoney()
        {
            throw new NotImplementedException();
        }

        void IBankATM.SaveMoney()
        {
            throw new NotImplementedException();
        }
    }
}
