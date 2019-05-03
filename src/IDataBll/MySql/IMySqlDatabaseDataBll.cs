using System;
using System.Collections.Generic;
using System.Text;

namespace IDataBll.MySql
{
    /// <summary>
    /// MySql 数据库 数据访问层
    /// </summary>
    public interface IMySqlDatabaseDataBll
    {

        /// <summary>
        /// 获取所有数据库信息
        /// </summary>
        /// <param name="argDbConnectString">数据库连接字符串</param>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-03</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        IList<String> Get(String argDbConnectString);

        /// <summary>
        /// 获取数据库所有表名
        /// </summary>
        /// <param name="argDbConnectString">数据库连接字符串</param>
        /// <param name="argDbName">数据库名称</param>
        /// <returns></returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-03</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        IList<String> GetTableName(String argDbConnectString, String argDbName);

    }
}
