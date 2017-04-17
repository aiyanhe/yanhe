using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon
{
    
    /// <summary>
    /// 加密解密
    /// </summary>
    public  static class  DEncrypt
    {
        public static string Key = "qwertyuiop";

        #region 加密解密byte[]

       
        /// <summary>
        /// 加密 使用指定的密匙加密byte[] 
        /// </summary>
        /// <param name="original"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static byte[] Encrypt(byte[] original ,byte[] key)
        {
            
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = MakeMD5(key);
            des.Mode = CipherMode.ECB;
             return des.CreateEncryptor().TransformFinalBlock(original, 0, original.Length);
        }
        /// <summary>
        /// 解密 使用指定的密匙解密byte[]
        /// </summary>
        /// <param name="original"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static byte[] Decrypt(byte[] original, byte[] key)
        {
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = MakeMD5(key);
            des.Mode = CipherMode.ECB;
            return des.CreateDecryptor().TransformFinalBlock(original, 0, original.Length);
        }

        /// <summary>
        /// 加密 使用默认的密匙加密byte[] 
        /// </summary>
        /// <param name="original"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static byte[] Encrypt(byte[] original)
        {

            byte[] key = Encoding.Default.GetBytes(Key);
            return Encrypt(original, key);
        }

        /// <summary>
        /// 解密 使用默认的密匙解密byte[]
        /// </summary>
        /// <param name="original"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static byte[] Decrypt(byte[] original)
        {
            byte[] key = Encoding.Default.GetBytes(Key);
            return  Decrypt(original, key);
        }
#endregion

        #region 加密解密string
        /// <summary>
        /// 加密 使用指定的密匙加密string,使用指定编码
        /// </summary>
        /// <param name="original"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Encrypt(string original, string key, Encoding encoding)
        {
            byte[] k = MakeMD5(Encoding.Default.GetBytes(key));
            byte[] s = Encoding.Default.GetBytes(original);
            return encoding.GetString(Encrypt(s, k));
        }
        /// <summary>
        /// 解密 使用指定的密匙解密string,使用指定编码
        /// </summary>
        /// <param name="original"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Decrypt(string original, string key, Encoding encoding)
        {
            byte[] k = MakeMD5(Encoding.Default.GetBytes(key));
            byte[] s = Encoding.Default.GetBytes(original);
            return encoding.GetString(Decrypt(s, k));
        }

        /// <summary>
        /// 加密 使用指定的密匙加密string,使用默认编码
        /// </summary>
        /// <param name="original"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Encrypt(string original, string key)
        {
            return Encrypt(original, key, Encoding.Default);
        }
        /// <summary>
        /// 解密 使用指定的密匙解密string，,使用默认编码
        /// </summary>
        /// <param name="original"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Decrypt(string original, string key)
        {
            return Decrypt(original, key, Encoding.Default);
        }

        /// <summary>
        /// 加密 使用默认的密匙加密string 
        /// </summary>
        /// <param name="original"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Encrypt(string original)
        {

            byte[] s = Encoding.Default.GetBytes(original);
            return Encoding.Default.GetString(Encrypt(s));
        }

        /// <summary>
        /// 解密 使用默认的密匙解密string
        /// </summary>
        /// <param name="original"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Decrypt(string original)
        {
            byte[] s = Encoding.Default.GetBytes(original);
            return Encoding.Default.GetString(Decrypt(s));
        }
        

        #endregion
        /// <summary>
        /// 将原始Key进行MD5的不可逆加密，然后返回
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private static byte[] MakeMD5(byte[] key)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            return  md5.ComputeHash(key, 0, key.Length);

        }
    }
}
