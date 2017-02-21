using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaoPao
{
    class Class
    {
        private string name{get;set;}
        private float sore { get; set; }

        public Class(string name ,float sore)
        {
            this.name = name;
            this.sore = sore;
        }
        public static bool GetClass(Class c1,Class c2)
        {
            if (c1.sore>c2.sore)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string OO()
        {
            return name + ":" + sore;
        }
    }
}
