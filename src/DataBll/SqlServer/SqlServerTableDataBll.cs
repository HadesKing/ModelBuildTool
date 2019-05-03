using System;
using System.Collections.Generic;
using System.Text;

namespace DataBll.SqlServer
{
    /// <summary>
    /// SqlServer 表 数据业务逻辑处理层
    /// </summary>
    public sealed class SqlServerTableDataBll : IDataBll.SqlServer.ISqlServerTableDataBll
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="argSqlServerTableDal"></param>
        public SqlServerTableDataBll(IDal.SqlServer.ISqlServerTableDal argSqlServerTableDal)
        {
            SqlServerTableDal = argSqlServerTableDal;
        }

        private IDal.SqlServer.ISqlServerTableDal SqlServerTableDal { get; set; }
        
        /// <summary>
        /// 获取所有数据库表名称
        /// </summary>
        /// <param name="argDbConnectString">数据库连接字符串</param>
        public IList<String> Get(String argDbConnectString, String argDbName)
        {
            if (String.IsNullOrWhiteSpace(argDbConnectString) || String.IsNullOrWhiteSpace(argDbName)) return null;
            return SqlServerTableDal.Get(argDbConnectString, argDbName);
        }
        
        /// <summary>
        /// 获取所有数据库名称
        /// </summary>
        /// <param name="argDbConnectString">数据库连接字符串</param>
        /// <param name="argTableName">表名称</param>
        public IList<Model.SqlServer.SqlServerTableColumnInfo> GetColumns(String argDbConnectString, String argTableName)
        {
            if (String.IsNullOrWhiteSpace(argDbConnectString) || String.IsNullOrWhiteSpace(argTableName)) return null;
            return SqlServerTableDal.GetColumns(argDbConnectString, argTableName);
        }

    }
}
