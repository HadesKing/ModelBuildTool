using System;
using System.Collections.Generic;
using System.Text;

namespace IDal.CodeTemplate
{

    /// <summary>
    /// Model 代码模板 数据访问层
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <author>刘迪</author>
    /// <createtime>2019-05-02</createtime>
    /// <updator></updator>
    /// <updatetime></updatetime>
    /// <description></description>
    public interface ICodeBuildTemplateDal : IAdd, IDelete, IUpdate
    {

        /// <summary>
        /// 更新是否可用
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-02</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        Int32 UpdateIsEnable<TEntity>(TEntity entity);

    }
}
