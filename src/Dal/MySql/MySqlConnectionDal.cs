using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;

namespace Dal.MySql
{
    /// <summary>
    /// MySqlConnection 数据访问层
    /// </summary>
    public sealed class MySqlConnectionDal : BaseMySqlDal
    {
        protected override string TableName => "";

        /// <summary>
        /// 验证数据库连接字符串是否正常
        /// </summary>
        /// <param name="argDbConnectString">数据库连接字符串</param>
        public IList<String> ValidateDbConnectString(String argDbConnectString)
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

    }
}
