using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerWeb.ConfigService
{
    public abstract class BaseDi
    {

        protected IConfiguration Configuration { get; set; }

        protected IServiceCollection Services { get; set; }

        public BaseDi(IConfiguration configuration, IServiceCollection services)
        {
            Configuration = configuration;
            Services = services;
        }

        /// <summary>
        /// 初始化配置
        /// </summary>
        public abstract void Init();

    }
}
