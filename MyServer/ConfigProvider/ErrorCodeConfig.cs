using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyServer.ConfigProvider
{
    //XML序列化是将对象的公共属性和字段转换为XML格式，以便存储或传输的过程。
    //反序列化则是从XML输出中重新创建原始状态的对象。
    //XML序列化中最主要的类是XmlSerializer类。
    //它的最重要的方法是Serialize和Deserialize方法，它位于System.Xml.Serialization命名空间。

    // 不清楚用途 
    public enum E_ErrorLocal
    {
        None,
        Fly,
        MessageBox
    }
    class ErrorCodeConfig:XmlConfig<ErrorCodeConfig>
    {
    }
}
