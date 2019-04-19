using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Dal.MySql
{

    public sealed class MySqlTableDal : BaseMySqlDal
    {
        /// <summary>
        /// 表名称
        /// </summary>
        protected override string TableName => throw new NotImplementedException();


        /// <summary>
        /// 获取表的详细信息
        /// </summary>
        /// <param name="argDbConnectString">数据库连接字符串</param>
        /// <param name="argDbName">数据库名称</param>
        /// <param name="argTableName">表名称</param>
        /// <returns></returns>
        public IList<Model.MySql.MySqlTableInfo> Get(
            String argDbConnectString
            , String argDbName)
        {
            IList<Model.MySql.MySqlTableInfo> list = null;
            //1. sql
            String strTmpSql = "SELECT * FROM information_schema.tables WHERE TABLE_SCHEMA = '{0}';";
            String strSql = String.Format(strTmpSql, argDbName);
            //2. 校验sql
            ValidateSqlText(strSql);
            DbConnectString = argDbConnectString;
            //3. 执行SQL
            using (IDbConnection dbConnection = GetDbConnection())
            {
                list = dbConnection.Query<Model.MySql.MySqlTableInfo>(strSql).ToList();

                Dispose(dbConnection);
            }
            return list;
        }

        /// <summary>
        /// 获取表的列信息
        /// </summary>
        /// <param name="argDbConnectString">数据库连接字符串</param>
        /// <param name="argDbName">数据库名称</param>
        /// <param name="argTableName">表名称</param>
        /// <returns></returns>
        public IList<Model.MySql.MySqlTableColumnInfo> GetColumnInfo(
            String argDbConnectString
            , String argDbName
            , String argTableName)
        {
            IList<Model.MySql.MySqlTableColumnInfo> list = null;
            //1. sql
            String strTmpSql = "SELECT * FROM information_schema.columns WHERE TABLE_SCHEMA = '{0}' AND table_name = '{1}';";
            String strSql = String.Format(strTmpSql, argDbName, argTableName);
            //2. 校验sql
            ValidateSqlText(strSql);
            DbConnectString = argDbConnectString;
            //3. 执行SQL
            using (IDbConnection dbConnection = GetDbConnection())
            {
                list = dbConnection.Query<Model.MySql.MySqlTableColumnInfo>(strSql).AsList();

                Dispose(dbConnection);
            }
            return list;
        }


    }
}
