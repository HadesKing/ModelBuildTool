using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ManagerWeb.Controllers
{
    /// <summary>
    /// Controller 基类
    /// </summary>
    public abstract class BaseController : Controller
    {
        /// <summary>
        /// 处理出错类
        /// </summary>
        /// <param name="argTitle">记录日志标题信息</param>
        /// <param name="argException">错误</param>
        protected void ProcessException(String argTitle, Exception argException)
        {

            StringBuilder sbErrorMsg = new StringBuilder();
            sbErrorMsg.Append("Exception info:");
            ////取得当前方法命名空间
            //sbErrorMsg.AppendFormat("Namespace:{0}", System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Namespace);
            //取得当前方法类全名 包括命名空间
            sbErrorMsg.AppendFormat("\r\n Class info:{0}", System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            //str += "命名空间+类名:" + System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName + "\n";
            ////获得当前类名
            //str += "类名:" + System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name + "\n";
            //取得当前方法名
            //str += "方法名:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n";
            sbErrorMsg.AppendFormat("\r\n Method info:{0}", System.Reflection.MethodBase.GetCurrentMethod().Name);

            Log.LogHelper.Error(sbErrorMsg.ToString());

            Log.LogHelper.Error(argTitle, argException);

        }

    }
}
