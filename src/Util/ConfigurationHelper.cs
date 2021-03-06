﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;

namespace Util
{
    /* Copyright:dx.com
     *
     * Autor: xx
     * Create Time: xx
     *
     * Rewriter: liudi
     * Rewriter Time: 2018.10.26
     * Description: xx
     *
     * Rewriter: xx
     * Rewriter Time: xx
     * Description: xx
     * 
     * 
     * **/

    /// <summary>
    /// 配置帮助类
    /// </summary>
    public sealed class ConfigurationHelper
    {
        private static IConfigurationBuilder ConfigurationBuilder = null;
        private static IConfigurationRoot DefaultConfiguration = null;
        static ConfigurationHelper()
        {
            GetDefaultConfiguration();
        }

        /// <summary>
        /// 获取默认配置
        /// </summary>
        /// <returns></returns>
        public static IConfigurationRoot GetDefaultConfiguration()
        {
            ConfigurationBuilder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddJsonFile($"appsettings.Development.json", optional: true);
            DefaultConfiguration = ConfigurationBuilder.Build();

            return DefaultConfiguration;
        }

        /// <summary>
        /// 创建实例
        /// </summary>
        /// <param name="argFilePath"></param>
        public static IConfiguration CreateInstance(String argFilePath)
        {
            //IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            IConfiguration configuration = null;
            if (!String.IsNullOrWhiteSpace(argFilePath) && System.IO.File.Exists(argFilePath))
            {
                String strFilePath = argFilePath.Replace("/", "\\");
                Int32 lastIndex = strFilePath.LastIndexOf('\\');
                String strDirectoryPath = strFilePath.Substring(0, lastIndex);
                String strFileName = strFilePath.Substring(lastIndex);
                configuration = new ConfigurationBuilder()
                    .SetBasePath(strDirectoryPath)
                    .AddJsonFile(strFileName, false, true)
                    .Build();
                
            }
            
            return configuration;
        }

        /// <summary>
        /// 创建实例
        /// </summary>
        /// <param name="argFilePath"></param>
        public static IConfiguration CreateInstance(String argBasePath, IEnumerable<String> argFileNames)
        {
            //IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            if (null != argFileNames && !String.IsNullOrWhiteSpace(argBasePath))
            {
                //configuration = new ConfigurationBuilder()
                //    .SetBasePath(strDirectoryPath)
                //    .AddJsonFile(strFileName, false, true)
                //    .Build();

                configurationBuilder.SetBasePath(argBasePath);
                foreach (String tmp in argFileNames)
                {
                    configurationBuilder.AddJsonFile(tmp, true, true);
                }

            }

            return configurationBuilder.Build();
        }

        /// <summary>
        /// 获取值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="argFilePath">json文件路径</param>
        /// <param name="argNodePath"></param>
        /// <returns></returns>
        public static T GetValue<T>(String argFilePath, String argNodePath) where T : class
        {
            IConfiguration configuration = CreateInstance(argFilePath);

            T t = null;
            if (null != configuration)
            {
                t = configuration.GetValue<T>(argNodePath);
            }
            return t;
        }

        /// <summary>
        /// 获取值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="configuration">配置信息</param>
        /// <param name="argNodePath"></param>
        /// <returns></returns>
        public static T GetValue<T>(IConfiguration configuration ,String argNodePath) where T : class
        {
            if (null == configuration || String.IsNullOrWhiteSpace(argNodePath)) return null;

            T t = null;
            if (null != configuration)
            {
                t = configuration.GetValue<T>(argNodePath);
            }
            return t;
        }

        /// <summary>
        /// 获取配置信息
        /// 如果key为null或空或没有获取到值，则返回 T（返回值）的默认值 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="argKeyName">key</param>
        /// <returns></returns>
        public static T GetValue<T>(String argKeyName)
        {
            if (!String.IsNullOrWhiteSpace(argKeyName)
                && DefaultConfiguration.GetSection(argKeyName).Exists()
                )
            {
                return DefaultConfiguration.GetSection(argKeyName).Get<T>();
            }
            return default(T);
        }

    }
}
