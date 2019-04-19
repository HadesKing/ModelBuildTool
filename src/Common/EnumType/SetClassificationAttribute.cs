using System;
using System.Collections.Generic;
using System.Text;

namespace Common.EnumType
{
    /// <summary>
    /// 添加自定义属性
    /// 作用：过滤枚举类型
    /// </summary>
    public sealed class CustomEnumAttribute : Attribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public CustomEnumAttribute()
        {
        }

        /// <summary>
        /// 分类
        /// </summary>
        public Int32 Type { get; set; }

        /// <summary>
        /// 排序编号
        /// </summary>
        public Int32 SortNumber { get; set; }


    }
}
