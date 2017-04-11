using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyConfig
{
    //internal 只能在程序集中访问
    internal interface IRead
    {
        void Read(string name);
    }
    public  class ConstenHelp
    {

        public static T FormatConfig<T>(string path) where T:class,new()
        {
            string str = File.ReadAllText(path);
            IRead ir = (IRead)new T();
            ir.Read(str);
            return ir as T;
        }
    }
}
