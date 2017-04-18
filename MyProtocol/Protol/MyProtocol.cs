namespace MyProtocol
{
    /// <summary>
    /// 协议，消息的编码模式，如通用Common,登录Login,背包BackPack
    /// </summary>
    public enum Protocol : byte
        {
            /// <summary>
            /// 通用
            /// </summary>
            Common,
            /// <summary>
            /// 登录
            /// </summary>
            Login,
            /// <summary>
            /// 背包
            /// </summary>
            BackPack

        }
    
}
