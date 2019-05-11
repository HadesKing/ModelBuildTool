using Model.CodeTemplate;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDataBll.CodeTemplate
{

    /// <summary>
    /// Model 代码 模板 数据业务逻辑处理层
    /// </summary>
    public interface ICodeBuildTemplateDataBll
    {

        /// <summary>
        /// 添加记录
        /// </summary>
        /// <typeparam name="CodeBuildTemplate">待修改的记录</typeparam>
        /// <param name="entity">实体类型</param>
        /// <returns>受影响的行数</returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-02</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        Int32 Add(CodeBuildTemplate entity);

        /// <summary>
        /// 删除记录
        /// </summary>
        /// <typeparam name="CodeBuildTemplate">待修改的记录</typeparam>
        /// <param name="entity">实体类型</param>
        /// <returns>受影响的行数</returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-02</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        Int32 Delete(CodeBuildTemplate entity);

        /// <summary>
        /// 修改记录
        /// </summary>
        /// <typeparam name="CodeBuildTemplate">待修改的记录</typeparam>
        /// <param name="entity">实体类型</param>
        /// <returns>受影响的行数</returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-02</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        Int32 Update(CodeBuildTemplate entity);
        
        /// <summary>
        /// 更新记录是否可用
        /// </summary>
        /// <typeparam name="CodeBuildTemplate">待修改的记录</typeparam>
        /// <param name="entity">实体类型</param>
        /// <returns>受影响的行数</returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-02</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        Int32 UpdateIsEnable(CodeBuildTemplate entity);

    }
}
