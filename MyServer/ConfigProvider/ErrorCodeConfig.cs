using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConfig
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
    public partial class ErrorCodeConfig : XmlConfig<ErrorCodeConfig>//这里的ErrorCodeConfig名称应和Xml的名称一致
    {
        /// 通过id获取错误位置

        public static E_ErrorLocal GetLocalById(int id)
        {
            ErrorCodeConfigContent error = Array.Find<ErrorCodeConfigContent>(Config.Content, (item) =>
                {
                    return item.Id == id;
                });
            if (error == null)
            {
                return E_ErrorLocal.None;
            }
            return (E_ErrorLocal)error.Local;
        }
        /// 通过id得到描述
        
        public static string GetErrorById(int id)
    {
        ErrorCodeConfigContent error = Array.Find<ErrorCodeConfigContent>(Config.Content, (item) =>
        {
            return item.Id == id;
        });
        if (error == null)
        {
            return "配置表中没有找到该错误信息！ Error ID:" + id;
        }
        return error.Name;
    
    }
        protected override void Init()
        {
            base.Init();
            // Data.Name = "ErrorCode";
            // Data.Extension = ".xff";
        }

    }
}
