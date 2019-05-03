using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ManagerWeb.ConfigService
{

    /// <summary>
    /// 业务逻辑处理层 di 
    /// </summary>
    public sealed class BllDi : BaseDi
    {

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="services"></param>
        public BllDi(IConfiguration configuration, IServiceCollection services) : base(configuration, services)
        {
        }

        /// <summary>
        /// 业务逻辑处理层 初始化配置
        /// </summary>
        public override void Init()
        {

            Services.AddTransient<Bll.CodeTemplate.ModelCodeTemplateBll>();

        }

    }
}
