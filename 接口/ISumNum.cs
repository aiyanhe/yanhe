using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    class ISumNum : IMax//要实现IMax接口和其父类IBankATM接口的所有抽象方法
    {
        void IBankATM.ChangeMoney()
        {
            throw new NotImplementedException();
        }

        void IMax.GetMax()
        {
            throw new NotImplementedException();
        }

        void IBankATM.GetMoney()
        {
            throw new NotImplementedException();
        }

        void IBankATM.SaveMoney()
        {
            throw new NotImplementedException();
        }
    }
}
