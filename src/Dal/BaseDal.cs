using System;
using System.Data;

namespace Dal
{
    public abstract class BaseDal
    {

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        /// <remarks></remarks>
        /// <author>liudi</author>
        /// <createtime>2018-12-13</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        protected String DbConnectString { get; set; }

        /// <summary>
        /// SQL语句操作命令执行超时时间
        /// 说明：
        ///     默认5分钟
        /// </summary>
        /// <remarks></remarks>
        /// <author>liudi</author>
        /// <createtime>2018-12-13</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        protected virtual Int32 CommandTimeOut
        {
            get { return 300; }
        }

        /// <summary>
        /// 需要操作的表名称
        /// </summary>
        /// <remarks></remarks>
        /// <author>liudi</author>
        /// <createtime>2018-12-13</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        protected abstract String TableName { get; }

        /// <summary>
        /// 校验 sql 语句
        /// </summary>
        /// <param name="argSql"></param>
        /// <returns></returns>
        protected virtual bool ValidateSqlText(String argSql)
        {
            if(String.IsNullOrWhiteSpace(argSql))
            {
                throw new Exception("The excute sql is null or empty.");
            }

            String strTmpSql = argSql.ToLower();
            //如果sql 语句中有select 必须要包含 where，否则抛出错误
            if (argSql.IndexOf("select") > -1 && argSql.IndexOf("where") < 0)
            {
                throw new Exception("The select sql is must contain the where clause.");
            }
            //如果sql 语句中有 delete 必须要包含 where，否则抛出错误
            if (argSql.IndexOf("update") > -1 && argSql.IndexOf("where") < 0)
            {
                throw new Exception("The update sql is must contain the where clause.");
            }
            //如果sql 语句中有 delete 必须要包含 where，否则抛出错误
            if (argSql.IndexOf("delete") > -1 && argSql.IndexOf("where") < 0)
            {
                throw new Exception("The delete sql is must contain the where clause.");
            }

            return true;
        }

        protected abstract IDbConnection GetDbConnection(bool argIsOpen = true);

        /// <summary>
        /// 释放资源
        /// </summary>
        /// <param name="dbConnection"></param>
        protected void Dispose(IDbConnection dbConnection)
        {
            if (null != dbConnection && dbConnection.State != ConnectionState.Closed)
                dbConnection.Close();

        }

    }
}
