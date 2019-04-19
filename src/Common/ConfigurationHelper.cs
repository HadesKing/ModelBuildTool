using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Common
{

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
        /// 获取配置信息
        /// 如果key为null或者空，则返回空值
        /// </summary>
        /// <param name="argKeyName">key的名称</param>
        /// <param name="argDefaultValue">key为空或者没有配置时的默认值</param>
        /// <returns></returns>
        public static String GetValue(String argKeyName, String argDefaultValue = null)
        {
            String result = argDefaultValue;
            if (!String.IsNullOrWhiteSpace(argKeyName)
                && DefaultConfiguration.GetSection(argKeyName).Exists()
                )
            {
                result = DefaultConfiguration.GetSection(argKeyName).Value;
            }
            return result;
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

        //public static void SetBasePath()
        //{

        //}

        //public static void AddJsonFile(String argJsonFilePath)
        //{
        //    ConfigurationBuilder.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        //}


    }
}
