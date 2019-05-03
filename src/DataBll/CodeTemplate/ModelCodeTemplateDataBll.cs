using System;
using System.Collections.Generic;
using System.Text;
using Model.CodeTemplate;

namespace DataBll.CodeTemplate
{
    public sealed class ModelCodeTemplateDataBll : IDataBll.CodeTemplate.IModelCodeTemplateDataBll
    {

        private readonly IDal.CodeTemplate.IModelCodeTemplateDal Dal;

        public ModelCodeTemplateDataBll(
            IDal.CodeTemplate.IModelCodeTemplateDal argModelCodeTemplateDal
            )
        {
            Dal = argModelCodeTemplateDal;
        }

        /// <summary>
        /// 添加记录
        /// </summary>
        /// <typeparam name="ModelCodeTemplate">待修改的记录</typeparam>
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
        public Int32 Add(ModelCodeTemplate entity)
        {
            if (null == entity) return 0;

            return Dal.Add(entity);
        }


        /// <summary>
        /// 删除记录
        /// </summary>
        /// <typeparam name="ModelCodeTemplate">待修改的记录</typeparam>
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
        public Int32 Delete(ModelCodeTemplate entity)
        {
            if (null == entity || String.IsNullOrWhiteSpace(entity.Identity)) return 0;

            return Dal.Add(entity);
        }

        /// <summary>
        /// 修改记录
        /// </summary>
        /// <typeparam name="ModelCodeTemplate">待修改的记录</typeparam>
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
        public Int32 Update(ModelCodeTemplate entity)
        {
            if (null == entity || String.IsNullOrWhiteSpace(entity.Identity)) return 0;

            return Dal.Add(entity);
        }

        /// <summary>
        /// 更新记录是否可用
        /// </summary>
        /// <typeparam name="ModelCodeTemplate">待修改的记录</typeparam>
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
        public Int32 UpdateIsEnable(ModelCodeTemplate entity)
        {
            if (null == entity || String.IsNullOrWhiteSpace(entity.Identity)) return 0;

            return Dal.Add(entity);
        }



    }
}
