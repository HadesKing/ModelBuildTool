using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;

namespace Dal
{
    /// <summary>
    /// 数据库访问层 基类
    /// </summary>
    public abstract class BaseDal
    {

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-01</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        protected String DbConnectString { get; set; }

        /// <summary>
        /// SQL语句操作命令执行超时时间
        /// 说明：
        ///     默认5分钟
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-01</createtime>
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
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-01</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        protected abstract String TableName { get; }

        /// <summary>
        /// 校验 sql 语句
        /// </summary>
        /// <param name="argSql">sql 语句</param>
        /// <returns></returns>
        /// <remarks>
        ///     所有不符合规范的SQL，都应以错误的形式抛出，防止程序继续运行
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-01</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        protected virtual bool ValidateSqlText(String argSql)
        {
            if (String.IsNullOrWhiteSpace(argSql))
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

        /// <summary>
        /// 获取数据库连接
        /// </summary>
        /// <param name="argIsOpen">是否打开连接</param>
        /// <returns></returns>
        protected abstract IDbConnection GetDbConnection(bool argIsOpen = true);

        /// <summary>
        /// 释放资源
        /// </summary>
        /// <param name="dbConnection">数据库连接</param>
        protected void Dispose(IDbConnection dbConnection)
        {
            if (null != dbConnection && dbConnection.State != ConnectionState.Closed)
                dbConnection.Close();

        }


        /// <summary>
        /// 执行SQL语句
        /// 说明：
        ///     也可以执行存储过程
        /// </summary>
        /// <typeparam name="TParam">参数类型</typeparam>
        /// <param name="sql">待执行SQL语句</param>
        /// <param name="param">参数</param>
        /// <param name="commandType">命令类型</param>
        /// <returns></returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-01</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        public Int32 ExcuteNonQuery<TParam>(
            String sql, TParam param, CommandType commandType = CommandType.Text
            )
        {
            Int32 result = 0;
            ValidateSqlText(sql);      //校验SQL语句
            using (IDbConnection dbConnection = GetDbConnection())
            {
                result = dbConnection.Execute(sql, param, null, CommandTimeOut, commandType);

                Dispose(dbConnection);
            }

            return result;
        }

        /// <summary>
        /// 查询列表
        /// </summary>
        /// <typeparam name="TParam">查询参数</typeparam>
        /// <typeparam name="TEntity">查询实体结果</typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="param">查询参数</param>
        /// <param name="commandType">查询命令类型</param>
        /// <returns></returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-01</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        public IList<TEntity> Query<TParam, TEntity>(
            String sql, TParam param, CommandType commandType = CommandType.Text
            ) where TEntity : class where TParam : class
        {
            IList<TEntity> result = null;
            ValidateSqlText(sql);      //校验SQL语句
            using (IDbConnection dbConnection = GetDbConnection())
            {
                result = dbConnection.Query<TEntity>(
                    sql, param, null
                    , true, CommandTimeOut, commandType
                ).ToList();

                Dispose(dbConnection);
            }

            return result;
        }

        /// <summary>
        /// 查询 一条 记录
        /// </summary>
        /// <typeparam name="TParam">查询参数</typeparam>
        /// <typeparam name="TEntity">查询实体结果</typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="param">查询参数</param>
        /// <param name="commandType">查询命令类型</param>
        /// <returns></returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-01</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        public TEntity QueryFirstOrDefault<TParam, TEntity>(
            String sql, TParam param
            , CommandType commandType = CommandType.Text
            ) where TEntity : class where TParam : class
        {
            TEntity result = null;
            ValidateSqlText(sql);      //校验SQL语句
            using (IDbConnection dbConnection = GetDbConnection())
            {
                result = dbConnection.QueryFirstOrDefault<TEntity>(
                    sql, param, null, CommandTimeOut, commandType
                );

                Dispose(dbConnection);
            }

            return result;
        }

    }
}
