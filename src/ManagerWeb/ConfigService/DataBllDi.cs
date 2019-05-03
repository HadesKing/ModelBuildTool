using DataBll.CodeTemplate;
using IDataBll.CodeTemplate;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ManagerWeb.ConfigService
{

    /// <summary>
    /// DataBll Di 依赖注入 配置
    /// </summary>
    public sealed class DataBllDi : BaseDi
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="services"></param>
        public DataBllDi(IConfiguration configuration, IServiceCollection services) : base(configuration, services)
        {
        }

        /// <summary>
        /// 数据业务逻辑处理层 初始化配置
        /// </summary>
        public override void Init()
        {

            //Services.AddTransient<IDataBLL.User.IUserInfoDataBll, DataBLL.User.UserInfoDataBll>();      //用户信息管理
            //ServiceProvider serviceProvider = Services.BuildServiceProvider();
            //IDal.CodeTemplate.IModelCodeTemplateDal modelCodeTemplateDal = serviceProvider.GetService<IDal.CodeTemplate.IModelCodeTemplateDal>();

            //Services.AddTransient<IModelCodeTemplateDataBll, ModelCodeTemplateDataBll>(
            //    x => new ModelCodeTemplateDataBll(modelCodeTemplateDal)
            //    );

            Services.AddTransient<IModelCodeTemplateDataBll, ModelCodeTemplateDataBll>();
            Services.AddTransient<IDataBll.MySql.IMySqlDatabaseDataBll, DataBll.MySql.MySqlDatabaseDataBll>();
            Services.AddTransient<IDataBll.MySql.IMySqlTableDataBll, DataBll.MySql.MySqlTableDataBll>();
            Services.AddTransient<IDataBll.SqlServer.ISqlServerDatabaseDataBll, DataBll.SqlServer.SqlServerDatabaseDataBll>();
            Services.AddTransient<IDataBll.SqlServer.ISqlServerTableDataBll, DataBll.SqlServer.SqlServerTableDataBll>();

        }

    }
}
