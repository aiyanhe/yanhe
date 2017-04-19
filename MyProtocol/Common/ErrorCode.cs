namespace MyProtocol
{
    /// <summary>
    /// 用户登录出现的情况
    /// </summary>
    public enum ErrorCode
    {/// <summary>
     /// 成功
     /// </summary>
        Success = 0,
        /// <summary>
        /// 账号已经被注册
        /// </summary>
        AccountHasRegister,
        /// <summary>
        /// 账号密码不合法
        /// </summary>
        AccountPasswordIsNotSafe,
        /// <summary>
        /// 账号不存在
        /// </summary>
        NotHasAccount,
        /// <summary>
        /// 账号已经登录
        /// </summary>
        HasLogin,
        /// <summary>
        /// 账号密码不匹配
        /// </summary>
        NotMatch
    }
}
