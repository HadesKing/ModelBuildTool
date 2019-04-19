using Common.EnumType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common
{
    /// <summary>
    /// 枚举类型帮助类
    /// </summary>
    public sealed class EnumHelper
    {
        /// <summary>
        /// 获取枚举类型
        /// 说明：
        ///     转换失败将返回默认值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumType"></param>
        /// <param name="argValue"></param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static T Get<T>(Type enumType, String argValue, T defaultValue)
        {
            T t;
            try
            {
                t = (T)Enum.Parse(enumType, argValue, true);
            }
            catch
            {
                t = defaultValue;
            }
            return t;
        }

        /// <summary>
        /// 获取枚举列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IList<EnumberCreditType> EnumToList<T>()
        {
            IList<EnumberCreditType> list = new List<EnumberCreditType>();

            foreach (var e in Enum.GetValues(typeof(T)))
            {
                EnumberCreditType m = new EnumberCreditType();
                object[] objArr = e.GetType().GetField(e.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), true);
                if (objArr != null && objArr.Length > 0)
                {
                    DescriptionAttribute da = objArr[0] as DescriptionAttribute;
                    m.Description = da.Description;
                }
                //SetClassification 
                object[] setClassificationArr = e.GetType().GetField(e.ToString()).GetCustomAttributes(typeof(CustomEnumAttribute), true);
                if (setClassificationArr != null && setClassificationArr.Length > 0)
                {
                    CustomEnumAttribute da = setClassificationArr[0] as CustomEnumAttribute;
                    m.Classification = da.Type;
                }
                //Display
                object[] disArr = e.GetType().GetField(e.ToString()).GetCustomAttributes(typeof(DisplayAttribute), true);
                if (disArr != null && disArr.Length > 0)
                {
                    DisplayAttribute da = disArr[0] as DisplayAttribute;
                    m.Name = da.Name;
                }

                m.Value = Convert.ToInt32(e);
                m.Key = e.ToString();
                list.Add(m);
            }
            return list;
        }

    }
}
