using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Common
{


    /// <summary>
    /// json 序列化 帮助类
    /// </summary>
    public sealed class JsonSerializeHelper
    {

        /// <summary>
        /// 序列化
        /// </summary>
        /// <typeparam name="T">序列化数据类型</typeparam>
        /// <param name="value">待序列化的数据</param>
        /// <returns></returns>
        public static String Serialize<T>(T value)
        {
            return JsonConvert.SerializeObject(value);
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T">返回数据类型</typeparam>
        /// <param name="json">待反序列化的数据</param>
        /// <returns></returns>
        public static T Deserialize<T>(String json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

    }
}
