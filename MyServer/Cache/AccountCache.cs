using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maticsoft;
using MyProtocol;
using ServerFrame;

namespace MyServer.Cache
{
    /// <summary>
    /// 用户信息
    /// </summary>
    //public class ACCOUNT
    //{
    //    /// <summary>
    //    /// 用户ID
    //    /// </summary>
    //    public int id;
    //    /// <summary>
    //    /// 用户账号
    //    /// </summary>
    //    public string account;
    //    /// <summary>
    //    /// 用户密码
    //    /// </summary>
    //    public string password;
    //}
    /// <summary>
    /// 账号缓存数据
    /// </summary>
    public  class AccountCache:ICache
    {
        /// <summary>
        /// 在线用户列表
        /// </summary>
      Dictionary<UserToken,string> dicOlines = new Dictionary<UserToken, string>();
        /// <summary>
        /// 用户账号信息
        /// </summary>
        Dictionary<string,ACCOUNT>dicAccounts = new Dictionary<string, ACCOUNT>();
        /// <summary>
        /// 添加账户
        /// </summary>
        /// <param name="token"></param>
        /// <param name="dto"></param>
        public void Add(UserToken token, AccountDto dto)
        {
            ACCOUNT a = new ACCOUNT();
            a.account = dto.Account;
            a.password = dto.Password;

            //写入数据库
            a.id = a.GetMaxId();
            a.Add();
            dicAccounts.Add(dto.Account,a);//将用户信息添加到用户信息字典中
        }

        /// <summary>
        /// 账号是否已经注册
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public bool HasAccount(string account)
        {
            return dicAccounts.ContainsKey(account);
        }



        /// <summary>
        ///  用户上线
        /// </summary>
        /// <param name="userToken"></param>
        /// <param name="account"></param>
        public void Online(UserToken userToken,string account)
        {
            if (dicOlines.ContainsKey(userToken))//如果在线用户的客户端已经登录
            {
                dicOlines[userToken] = account;//将用户账号更新
            }
            else
            {
                dicOlines.Add(userToken,account);//没有登录，就添加进上线字典
            }
        }



        
        /// <summary>
        /// 用户下线
        /// </summary>
        /// <param name="userToken"></param>
        public void OffLine(UserToken userToken)
        {
            if (IsOnline(userToken))//先判断是否在线，在线才有下线
            {
                string account = dicOlines[userToken];//读取用户名
                if (dicAccounts.ContainsKey(account))//判断缓存的用户信息是否存在该账号
                {
                    dicAccounts.Remove(account);//如果存在，缓存用户信息字典删除该账号
                }
                dicOlines.Remove(userToken);//在线字典删除该账号
            }
            
        }
        /// <summary>
        /// 通过客户端 判断用户是否在线
        /// </summary>
        /// <param name="userToken"></param>
        /// <returns></returns>
        public bool IsOnline(UserToken userToken)
        {
            return dicOlines.ContainsKey(userToken);
        }
        /// <summary>
        /// 通过账户名 判断用户是否在线
        /// </summary>
        /// <param name="userToken"></param>
        /// <returns></returns>
        public bool IsOnline(string account)
        {
            return dicOlines.ContainsValue(account);
        }
        
        /// <summary>
        /// 账号密码是否匹配
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Matching(string account,string password)
        {
            //在用户信息字典中，该用户名account的ACCOUNT的密码是否符合password
            return dicAccounts[account].password.Equals(password);
        }
    }
}
