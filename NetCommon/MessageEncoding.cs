using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon
{
    class MessageEncoding
    {
        /// <summary>
        /// 序列化，消息编码
        /// </summary>
        /// <param name="?"></param>
        /// <returns></returns>

        public byte[] Encoad(object value)
        { 
        
            NetModle nem = (NetModle)value;//将object类型消息转成标准的消息模块
            ByteArrary ba = new ByteArrary();
            ba.Write(nem.Type);//写入模块类型
            ba.Write(nem.Command);//写入命令号
            if (nem.Message!=null)//如果有消息体
            {
                ba.Write(nem.Message);
            }
             byte[] bt = ba.GetCopyBytes();//转成二进制
             ba.Close();
             return bt;
        }
        /// <summary>
        /// 反序列化，消息解码
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public object Dncoad(byte[] value)
        {
            NetModle nem = new NetModle();
            ByteArrary ba = new ByteArrary(value);
           ba.Read(out nem.Type);//一步步获取，拆出Type,Command,Message
           ba.Read(out nem.Command);
           ba.Read(ba.Length-ba.Position,out nem.Message);
           ba.Close();
           return nem;
        
        }
    }
}
