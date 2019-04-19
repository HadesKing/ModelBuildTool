using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    /// <summary>
    /// 缓存帮助类
    /// </summary>
    public sealed class CacheHelper
    {

        private static IMemoryCache m_memoryCache = new MemoryCache(new MemoryCacheOptions() { });

        /// <summary>
        /// 缓存绝对过期时间，在经过一段时间之后过期（无论是否访问过）
        /// </summary>
        ///<param name="key">Cache键值</param>
        ///<param name="value">给Cache[key]赋的值</param>
        ///<param name="minute">minute分钟后绝对过期</param>
        public static void CacheInsertAddMinutes(string key, object value, int minute)
        {
            if (value == null) return;
            m_memoryCache.Set(key, value, new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(minute)));
        }


        /// <summary>
        /// 缓存相对过期，最后一次访问后minute分钟后过期
        /// </summary>
        ///<param name="key">Cache键值</param>
        ///<param name="value">给Cache[key]赋的值</param>
        ///<param name="minute">滑动过期分钟</param>
        public static void CacheInsertFromMinutes(string key, object value, int minute)
        {
            if (value == null) return;
            m_memoryCache.Set(key, value, new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromMinutes(minute)));
        }

        /// <summary>
        /// 设置缓存信息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="expireTimeSeconds"></param>
        public static void Set<T>(String key, T value, Int32 expireTimeSeconds = 60)
        {
            m_memoryCache.Set(key, value, TimeSpan.FromSeconds(expireTimeSeconds));
        }

        /// <summary>
        /// 从缓存中获取信息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T Get<T>(String key)
        {
            return m_memoryCache.Get<T>(key);
        }

    }
}
