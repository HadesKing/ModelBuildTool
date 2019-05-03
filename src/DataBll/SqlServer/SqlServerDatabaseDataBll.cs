using System;
using System.Collections.Generic;
using System.Text;

namespace DataBll.SqlServer
{
    /// <summary>
    /// SqlServer 数据库 数据业务逻辑处理层
    /// </summary>
    public sealed class SqlServerDatabaseDataBll : IDataBll.SqlServer.ISqlServerDatabaseDataBll
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="argSqlServerDatabaseDal"></param>
        public SqlServerDatabaseDataBll(IDal.SqlServer.ISqlServerDatabaseDal argSqlServerDatabaseDal)
        {
            SqlServerDatabaseDal = argSqlServerDatabaseDal;
        }
        private IDal.SqlServer.ISqlServerDatabaseDal SqlServerDatabaseDal { get; set; }
        
        /// <summary>
        /// 获取所有数据库名称
        /// </summary>
        /// <param name="argDbConnectString">数据库连接字符串</param>
        public IList<String> Get(String argDbConnectString)
        {
            if (String.IsNullOrWhiteSpace(argDbConnectString)) return null;
            return SqlServerDatabaseDal.Get(argDbConnectString);
        }

    }
}
