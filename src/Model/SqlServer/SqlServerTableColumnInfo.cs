using System;
using System.Collections.Generic;
using System.Text;

namespace Model.SqlServer
{
    public sealed class SqlServerTableColumnInfo
    {

        //public String TableName { get; set; }

        ///// <summary>
        ///// 表描述信息
        ///// </summary>
        //public String TableDescription { get; set; }

        /// <summary>
        /// 列排序序号
        /// </summary>
        public Int32 ColumnSortNumber { get; set; }

        /// <summary>
        /// 列名称
        /// </summary>
        public String ColumnName { get; set; }

        /// <summary>
        /// 列数据类型
        /// </summary>
        public String ColumnDataType { get; set; }

        public Int32 DataLength { get; set; }

        public String DefaultValue { get; set; }

        /// <summary>
        /// 列描述
        /// </summary>
        public String ColumnDescription { get; set; }

        /// <summary>
        /// 0#否，1#是
        /// </summary>
        public Int32 IsNullable { get; set; }

    }
}
