using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Dal
{

    /// <summary>
    /// ModelBuild 数据库访问层
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <author>刘迪</author>
    /// <createtime>2019-05-01</createtime>
    /// <updator></updator>
    /// <updatetime></updatetime>
    /// <description></description>
    public abstract class BaseModelBuildDal : BaseDal
    {
        /// <summary>
        /// 获取数据库连接
        /// </summary>
        /// <param name="argIsOpen">是否打开连接</param>
        /// <returns></returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-01</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        protected override IDbConnection GetDbConnection(bool argIsOpen = true)
        {
            IDbConnection dbConnection = null;
            try
            {
                if (String.IsNullOrWhiteSpace(DbConnectString))
                    throw new Exception("The database connect string is null or empty.");
                dbConnection = new MySqlConnection(DbConnectString);
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
