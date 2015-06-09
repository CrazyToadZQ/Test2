using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Tellyes.Common
{
    public class OSCEAESCrypt
    {
        private static string strAesKeyText = "天津天堰科技股份有限公司-www.tellyes.com-OSCE-TYPT"; //加密所需32位密匙

        public static string StrAesKeyText
        {
            get{ return strAesKeyText; }
            set { strAesKeyText=value; }
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="str">要加密字符串</param>
        /// <returns>返回加密后字符串</returns>
        public static String Encrypt_AES(string str)
        {
            string strAesKey = BitConverter.ToString((new MD5CryptoServiceProvider()).ComputeHash(Encoding.Default.GetBytes(strAesKeyText))).Replace("-", "");
            Byte[] keyArray = System.Text.UTF8Encoding.UTF8.GetBytes(strAesKey);
            Byte[] toEncryptArray = System.Text.UTF8Encoding.UTF8.GetBytes(str);
            System.Security.Cryptography.RijndaelManaged rDel = new System.Security.Cryptography.RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = System.Security.Cryptography.CipherMode.ECB;
            rDel.Padding = System.Security.Cryptography.PaddingMode.PKCS7;
            System.Security.Cryptography.ICryptoTransform cTransform = rDel.CreateEncryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        /// <summary>
        /// AES解密  
        /// </summary>
        /// <param name="str">要解密字符串</param>
        /// <returns>返回解密后字符串</returns>
        public static String Decrypt_AES(string str)
        {
            string strAesKey = BitConverter.ToString((new MD5CryptoServiceProvider()).ComputeHash(Encoding.Default.GetBytes(strAesKeyText))).Replace("-", "");
            Byte[] keyArray = System.Text.UTF8Encoding.UTF8.GetBytes(strAesKey);
            Byte[] toEncryptArray = Convert.FromBase64String(str);
            System.Security.Cryptography.RijndaelManaged rDel = new System.Security.Cryptography.RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = System.Security.Cryptography.CipherMode.ECB;
            rDel.Padding = System.Security.Cryptography.PaddingMode.PKCS7; System.Security.Cryptography.ICryptoTransform cTransform = rDel.CreateDecryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return System.Text.UTF8Encoding.UTF8.GetString(resultArray);
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="strAesKeyText">秘钥字符串</param>
        /// <param name="str">要加密字符串</param>
        /// <returns>返回加密后字符串</returns>
        public static String Encrypt_AES(string strAesKeyText, string str)
        {
            string strAesKey = BitConverter.ToString((new MD5CryptoServiceProvider()).ComputeHash(Encoding.Default.GetBytes(strAesKeyText))).Replace("-", "");
            Byte[] keyArray = System.Text.UTF8Encoding.UTF8.GetBytes(strAesKey);
            Byte[] toEncryptArray = System.Text.UTF8Encoding.UTF8.GetBytes(str);
            System.Security.Cryptography.RijndaelManaged rDel = new System.Security.Cryptography.RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = System.Security.Cryptography.CipherMode.ECB;
            rDel.Padding = System.Security.Cryptography.PaddingMode.PKCS7;
            System.Security.Cryptography.ICryptoTransform cTransform = rDel.CreateEncryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="strAesKeyText">秘钥字符串</param>
        /// <param name="str">要解密字符串</param>
        /// <returns>返回解密后字符串</returns>
        public static String Decrypt_AES(string strAesKeyText, string str)
        {
            string strAesKey = BitConverter.ToString((new MD5CryptoServiceProvider()).ComputeHash(Encoding.Default.GetBytes(strAesKeyText))).Replace("-", "");
            Byte[] keyArray = System.Text.UTF8Encoding.UTF8.GetBytes(strAesKey);
            Byte[] toEncryptArray = Convert.FromBase64String(str);
            System.Security.Cryptography.RijndaelManaged rDel = new System.Security.Cryptography.RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = System.Security.Cryptography.CipherMode.ECB;
            rDel.Padding = System.Security.Cryptography.PaddingMode.PKCS7; System.Security.Cryptography.ICryptoTransform cTransform = rDel.CreateDecryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return System.Text.UTF8Encoding.UTF8.GetString(resultArray);
        }
    }
}
