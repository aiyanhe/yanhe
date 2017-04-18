

namespace MyProtocol
{
    /// <summary>
/// 用户登录的协议（命令号）
/// </summary>
    public  class LoginProtocol
    {

        public const short C2S_Register = 1;//客户端To服务端 注册
        public const short S2C_Register = 2;//服务端TO客户端 注册

        public const short C2S_Login = 3;//登录
        public const short S2C_Login = 4;
    }
}
