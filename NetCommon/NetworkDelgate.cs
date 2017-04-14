using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
