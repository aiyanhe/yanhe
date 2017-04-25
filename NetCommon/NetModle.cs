using System;
using MyProtocol;

namespace NetCommon
{

    /// <summary>
    /// 消息的模块，如模块号Protocol Type，命令号，当前子模块下的不同命令short Command，息体，当前协议对应的消息数据Object Message
    /// </summary>
    public class NetModle
    {
        /// <summary>
        /// 模块号
        /// </summary>
        public Protocol Type;
        /// <summary>
        /// 命令号，当前子模块下的不同命令
        /// </summary>
        public short Command;
        /// <summary>
        /// 消息体，当前协议对应的消息数据，可以为空
        /// </summary>
        public Object Message;
        /// <summary>
        /// 获取想要类型的消息体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetMessage<T>()
        {
            return (T) Message;

        }

        public override string ToString()
        {
          return  string.Format("NetModle Type:{0},Command:{1},Message:{2}",Type,Command,Message);
        }
    }


}
