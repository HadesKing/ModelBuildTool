using System;
using System.Collections.Generic;
using System.Text;

namespace DataBll.SqlServer
{
    public sealed class SqlServerTableDataBll
    {

        private Dal.SqlServer.SqlServerTableDal dal = new Dal.SqlServer.SqlServerTableDal();
        
        /// <summary>
        /// 获取所有数据库表名称
        /// </summary>
        /// <param name="argDbConnectString">数据库连接字符串</param>
        public IList<String> Get(String argDbConnectString, String argDbName)
        {
            if (String.IsNullOrWhiteSpace(argDbConnectString) || String.IsNullOrWhiteSpace(argDbName)) return null;
            return dal.Get(argDbConnectString, argDbName);
        }
        
        /// <summary>
        /// 获取所有数据库名称
        /// </summary>
        /// <param name="argDbConnectString">数据库连接字符串</param>
        /// <param name="argTableName">表名称</param>
        public IList<Model.SqlServer.SqlServerTableColumnInfo> GetColumns(String argDbConnectString, String argTableName)
        {
            if (String.IsNullOrWhiteSpace(argDbConnectString) || String.IsNullOrWhiteSpace(argTableName)) return null;
            return dal.GetColumns(argDbConnectString, argTableName);
        }

    }
}
