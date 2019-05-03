using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Dal.SqlServer
{
    /// <summary>
    /// SqlServer 数据库 数据访问层
    /// </summary>
    public sealed class SqlServerDatabaseDal : BaseSqlServerDal, IDal.SqlServer.ISqlServerDatabaseDal
    {
        protected override string TableName => "";

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
        public IList<String> Get(String argDbConnectString)
        {
            IList<String> list = null;
            //1. sql
            //String strSql = "SELECT name FROM  master..sysdatabases WHERE name NOT IN ( 'master', 'model', 'msdb', 'tempdb', 'northwind','pubs' );";
            String strSql = "SELECT name FROM master..sysdatabases ";

            //2. 校验sql
            ValidateSqlText(strSql);
            DbConnectString = argDbConnectString;
            //3. 执行SQL
            using (IDbConnection dbConnection = GetDbConnection())
            {
                list = dbConnection.Query<String>(strSql).AsList();

                Dispose(dbConnection);
            }
            return list;
        }


    }
}
