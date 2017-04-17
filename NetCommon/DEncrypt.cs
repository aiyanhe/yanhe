using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon
{
    class DEncrypt
    {

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
