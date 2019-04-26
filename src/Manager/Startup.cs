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
             * CORS �������
             * ���ϣ�
             * http://www.cnblogs.com/xishuai/p/aspnet-core-cors.html
             * ��Ҫ���ã�Microsoft.Extensions.DependencyInjection 
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
            #region ��Session��
            /*
             * ˵����
             * ���ϣ�https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/app-state?view=aspnetcore-2.2#cookies
             */
            //���Session
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {

                //options.IdleTimeout = TimeSpan.FromSeconds(10); // Set a short timeout for easy testing.
                options.Cookie.HttpOnly = true;
            });
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;      //��Ҫ����������Ϊtrue�����������н�������Cookie
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            #endregion

            /*
             * AddTransient��AddSingleton��AddScoped������
             * ���ϣ�
             * https://www.cnblogs.com/AnAng/p/9370913.html
             * 
             * Ȩ�أ�
             * AddSingleton��AddTransient��AddScoped
             * AddSingleton���������ڣ�
             * ��Ŀ����-��Ŀ�ر�   �൱�ھ�̬��  ֻ����һ��  
             * AddScoped���������ڣ�
             * ����ʼ-�������  ����������л�ȡ�Ķ�����ͬһ�� 
             * AddTransient���������ڣ�
             * �����ȡ-��GC����-�����ͷţ� ÿһ�λ�ȡ�Ķ��󶼲���ͬһ��
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
             * ���򱨴���
             * ���ϣ�
             * https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/error-handling?view=aspnetcore-2.2
             */
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                /*
                 * ���ó�������״̬�����Ĭ�ϴ��ı��������
                 * ���ϣ�
                 * https://docs.microsoft.com/zh-cn/dotnet/api/microsoft.aspnetcore.builder.statuscodepagesextensions.usestatuscodepages?view=aspnetcore-2.2
                 * ʹ�÷�ʽ���ϣ�
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
