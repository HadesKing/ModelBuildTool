using System;
using System.Collections.Generic;
using System.Text;

namespace IDal.DbConfig
{

    /// <summary>
    /// 数据库连接字符串管理类
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <author>刘迪</author>
    /// <createtime>2019-04-30</createtime>
    /// <updator></updator>
    /// <updatetime></updatetime>
    /// <description></description>
    public interface IDbConnectionStringDal : IAdd<Model.DbConfig.DbConnectionString>, IDelete<Model.DbConfig.DbConnectionString>
    {



    }
}
