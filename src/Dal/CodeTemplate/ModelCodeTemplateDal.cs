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

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="argDbConnectString"></param>
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
        public Int32 Update<ModelCodeTemplate>(ModelCodeTemplate entity)
        {
            String strTmpSql = @"
UPDATE 
  {0}
SET
  `Name` = @Name,
  `AuthorInfo` = @AuthorInfo,
  `UsingInfo` = @UsingInfo,
  `NamespaceInfo` = @NamespaceInfo,
  `ClassInfo` = @ClassInfo,
  `PropertyInfo` = @PropertyInfo,
  `IsEnable` = @IsEnable,
  `LastUpdateTime` = @LastUpdateTime,
  `UpdateBy` = @UpdateBy
WHERE `Identity` = @Identity;
";
            String strSql = String.Format(strTmpSql, TableName);

            return ExcuteNonQuery(
                strSql, entity, CommandType.Text);
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
        public Int32 UpdateIsEnable<ModelCodeTemplate>(ModelCodeTemplate entity)
        {
            String strTmpSql = @"
UPDATE 
  {0}
SET
  `IsEnable` = @IsEnable
WHERE `Identity` = @Identity;
";
            String strSql = String.Format(strTmpSql, TableName);

            return ExcuteNonQuery(
                strSql, entity, CommandType.Text);
        }

    }
}
