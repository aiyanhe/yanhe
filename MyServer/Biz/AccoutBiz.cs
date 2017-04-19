using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProtocol;
using ServerFrame;

namespace MyServer.Biz
{
    /// <summary>
    /// 单独处理登录注册的处理逻辑（暂时）
    /// </summary>
    public  class AccoutBiz:IBiz
    {
        /// <summary>
        /// 创建账号
        /// </summary>
        /// <param name="token"></param>
        /// <param name="dto"></param>
        public void Create(UserToken token , AccountDto dto)
        {
            //验证账号密码的合法性
            if (string.IsNullOrEmpty(dto.Account)||string.IsNullOrEmpty(dto.Password))
            {
                //当账号或者密码为空的时候
                //因为下面内容经常使用，所以就建一个扩展UserToken的类，内置这些内容；
                //NetModle modle = new NetModle();
                //modle.Type = Protocol.Common;
                //modle.Command = CommonProtocol.S2C_ErrorCode;
                //modle.Message = ErrorCode.AccountPasswordIsNotSafe;//主要目的！把错误信息打包进modle中，发给客户端看
                //token.Send(modle);

            ExUserToken.Send(token,ErrorCode.AccountPasswordIsNotSafe);
                return;
            }
            //todo 验证账号是否被注册，需要调用缓存层进行验证

            //todo  调用缓存层创建账号

            //通知客户端注册账号成功
            token.Send(Protocol.Login,LoginProtocol.S2C_Login);


        }
        /// <summary>
        /// 登录账号，返回一个ErrorCode，用户登录情况的枚举
        /// </summary>
        /// <param name="token"></param>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public ErrorCode Login(UserToken token,string account,string password)
        {
            //验证账号密码的合法性
            if (string.IsNullOrEmpty(account)||string.IsNullOrEmpty(password))
            {
                return ErrorCode.AccountPasswordIsNotSafe;
            }
            //todo 验证账号是否注册
            
            //todo 验证是否已经登录
            //todo 验证账号密码是否匹配
            //todo 上线

        }


    }
}
