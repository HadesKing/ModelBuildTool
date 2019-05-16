using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerWeb.Models
{

    /// <summary>
    /// 代码生成模板
    /// </summary>
    public sealed class CodeBuildTemplateViewModel
    {
        public CodeBuildTemplateViewModel()
        {
            Identity = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// 自增字段
        /// </summary>
        public String Id { get; set; }

        /// <summary>
        /// 身份标识
        /// </summary>
        public String Identity { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public String Name { get; set; }
        
        /// <summary>
        /// using信息
        /// </summary>
        public String UsingInfo { get; set; }

        /// <summary>
        /// namespace 信息
        /// </summary>
        public String NamespaceInfo { get; set; }

        /// <summary>
        /// class 信息
        /// </summary>
        public String ClassInfo { get; set; }

        /// <summary>
        /// 属性 信息
        /// </summary>
        public String PropertyInfo { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public Int16 IsEnable { get; set; }

    }
}
