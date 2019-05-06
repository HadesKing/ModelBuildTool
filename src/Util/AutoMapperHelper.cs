using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace Util
{
    /// <summary>
    /// AutoMapper 帮助类
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <author>刘迪</author>
    /// <createtime>2019-05-06</createtime>
    /// <updator></updator>
    /// <updatetime></updatetime>
    /// <description></description>
    public sealed class AutoMapperHelper
    {
        /// <summary>
        /// 实体映射配置器
        /// </summary>
        private static MapperConfiguration MapperConfiguration { get; set; }

        /// <summary>
        /// 映射管理者
        /// </summary>
        private static IMapper Mapper { get; set; }

        /// <summary>
        /// 创建实体映射配置器
        /// </summary>
        /// <param name="argProfiles">实体映射文件</param>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-06</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        private static void BuildMapperConfiguration(IEnumerable<Profile> argProfiles)
        {
            MapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfiles(argProfiles);
                cfg.Advanced.AllowAdditiveTypeMapCreation = true;       //允许不同的映射文件中存在相同的映射
                
            });
        }

        /// <summary>
        /// 初始化实体映射器
        /// </summary>
        /// <param name="argProfiles">实体映射文件</param>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-06</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        public static void Init(IEnumerable<Profile> argProfiles)
        {
            BuildMapperConfiguration(argProfiles);
            Mapper = MapperConfiguration.CreateMapper();
        }

        /// <summary>
        /// 获取目标对象
        /// </summary>
        /// <typeparam name="TSource">源对象</typeparam>
        /// <typeparam name="TDest">映射的目标对象</typeparam>
        /// <param name="source">源对象</param>
        /// <returns></returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-06</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        public static TDest Get<TSource, TDest>(TSource source)
        {
            return Mapper.Map<TSource, TDest>(source);
        }

        /// <summary>
        /// 获取目标对象
        /// </summary>
        /// <typeparam name="TSource">源对象</typeparam>
        /// <typeparam name="TDest">映射的目标对象</typeparam>
        /// <param name="source">源对象</param>
        /// <returns></returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-06</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        public static TDest[] Get<TSource, TDest>(TSource[] source)
        {
            return (TDest[])Mapper.Map(source, typeof(TSource[]), typeof(TDest[]));
        }


    }
}
