using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Manager
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            /*
             * CORS 跨域访问
             * 资料：
             * http://www.cnblogs.com/xishuai/p/aspnet-core-cors.html
             * 需要引用：Microsoft.Extensions.DependencyInjection 
             */
            services.AddCors(o =>
                o.AddPolicy("*",
                    builder => builder
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowAnyOrigin()
                        .AllowCredentials()
                ));

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            #region 【Session】
            /*
             * 说明：
             * 资料：https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/app-state?view=aspnetcore-2.2#cookies
             */
            //添加Session
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {

                //options.IdleTimeout = TimeSpan.FromSeconds(10); // Set a short timeout for easy testing.
                options.Cookie.HttpOnly = true;
            });
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;      //不要将这里设置为true，否则请求中将不会有Cookie
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            #endregion

            /*
             * AddTransient、AddSingleton、AddScoped的区别
             * 资料：
             * https://www.cnblogs.com/AnAng/p/9370913.html
             * 
             * 权重：
             * AddSingleton→AddTransient→AddScoped
             * AddSingleton的生命周期：
             * 项目启动-项目关闭   相当于静态类  只会有一个  
             * AddScoped的生命周期：
             * 请求开始-请求结束  在这次请求中获取的对象都是同一个 
             * AddTransient的生命周期：
             * 请求获取-（GC回收-主动释放） 每一次获取的对象都不是同一个
             * 
             */
            services.AddTransient<Util.JsonSerialize.IJsonSerialize, Util.JsonSerialize.NewtonsoftJsonSerialize>();
            services.AddTransient<Log.ILog, Log.Log4NetLogger>();
                       
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            /*
             * 程序报错处理
             * 资料：
             * https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/error-handling?view=aspnetcore-2.2
             */
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                /*
                 * 启用常见错误状态代码的默认纯文本处理程序
                 * 资料：
                 * https://docs.microsoft.com/zh-cn/dotnet/api/microsoft.aspnetcore.builder.statuscodepagesextensions.usestatuscodepages?view=aspnetcore-2.2
                 * 使用方式资料：
                 * https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/error-handling?view=aspnetcore-2.2
                 */
                app.UseStatusCodePages();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            //app.UseMvc();
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=ModelBuilder}/{action=Index}/{id?}");
            });


        }
    }
}
