using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_LINQ查询
{
    class StudeGanden
    {
        public string name { get; set; }
        public int age { get; set; }
        public string Class { get; set; }
        public float yuwen { get; set; }
        public float math { get; set; }

        public float english { get; set; }
        public override string ToString()
        {
            return string.Format("name:{0} age:{1} Class:{2}yuwen:{3}math:{4}english:{5}",name,age,Class,yuwen,math,english);
        }
    }
}
