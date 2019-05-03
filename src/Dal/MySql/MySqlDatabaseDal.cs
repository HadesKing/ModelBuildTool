using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Dal.MySql
{

    /// <summary>
    /// MySql 数据库 数据访问层
    /// </summary>
    public sealed class MySqlDatabaseDal : BaseMySqlDal, IDal.MySql.IMySqlDatabaseDal
    {
        public MySqlDatabaseDal()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public MySqlDatabaseDal(String dbConnectString)
        {
            DbConnectString = dbConnectString;
        }

        protected override string TableName => "";

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
        public IList<String> Get(String argDbConnectString)
        {
            IList<String> list = null;
            //1. sql
            String strSql = "SHOW DATABASES;";
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
        public IList<String> GetTableName(String argDbConnectString, String argDbName)
        {
            IList<String> list = null;
            //1. sql
            String strSql = "SHOW TABLES;";
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
