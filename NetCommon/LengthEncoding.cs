using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon
{
    class LengthEncoding
    {
        /// <summary>
        /// 消息长度编码，就是在我们消息前面在加入一个长度
        /// </summary>
        public byte[] Encoad(byte[] buff)
        {
            ByteArrary ba = new ByteArrary();
            ba.Write(buff.Length);//先读入消息长度
            ba.Write(buff);//再读入消息体
           buff= ba.GetCopyBytes();//将流中的消息转换出来
           ba.Close();//关闭流
           return buff;//将包装好的消息体传出
        }
        /// <summary>
        /// 消息长度解码
        /// </summary>
        public byte[] Dncoad(ref List<byte> buff)
        {
            if (buff.Count < 4)//连组成消息头的字节数量都不够
            {
                return null;
            }
            ByteArrary ba = new ByteArrary(buff.ToArray());
            int len;
            //同时，position提升了4个字节
            ba.Read(out len);//读取一个int就读取4个字节，长度消息加入的时候是一个int,也就占了四字节
            if (len>buff.Count-4)//读出的消息长度确定完整的消息需要的字节数量>实际传入的消息长度的字节量减去消息头
            {
                return null;//实际消息体不完整
            }
            //读出所需的消息
            byte[] bt;
            ba.Read(out bt,len);

            //剩下的消息重新加载会list
            byte[] temp;
            ba.Read(out temp,buff.Count-4-len);
            buff.Clear();//先清空list
            buff.AddRange(temp);//再加载剩余信息
            ba.Close();
            return bt;
        }
    }

 
}
