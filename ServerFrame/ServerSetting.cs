using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
