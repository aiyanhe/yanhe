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
        public NetworkDelgate.MessageDncoad MessageDncoad;
        public NetworkDelgate.MessageEncoad MessageEncoad;
       //长度编码
        public NetworkDelgate.LengthDncoad LengthDncoad;
        public NetworkDelgate.LengthEncoad LengthEncoad;

       //加密，解密
        public NetworkDelgate.MessageEncrypt MessageEncrypt;
       public NetworkDelgate.MessageDecrypt MessageDecrypt;

        //压缩，解压
        public NetworkDelgate.CompressEncode CompressEncode;
        public NetworkDelgate.CompressDecode CompressDecode;
    }
   
}
