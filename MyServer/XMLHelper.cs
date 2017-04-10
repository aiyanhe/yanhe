using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyConfig
{
   public class XMLHelper
    {
        /// 通过路径得到xml数据对象
        
        public static T FormatConfig<T>(string path)where T:class
        {

            Stream stream = File.OpenRead(path);
            XmlSerializer xs = new XmlSerializer(typeof(T));
            T res = xs.Deserialize(stream) as T;

            stream.Dispose();
            stream.Close();

            return res;
        }
    }
}
