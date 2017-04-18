using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SevenZip;

namespace NetCommon
{
    public  class NetworkDelgate
    {
        /// <summary>
        /// 消息编码
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public  delegate byte[] MessageEncoad(object value);
        /// <summary>
        /// 消息解码
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public delegate object MessageDncoad(byte[] value);

        /// <summary>
        /// 长度编码器
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public delegate byte[] LengthEncoad(byte[] value);
        /// <summary>
        /// 长度解码器
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public delegate byte[] LengthDncoad( ref List<byte> value);
        /// <summary>
        /// 消息加密
        /// </summary>
        /// <param name="buff"></param>
        /// <returns></returns>
        public delegate byte[] MessageEncrypt(byte[] buff);
        /// <summary>
        /// 消息解密
        /// </summary>
        /// <param name="buff"></param>
        /// <returns></returns>
        public delegate byte[] MessageDecrypt(byte[] buff);
        /// <summary>
        /// 消息压缩
        /// </summary>
        /// <param name="buff"></param>
        /// <param name="progress"></param>
        /// <returns></returns>
        public delegate byte[] CompressEncode(byte[] buff,ICodeProgress progress = null);
        /// <summary>
        /// 消息解压
        /// </summary>
        /// <param name="buff"></param>
        /// <param name="progress"></param>
        /// <returns></returns>
        public delegate byte[] CompressDecode(byte[] buff, ICodeProgress progress = null);

       
    }
}
