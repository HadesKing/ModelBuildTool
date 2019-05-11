using System;
using System.Collections.Generic;
using System.Text;
using Model.CodeTemplate;

namespace DataBll.CodeTemplate
{
    /// <summary>
    /// 代码生成模板 数据业务逻辑处理类
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <author>刘迪</author>
    /// <createtime>2019-05-11</createtime>
    /// <updator></updator>
    /// <updatetime></updatetime>
    /// <description></description>
    public sealed class CodeBuildTemplateDataBll : IDataBll.CodeTemplate.ICodeBuildTemplateDataBll
    {

        private readonly IDal.CodeTemplate.ICodeBuildTemplateDal Dal;

        public CodeBuildTemplateDataBll(
            IDal.CodeTemplate.ICodeBuildTemplateDal argCodeBuildTemplateDal
            )
        {
            Dal = argCodeBuildTemplateDal;
        }

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
        public Int32 Add(CodeBuildTemplate entity)
        {
            if (null == entity) return 0;

            return Dal.Add(entity);
        }


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
        public Int32 Delete(CodeBuildTemplate entity)
        {
            if (null == entity || String.IsNullOrWhiteSpace(entity.Identity)) return 0;

            return Dal.Delete(entity);
        }

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
        public Int32 Update(CodeBuildTemplate entity)
        {
            if (null == entity || String.IsNullOrWhiteSpace(entity.Identity)) return 0;

            return Dal.Update(entity);
        }

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
        public Int32 UpdateIsEnable(CodeBuildTemplate entity)
        {
            if (null == entity || String.IsNullOrWhiteSpace(entity.Identity)) return 0;

            return Dal.UpdateIsEnable(entity);
        }



    }
}
