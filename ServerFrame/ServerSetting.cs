using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCommon;

namespace ServerFrame
{
    /// <summary>
    /// 服务器默认配置
    /// </summary>
   public  class ServerSetting
    {
        /// <summary>
        /// 默认端口号
        /// </summary>
        public int point = 12345;

        /// <summary>
        /// 默认最大客户端
        /// </summary>
        public int MaxAccept = 100;

       /// <summary>
        /// 消息处理中心
       /// </summary>
        public AbsHandlerCenter Center;

       //消息编码
        public NetCommon.NetworkDelgate.MessageDncoad MessageDncoad;
        public NetCommon.NetworkDelgate.MessageEncoad MessageEncoad;
       //长度编码
        public NetCommon.NetworkDelgate.LengthDncoad LengthDncoad;
        public NetCommon.NetworkDelgate.LengthEncoad LengthEncoad;
    }
}
