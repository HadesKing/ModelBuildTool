using System;
using System.Collections.Generic;
using System.Text;

namespace IDataBll.SqlServer
{
    /// <summary>
    /// SqlServer 数据库 数据访问层
    /// </summary>
    public interface ISqlServerDatabaseDataBll
    {
        /// <summary>
        /// 获取所有数据库名称
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
        IList<String> Get(String argDbConnectString);

    }
}
