using System;

namespace MyProtocol
{
    [Serializable]
   public class AccountDto
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string Account;
        /// <summary>
        /// 密码
        /// </summary>
        public string Password;

       
        public override string ToString()
        {
            return string.Format("Account:{0} Password:{1}",Account,Password);
        }
    }
}
