

namespace MyProtocol
{
/// <summary>
/// 用户登录的协议（命令号）
/// </summary>
    public  class LoginProtocol
    {
        /// <summary>
        /// 客户端To服务端 注册
        /// </summary>
        public const short C2S_Register = 1;
        /// <summary>
        /// 服务端TO客户端 注册
        /// </summary>
        public const short S2C_Register = 2;

        /// <summary>
        /// 客户端To服务端 登录
        /// </summary>
        public const short C2S_Login = 3;
        /// <summary>
        /// 服务端TO客户端 登录
        /// </summary>
        public const short S2C_Login = 4;
    }
}
