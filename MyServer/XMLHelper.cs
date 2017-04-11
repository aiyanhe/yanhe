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
        
        public static T FormatConfig<T>(string path)where T: class //加载文件，返回一个由指定为T类型的XML文档反序列化为一个T类型的数据
        {

            Stream stream = File.OpenRead(path);//根据绝对路径读取文件
            XmlSerializer xs = new XmlSerializer(typeof(T));//将对象序列化到 XML 文档中和从 XML 文档中反序列化对象。XmlSerializer 使您得以控制如何将对象编码到 XML 中。 
            T res = xs.Deserialize(stream) as T;//Deserialize(Stream) 由指定的 XML 文档反序列化 Stream。
            stream.Dispose();//释放资源
            stream.Close();//停止流
            return res;
        }
    }
}
