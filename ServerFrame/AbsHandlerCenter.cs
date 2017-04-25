namespace ServerFrame
{
    /// <summary>
    /// 记录用户的行为
    /// </summary>
    public abstract class AbsHandlerCenter
    {
        /// <summary>
        /// 接收用户消息
        /// </summary>
        /// <param name="Uto"></param>
        /// <param name="message"></param>
        public abstract void ReceiveMessage(UserToken Uto,object message);
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="Uto"></param>
        public abstract void ClientAccept(UserToken Uto);
        /// <summary>
        /// 用户离开
        /// </summary>
        /// <param name="Uto"></param>
        /// <param name="error"></param>
        public abstract void ClientClose(UserToken Uto,string error);
    }
}
