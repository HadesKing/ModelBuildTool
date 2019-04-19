using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Common.EnumType
{

    /// <summary>
    /// 数据库类型枚举类
    /// </summary>
    public enum DatabaseType : Int32
    {

        /// <summary>
        /// SqlServer
        /// </summary>
        [CustomEnum(SortNumber = 1, Type = 1)]
        [Description("MySql")]
        MySql = 1,

        /// <summary>
        /// SqlServer
        /// </summary>
        [CustomEnum(SortNumber = 2, Type = 2)]
        [Description("SqlServer")]
        SqlServer = 2

    }
}
