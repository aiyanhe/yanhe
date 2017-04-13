using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon
{
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

    class NetModle
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
