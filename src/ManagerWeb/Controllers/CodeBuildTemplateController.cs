using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ManagerWeb.Controllers
{
    /// <summary>
    /// 代码生成模板控制器
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <author>刘迪</author>
    /// <createtime>2019-05-07</createtime>
    /// <updator></updator>
    /// <updatetime></updatetime>
    /// <description></description>
    public class CodeBuildTemplateController : BaseController
    {
        private IDataBll.CodeTemplate.ICodeBuildTemplateDataBll CodeBuildTemplateDataBll { get; set; }

        public CodeBuildTemplateController(IDataBll.CodeTemplate.ICodeBuildTemplateDataBll codeBuildTemplateDataBll)
        {
            CodeBuildTemplateDataBll = codeBuildTemplateDataBll;
        }

        /// <summary>
        /// 模板列表页
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-07</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        public IActionResult Index()
        {

            return View();
        }

        /// <summary>
        /// 添加模板页
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-07</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        [HttpPost]
        public IActionResult Add([FromBody]Models.CodeBuildTemplateViewModel model)
        {
            Util.ResponseResult.ReturnResult response = new Util.ResponseResult.ReturnResult();
            try
            {
                Model.CodeTemplate.CodeBuildTemplate codeBuildTemplate = new Model.CodeTemplate.CodeBuildTemplate();

                CodeBuildTemplateDataBll.Add(codeBuildTemplate);
                response.IsSuccess = true;
                response.Description = "Success";
            }
            catch (Exception ex)
            {
                String strErrorMsg = String.Format("Failure.Exception message is {0}", ex.Message);

                //StringBuilder sbErrorMsg = new StringBuilder();
                //sbErrorMsg.Append("Exception info:");
                //////取得当前方法命名空间
                ////sbErrorMsg.AppendFormat("Namespace:{0}", System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Namespace);
                ////取得当前方法类全名 包括命名空间
                //sbErrorMsg.AppendFormat("\r\n Class info:{0}", System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
                ////str += "命名空间+类名:" + System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName + "\n";
                //////获得当前类名
                ////str += "类名:" + System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name + "\n";
                ////取得当前方法名
                ////str += "方法名:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n";
                //sbErrorMsg.AppendFormat("\r\n Method info:{0}", System.Reflection.MethodBase.GetCurrentMethod().Name);

                ProcessException(strErrorMsg, ex);
                response.IsSuccess = false;
                response.Description = strErrorMsg;
            }
            return Json(response);
        }


    }
}