using System;
using System.Collections.Generic;
using System.Text;

namespace DataBll.SqlServer
{
    public sealed class SqlServerDatabaseDataBll
    {

        private Dal.SqlServer.SqlServerDatabaseDal dal = new Dal.SqlServer.SqlServerDatabaseDal();
        
        /// <summary>
        /// 获取所有数据库名称
        /// </summary>
        /// <param name="argDbConnectString">数据库连接字符串</param>
        public IList<String> Get(String argDbConnectString)
        {
            if (String.IsNullOrWhiteSpace(argDbConnectString)) return null;
            return dal.Get(argDbConnectString);
        }

    }
}
