using System;
using System.Collections.Generic;
using System.Text;

namespace Model.MySql
{
    public sealed partial class MySqlTableColumnInfo
    {
        public String TABLE_CATALOG { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        public String TABLE_SCHEMA { get; set; }

        /// <summary>
        /// 表名称
        /// </summary>
        public String TABLE_NAME { get; set; }

        /// <summary>
        /// 列名称
        /// </summary>
        public String COLUMN_NAME { get; set; }
        public String ORDINAL_POSITION { get; set; }
        public String COLUMN_DEFAULT { get; set; }

        /// <summary>
        /// 是否可以为null
        /// </summary>
        public String IS_NULLABLE { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        public String DATA_TYPE { get; set; }
        public String CHARACTER_MAXIMUM_LENGTH { get; set; }
        public String CHARACTER_OCTET_LENGTH { get; set; }
        public String NUMERIC_PRECISION { get; set; }
        public String NUMERIC_SCALE { get; set; }
        public String DATETIME_PRECISION { get; set; }
        public String CHARACTER_SET_NAME { get; set; }
        public String COLLATION_NAME { get; set; }

        /// <summary>
        /// 列类型（包含长度）
        /// </summary>
        public String COLUMN_TYPE { get; set; }
        public String COLUMN_KEY { get; set; }
        public String EXTRA { get; set; }
        public String PRIVILEGES { get; set; }
        public String COLUMN_COMMENT { get; set; }
        public String GENERATION_EXPRESSION { get; set; }

    }
}
