using System;
using System.Collections.Generic;
using System.Text;

namespace IDataBll.SqlServer
{
    /// <summary>
    /// SqlServer 表 数据访问层
    /// </summary>
    public interface ISqlServerTableDataBll
    {
        /// <summary>
        /// 获取所有数据库表名称
        /// </summary>
        /// <param name="argDbConnectString">数据库连接字符串</param>
        /// <returns></returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-03</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        IList<String> Get(String argDbConnectString, String argDbName);

        /// <summary>
        /// 获取所有数据库名称
        /// </summary>
        /// <param name="argDbConnectString">数据库连接字符串</param>
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
        IList<Model.SqlServer.SqlServerTableColumnInfo> GetColumns(String argDbConnectString, String argTableName);

    }
}
