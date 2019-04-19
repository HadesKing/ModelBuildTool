using System;
using System.Collections.Generic;

namespace DataBll.MySql
{

    /// <summary>
    /// MySql 数据库 数据业务逻辑层
    /// </summary>
    public sealed class MySqlDatabaseDataBll
    {

        private Dal.MySql.MySqlDatabaseDal dal = new Dal.MySql.MySqlDatabaseDal();

        /// <summary>
        /// 获取所有数据库信息
        /// </summary>
        /// <param name="argDbConnectString">数据库连接字符串</param>
        public IList<String> Get(String argDbConnectString)
        {
            if (String.IsNullOrEmpty(argDbConnectString)) return null;
            return dal.Get(argDbConnectString);
        }

        /// <summary>
        /// 获取数据库所有表名
        /// </summary>
        /// <param name="argDbConnectString">数据库连接字符串</param>
        /// <param name="argDbName">数据库名称</param>
        /// <returns></returns>
        public IList<String> GetTableName(String argDbConnectString, String argDbName)
        {
            if (String.IsNullOrEmpty(argDbConnectString) || String.IsNullOrEmpty(argDbName)) return null;

            return dal.GetTableName(argDbConnectString, argDbName);
        }

       

    }
}
