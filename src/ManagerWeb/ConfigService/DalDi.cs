using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerWeb.ConfigService
{

    /// <summary>
    /// dal 依赖注入 配置
    /// </summary>
    public sealed class DalDi : BaseDi
    {
        public DalDi(IConfiguration configuration, IServiceCollection services) : base(configuration, services)
        {
        }

        /// <summary>
        /// 数据访问层 初始化配置
        /// </summary>
        public override void Init()
        {


            //var appSettings = Configuration.GetSection("DbConnection");
            //IServiceCollection services = Services.Configure<List<Models.Common.DbConnectStringViewModel>>(appSettings);

            String strMasterDbType = Configuration["DbConnection:Master:DbType"];
            String strMasterConnectString = Configuration["DbConnection:Master:ConnectString"];
            if (null == strMasterDbType) throw new MissingMemberException(String.Format("The config {0} is null", "DbConnection:Master:DbType"));
            if (null == strMasterConnectString) throw new MissingMemberException(String.Format("The config {0} is null", "DbConnection:Master:ConnectString"));

            //DAL.User.UserInfoDal userInfoDal = new DAL.User.UserInfoDal(strMasterConnectString);
            //Services.AddTransient<IDAL.User.IUserInfoDal, DAL.User.UserInfoDal>(x => userInfoDal);      //用户信息管理

            //Dal.CodeTemplate.ModelCodeTemplateDal
            Services.AddTransient<IDal.CodeTemplate.IModelCodeTemplateDal, Dal.CodeTemplate.ModelCodeTemplateDal>(
                x => new Dal.CodeTemplate.ModelCodeTemplateDal(strMasterConnectString)
                );

            Services.AddTransient<IDal.MySql.IMySqlDatabaseDal, Dal.MySql.MySqlDatabaseDal>();
            Services.AddTransient<IDal.MySql.IMySqlTableDal, Dal.MySql.MySqlTableDal>();
            Services.AddTransient<IDal.SqlServer.ISqlServerDatabaseDal, Dal.SqlServer.SqlServerDatabaseDal>();
            Services.AddTransient<IDal.SqlServer.ISqlServerTableDal, Dal.SqlServer.SqlServerTableDal>();

        }

    }
}
