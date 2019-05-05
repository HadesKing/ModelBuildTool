using System;
using System.Collections.Generic;
using System.Text;

namespace Dto.CodeTemplate
{

    /// <summary>
    /// Model类代码模板 数据传输对象(Data Transfer Object)层
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <author>刘迪</author>
    /// <createtime>2019-05-05</createtime>
    /// <updator></updator>
    /// <updatetime></updatetime>
    /// <description></description>
    public sealed class ModelCodeTemplateDto
    {
        public ModelCodeTemplateDto()
        {
            IsEnable = 1;
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
        /// 作者信息
        /// </summary>
        public String AuthorInfo { get; set; }

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

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public String CreateBy { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime LastUpdateTime { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public String UpdateBy { get; set; }



    }
}
