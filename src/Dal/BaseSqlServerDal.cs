using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Dal
{
    public abstract class BaseSqlServerDal : BaseDal
    {

        /// <summary>
        /// 获取数据库连接
        /// </summary>
        /// <param name="argIsOpen"></param>
        /// <returns></returns>
        protected override IDbConnection GetDbConnection(bool argIsOpen = true)
        {
            IDbConnection dbConnection = null;
            try
            {
                if (String.IsNullOrWhiteSpace(DbConnectString))
                    throw new Exception("The database connect string is null or empty.");
                dbConnection = new SqlConnection(DbConnectString);
                if (argIsOpen)
                    dbConnection.Open();
            }
            catch (Exception ex)
            {
                if (null != dbConnection && dbConnection.State != ConnectionState.Closed)
                    dbConnection.Close();
                throw ex;
            }

            return dbConnection;
        }


    }
}
