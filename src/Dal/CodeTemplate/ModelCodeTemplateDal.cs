using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Model.CodeTemplate;

namespace Dal.CodeTemplate
{
    /// <summary>
    /// Model 代码生成模板 数据访问层
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <author>刘迪</author>
    /// <createtime>2019-05-01</createtime>
    /// <updator></updator>
    /// <updatetime></updatetime>
    /// <description></description>
    public sealed class ModelCodeTemplateDal : BaseModelBuildDal, IDal.CodeTemplate.IModelCodeTemplateDal
    {
        public ModelCodeTemplateDal(String argDbConnectString)
        {
            if(String.IsNullOrWhiteSpace(argDbConnectString))
            {
                throw new Exception("The database connect string is null or empty.");
            }
            DbConnectString = argDbConnectString;
        }

        /// <summary>
        /// 需要操作的表名称
        /// </summary>
        protected override string TableName => "ModelCodeTemplate";
        
        /// <summary>
        /// 添加记录
        /// </summary>
        /// <typeparam name="ModelCodeTemplate"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Int32 Add<ModelCodeTemplate>(ModelCodeTemplate entity)
        {
            String strTmpSql = @"
INSERT INTO {0} (
  `Identity`,
  `Name`,
  `AuthorInfo`,
  `UsingInfo`,
  `NamespaceInfo`,
  `ClassInfo`,
  `PropertyInfo`,
  `IsEnable`,
  `CreateTime`,
  `CreateBy`,
  `LastUpdateTime`,
  `UpdateBy`
) 
VALUES
  (
    @Identity,
    @Name,
    @AuthorInfo,
    @UsingInfo,
    @NamespaceInfo,
    @ClassInfo,
    @PropertyInfo,
    @IsEnable,
    @CreateTime,
    @CreateBy,
    @LastUpdateTime,
    @UpdateBy
  ) ;
";
            String strSql = String.Format(strTmpSql, TableName);

            return ExcuteNonQuery(
                strSql, entity, CommandType.Text);
        }

        /// <summary>
        /// 删除记录
        /// </summary>
        /// <typeparam name="ModelCodeTemplate"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Int32 Delete<ModelCodeTemplate>(ModelCodeTemplate entity)
        {
            String strTmpSql = @"
DELETE 
FROM
  `codebuild`.`modelcodetemplate` 
WHERE `Identity` = @Identity ;
";
            String strSql = String.Format(strTmpSql, TableName);

            return ExcuteNonQuery(
                strSql, entity, CommandType.Text);
        }


    }
}
