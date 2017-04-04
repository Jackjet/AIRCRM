//**********************************************************
//Copyright (C) 2012 正途旅行平台 版权所有。
//文件名：SignHelper.cs
//文件功能：MD5签名 帮助类
//创建标识：huzhiman 2012-03-13
//
//修改标识：
//修改描述：
//**********************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Security.Cryptography;

namespace Policy
{
    public class SignHelper
    {
        /// <summary>
        /// 生成签名结果
        /// </summary>
        /// <param name="sArray">要签名的数组</param>
        /// <param name="key">安全校验码</param>
        /// <param name="signtype">签名类型</param>
        /// <param name="charset">编码格式</param>
        /// <returns>签名结果字符串</returns>
        private static string BuildMysign(Dictionary<string, string> dicArray, string key, string signtype, string charset)
        {
            string prestr = CreateLinkString(dicArray);  //把数组所有元素，按照“参数=参数值”的模式用“&”字符拼接成字符串

            prestr = prestr + key;                      //把拼接后的字符串再与安全校验码直接连接起来
            string mysign = Sign(prestr, signtype, charset);	//把最终的字符串签名，获得签名结果

            return mysign;
        }

        /// <summary>
        /// 主要是用于我们的支付跑转加密
        /// </summary>
        /// <param name="dicArray"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string BuildMD5sign(SortedDictionary<string, string> dicArray, string key, string charset)
        {
            Dictionary<string, string> dicPara = FilterPara(dicArray);

            return BuildMysign(dicPara, key, "MD5", charset);
        }

        public static string BuildRequestQuery(SortedDictionary<string, string> dicArray)
        {
            Dictionary<string, string> dicPara = FilterPara(dicArray);

            return CreateLinkString(dicPara);
        }

        /// <summary>
        /// 除去数组中的空值和签名参数并以字母a到z的顺序排序
        /// </summary>
        /// <param name="dicArrayPre">过滤前的参数组</param>
        /// <returns>过滤后的参数组</returns>
        private static Dictionary<string, string> FilterPara(SortedDictionary<string, string> dicArrayPre)
        {
            Dictionary<string, string> dicArray = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> temp in dicArrayPre)
            {
                if (temp.Key.ToLower() != "sign" && temp.Key.ToLower() != "signtype" && temp.Value != "" && temp.Value != null)
                {
                    dicArray.Add(temp.Key.ToLower(), temp.Value);
                }
            }

            return dicArray;
        }

        /// <summary>
        /// 把数组所有元素，按照“参数=参数值”的模式用“&”字符拼接成字符串
        /// </summary>
        /// <param name="sArray">需要拼接的数组</param>
        /// <returns>拼接完成以后的字符串</returns>
        private static string CreateLinkString(Dictionary<string, string> dicArray)
        {
            StringBuilder prestr = new StringBuilder();
            foreach (KeyValuePair<string, string> temp in dicArray)
            {
                prestr.Append(temp.Key + "=" + temp.Value + "&");
            }

            //去掉最後一個&字符
            int nLen = prestr.Length;
            if (prestr.Length > 0)
                prestr.Remove(nLen - 1, 1);

            return prestr.ToString();
        }

        /// <summary>
        /// 签名字符串
        /// </summary>
        /// <param name="prestr">需要签名的字符串</param>
        /// <param name="signtype">签名类型</param>
        /// <param name="charset">编码格式</param>
        /// <returns>签名结果</returns>
        public static string Sign(string prestr, string signtype, string charset)
        {
            StringBuilder sb = new StringBuilder(32);
            if (signtype.ToUpper() == "MD5")
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] t = md5.ComputeHash(Encoding.GetEncoding(charset).GetBytes(prestr));
                for (int i = 0; i < t.Length; i++)
                {
                    sb.Append(t[i].ToString("x").PadLeft(2, '0'));
                }
            }
            return sb.ToString();
        }
    }
}
