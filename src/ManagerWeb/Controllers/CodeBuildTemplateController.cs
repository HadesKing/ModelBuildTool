using System;
using System.Collections.Generic;
using System.Linq;
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
        public CodeBuildTemplateController()
        {

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
        public IActionResult Add(Models.CodeBuildTemplateViewModel model)
        {


            return View();
        }


    }
}