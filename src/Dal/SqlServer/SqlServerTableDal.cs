using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Dal.SqlServer
{
    public sealed class SqlServerTableDal : BaseSqlServerDal
    {
        protected override string TableName => throw new NotImplementedException();

        /// <summary>
        /// 获取所有数据库表名称
        /// </summary>
        /// <param name="argDbConnectString">数据库连接字符串</param>
        public IList<String> Get(String argDbConnectString, String argDbName)
        {
            IList<String> list = null;
            //1. sql
            /*
             * --获取所有表名
             * --XType='U':表示所有用户表;
             * --XType='S':表示所有系统表;
             */
            String strTmpSql = "SELECT name FROM {0}..sysobjects Where xtype='U' ";
            String strSql = String.Format(strTmpSql, argDbName);
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
        /// 获取所有数据库名称
        /// </summary>
        /// <param name="argDbConnectString">数据库连接字符串</param>
        /// <param name="argTableName">表名称</param>
        public IList<Model.SqlServer.SqlServerTableColumnInfo> GetColumns(String argDbConnectString, String argTableName)
        {
            IList<Model.SqlServer.SqlServerTableColumnInfo> list = null;
            //1. sql
            /*
             * --获取所有表名
             * --XType='U':表示所有用户表;
             * --XType='S':表示所有系统表;
             */
            String strTmpSql = @"
SELECT  
	CASE WHEN a.colorder=1 THEN d.name ELSE '' END AS 'TableName', 
	CASE WHEN a.colorder=1 THEN isnull(f.value,'') ELSE '' END AS 'TableDescription',
	a.colorder AS 'ColumnSortNumber', 
	a.name AS 'ColumnName', 
	b.name AS 'ColumnDataType', 
	COLUMNPROPERTY(a.id,a.name,'PRECISION') AS 'DataLength', 
	ISNULL(e.text,'') AS 'DefaultValue', 
	ISNULL(g.[value],'') AS 'ColumnDescription',
	a.isnullable
FROM syscolumns a 
LEFT JOIN systypes b on a.xtype=b.xusertype 
INNER JOIN sysobjects d on a.id=d.id and d.xtype='U' and d.name<> 'dtproperties' 
LEFT JOIN syscomments e on a.cdefault=e.id 
LEFT JOIN sys.extENDed_properties g on a.id=g.major_id and a.colid=g.minor_id 
LEFT JOIN sys.extENDed_properties f on d.id=f.major_id and f.minor_id =0 
WHERE d.name='{0}'
ORDER BY a.id,a.colorder

";
            String strSql = String.Format(strTmpSql, argTableName);
            //2. 校验sql
            ValidateSqlText(strSql);
            DbConnectString = argDbConnectString;
            //3. 执行SQL
            using (IDbConnection dbConnection = GetDbConnection())
            {
                list = dbConnection.Query<Model.SqlServer.SqlServerTableColumnInfo>(strSql).AsList();

                Dispose(dbConnection);
            }
            return list;
        }


    }
}
