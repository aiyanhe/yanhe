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

    
    public enum E_ErrorLocal//错误消息的表现形式
    {
        //暂时无用
        None,
        Fly,//人物头上飘出来形式
        MessageBox//弹窗形式
    }
    public partial class ErrorCodeConfig : XmlConfig<ErrorCodeConfig>//这里的ErrorCodeConfig名称应和Xml的名称一致
                                                                     //因为路径名有一部分是以类名为指引的；如：C:\Users\123\Desktop\MyConfig\Xsd\ErrorCodeConfig.xml
    {
        /// 通过id获取错误位置

        public static E_ErrorLocal GetLocalById(int id)//根据ID找到对应的Local
        {
            //Array.Find<T>(T[] array, Predicate<T> match);
            //参数(array: 要搜索的从零开始的一维 Array ; match:Predicate，定义要搜索的元素的条件。)
            //返回值: 如果找到与指定谓词定义的条件匹配的第一个元素，则为该元素；否则为类型 T 的默认值。
            ErrorCodeConfigContent error = Array.Find<ErrorCodeConfigContent>(Config.Content, (item) =>
                {
                    return item.ID == id;//当ErrorCodeConfigContent[] Content中的子集的ID第一次等于 id时，返回这个Content
                });
            if (error == null)
            {
                return E_ErrorLocal.None;
            }
            return (E_ErrorLocal)error.Local;
        }
        /// 通过id得到描述

        public static string GetErrorById(int id)//根据ID找到对应的ErrorName
        {
            //解释同上
            ErrorCodeConfigContent error = Array.Find<ErrorCodeConfigContent>(Config.Content, (item) =>{ return item.ID == id; });
            if (error == null)//当没有Content的ID满足条件时，error为空
            {
                return "配置表中没有找到该错误信息！ Error ID:" + id;
            }
            return error.IntoGameName;//返回需要的内容(指定ID)

        }
        protected override void Init()
        {
            base.Init();
            // Data.Name = "ErrorCode";
            // Data.Extension = ".xff";
        }

    }
}
