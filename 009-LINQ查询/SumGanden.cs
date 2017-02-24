using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_LINQ查询
{
    class SumGanden
    {
        public int Sumyuwen { get; set; }
        public int SumMath { get; set; }
        public int SumEnglish { get; set; }

        public override string ToString()
        {
            return string.Format("Sumyuwen:{0},SumMath:{1}SumEnglish:{2}",Sumyuwen,SumMath,SumEnglish);
        }
        
    }
}
