using System;
using System.Collections.Generic;
using System.Text;

namespace DataBll.MySql
{
    /// <summary>
    /// MySql 表 数据业务逻辑处理层
    /// </summary>
    public sealed class MySqlTableDataBll : IDataBll.MySql.IMySqlTableDataBll
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="argMySqlTableDal"></param>
        public MySqlTableDataBll(IDal.MySql.IMySqlTableDal argMySqlTableDal)
        {
            MySqlTableDal = argMySqlTableDal;
        }

        /// <summary>
        /// 
        /// </summary>
        private IDal.MySql.IMySqlTableDal MySqlTableDal { get; set; }
        
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
            if (String.IsNullOrEmpty(argDbConnectString)
                || String.IsNullOrEmpty(argDbName)
            )
                return null;

            return MySqlTableDal.Get(argDbConnectString, argDbName);
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
            if (String.IsNullOrEmpty(argDbConnectString) 
                || String.IsNullOrEmpty(argDbName)
                || String.IsNullOrEmpty(argTableName)
            )
                return null;

            return MySqlTableDal.GetColumnInfo(argDbConnectString, argDbName, argTableName);
        }


    }
}
