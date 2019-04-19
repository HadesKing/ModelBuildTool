using System;
using System.Collections.Generic;
using System.Text;

namespace Tips
{
    /// <summary>
    /// 登录提示
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <author>刘迪</author>
    /// <createtime>2019-01-11</createtime>
    /// <updator></updator>
    /// <updatetime></updatetime>
    /// <description></description>
    public sealed class LoginTips
    {
        /// <summary>
        /// 用户名不能为空
        /// </summary>
        public const String UserNameNotEmpty = "用户名不能为空";
        /// <summary>
        /// 用户不存在
        /// </summary>
        public const String UserNameNotExist = "用户不存在，请重新输入用户名和密码";


        public const String UserNameMismatchRule = "只能输入{0}到{1}个字符串的用户名";
        public const String PasswordMismatchRule = "只能输入{0}到{1}个字符串的密码";

        /// <summary>
        /// 密码不能为空
        /// </summary>
        public const String PasswordNotEmpty = "密码不能为空";
        /// <summary>
        /// 用户名或密码错误
        /// </summary>
        public const String UserNameOrPasswordError = "用户名或密码错误，请重新输入用户名和密码";

        /// <summary>
        /// 用户名或者密码不符合要求
        /// </summary>
        public const String ParameterError = "用户名或者密码不符合要求，请重新输入";

    }
}
