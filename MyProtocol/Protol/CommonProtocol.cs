namespace MyProtocol
{
    public  class CommonProtocol
    {
        /// <summary>
        /// 心跳测试，就是客户端和服务端相互确认对方是否在线的信息测试，传输的信息为空
        /// </summary>
        public const short C2S_HearBeat = 1;
      /// <summary>
        /// 心跳测试，就是服务端和客户端相互确认对方是否在线的信息测试，传输的信息为空
        /// </summary>
        public const short S2C_ErrorCode = 3;
    }
}
