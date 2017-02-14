using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象编程__继承
{
    class Boss : Enemy//Enemy是父类，Boss继承Enemy的所有数据,是子类;
    {
        private string bossname = "";
        public string Bossname
        {
            get
            {
                return bossname;
            }
            set {
           bossname = value;
           }
        }
    }
}
