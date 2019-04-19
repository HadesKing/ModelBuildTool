using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public sealed class StringHelper
    {

        /// <summary>
        /// 字符串首字母大写
        /// </summary>
        /// <param name="argContent">待处理字符串</param>
        /// <returns></returns>
        public static String FirstCharUpper(String argContent)
        {
            if (String.IsNullOrWhiteSpace(argContent)) return "";

            String strFirstChar = argContent.Substring(0, 1);
            String strOther = argContent.Substring(1);
            return strFirstChar.ToUpper() + strOther;
        }

    }
}
