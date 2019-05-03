using System;
using System.Collections.Generic;
using System.Text;

namespace IDal.MySql
{

    /// <summary>
    /// MySql 表 接口数据访问处理层
    /// </summary>
    public interface IMySqlTableDal
    {

        /// <summary>
        /// 获取表的详细信息
        /// </summary>
        /// <param name="argDbConnectString">数据库连接字符串</param>
        /// <param name="argDbName">数据库名称</param>
        /// <param name="argTableName">表名称</param>
        /// <returns></returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-03</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        IList<Model.MySql.MySqlTableInfo> Get(
            String argDbConnectString
            , String argDbName);

        /// <summary>
        /// 获取表的列信息
        /// </summary>
        /// <param name="argDbConnectString">数据库连接字符串</param>
        /// <param name="argDbName">数据库名称</param>
        /// <param name="argTableName">表名称</param>
        /// <returns></returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-03</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        IList<Model.MySql.MySqlTableColumnInfo> GetColumnInfo(
            String argDbConnectString
            , String argDbName
            , String argTableName);

    }
}
