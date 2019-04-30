using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Util;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagerWeb.Controllers
{
    public class LoginController : Controller
    {
        /// <summary>
        /// JSON序列化
        /// </summary>
        private Util.JsonSerialize.IJsonSerialize JsonConverter { get; set; }

        /// <summary>
        /// 日志
        /// </summary>
        private Log.ILog Logger { get; set; }

        /// <summary>
        /// HttpContext
        /// </summary>
        private readonly IHttpContextAccessor _contextAccessor;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="jsonSerialize"></param>
        public LoginController(Util.JsonSerialize.IJsonSerialize jsonSerialize
            , Log.ILog logger
            //, IDataBLL.User.IUserInfoDataBll userInfoDataBll
            , IHttpContextAccessor contextAccessor
            )
        {
            JsonConverter = jsonSerialize;
            Logger = logger;
            //UserInfoDataBll = userInfoDataBll;

            _contextAccessor = contextAccessor;
            _contextAccessor.CheckArgumentIsNull(nameof(_contextAccessor));
        }

        // GET: /<controller>/
        /// <summary>
        /// 登录页
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewData["Title"] = "登 录";
            return View();
        }


        /// <summary>
        /// 校验用户信息
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>返回验证结果和错误描述</returns>
        private (bool, String) ValidateUserInfo(
            String userName, String password
            )
        {
            StringBuilder sbErrorMsg = new StringBuilder();
            String strSplit = "\r\n";
            bool result = true;
            //校验用户名
            if (String.IsNullOrWhiteSpace(userName))
            {
                result = false;
                sbErrorMsg.Append(Tips.LoginTips.UserNameNotEmpty);
                sbErrorMsg.Append(strSplit);
            }
            else if (userName.Length > 30 || password.Length < 3)
            {
                result = false;
                sbErrorMsg.AppendFormat(Tips.LoginTips.UserNameMismatchRule, 3, 30);
                sbErrorMsg.Append(strSplit);
            }
            //校验密码
            if (String.IsNullOrWhiteSpace(password))
            {
                result = false;
                sbErrorMsg.Append(Tips.LoginTips.PasswordNotEmpty);
                sbErrorMsg.Append(strSplit);
            }
            else if (password.Length > 20 || password.Length < 6)
            {
                result = false;
                sbErrorMsg.AppendFormat(Tips.LoginTips.PasswordMismatchRule, 6, 20);
                sbErrorMsg.Append(strSplit);
            }

            String strErrorMsg = sbErrorMsg.ToString();
            if (!String.IsNullOrWhiteSpace(strErrorMsg))
                strErrorMsg = strErrorMsg.Substring(0, strErrorMsg.Length - strSplit.Length);

            return (result, strErrorMsg);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Post(String userName, String password, bool remember = false)
        {
            //String strPassword1 = Util.EncryptionAlgorithm.Md5Algorithm.Encryption32("123456");
            //HttpResponseMessage responseMessage = new HttpResponseMessage();
            Util.ResponseResult.ReturnData<String> returnData = new Util.ResponseResult.ReturnData<string>();
            try
            {
                //responseMessage.StatusCode = System.Net.HttpStatusCode.Unauthorized;
                bool validateResult;
                String strErrorMsg;
                (validateResult, strErrorMsg) = ValidateUserInfo(userName, password);
                //1. 校验用户信息
                if (validateResult)
                {
                    ////2. 在数据库查询用户信息
                    //Model.User.UserInfo userInfo = UserInfoDataBll.Get(userName);
                    //if (null != userInfo && userInfo.ID > 0)
                    //{
                    //    //3. 记录用户登录信息（写入redis/cookie等等）
                    //    String strPassword = Util.EncryptionAlgorithm.Md5Algorithm.Encryption32(password);
                    //    if (userInfo.Password == strPassword)
                    //    {
                    //        //Session["UserName"] = "";
                    //        //记录Session
                    //        //_contextAccessor.HttpContext.Session.Set("UserName", Util.ByteConvertHelper.ObjectToBytes(userInfo.UserName));
                    //        //_contextAccessor.HttpContext.Session.SetString("UserName", userInfo.UserName);
                    //        byte[] byteUserName = ByteConvertHelper.ObjectToBytes(userInfo.UserName);
                    //        _contextAccessor.HttpContext.Session.Set("UserName", ByteConvertHelper.ObjectToBytes(userInfo.UserName));
                    //        _contextAccessor.HttpContext.Response.Cookies.Append("UserName", byteUserName.ToString(), new CookieOptions()
                    //        {
                    //            HttpOnly = true
                    //            ,
                    //            Expires = DateTime.UtcNow.AddDays(7)
                    //        });

                    //        returnData.IsSuccess = true;
                    //        returnData.Description = Tips.CommonTips.SUCCESS;
                    //        //responseMessage.StatusCode = System.Net.HttpStatusCode.OK;
                    //    }
                    //    else
                    //    {
                    //        returnData.Description = Tips.LoginTips.UserNameOrPasswordError;
                    //    }
                    //}
                    //else
                    //{
                    //    returnData.Description = Tips.LoginTips.UserNameNotExist;
                    //}
                }
                else
                {
                    returnData.Description = Tips.LoginTips.ParameterError;     //输入用户名或者密码不符合规范，提示参数有误
                }
            }
            catch (Exception ex)
            {
                Logger.Error(String.Format("User:{0} Password:{1} login fail", userName, password), ex);
                //responseMessage.StatusCode = System.Net.HttpStatusCode.Unauthorized;
                returnData.Description = Tips.SystemTips.SystemInnerError;
            }
            //responseMessage.Content = new StringContent(
            //    JsonConverter.Serialize(returnData)
            //    , Encoding.GetEncoding("UTF-8"), "application/json");
            //return responseMessage;
            return new JsonResult(returnData);
        }


    }
}
