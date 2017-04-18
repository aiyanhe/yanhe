namespace MyProtocol
{
    /// <summary>
    /// 用户登录出现的情况
    /// </summary>
    public enum ErrorCode
    {
        Success = 0,      //成功
        AccountHasRegister,//账号已经被注册
        AccountPasswordIsNotSafe,//账号密码不合法
        NotHasAccount,//账号不存在
        HasLogin,//账号已经登录
        NotMatch//账号密码不匹配
    }
}
