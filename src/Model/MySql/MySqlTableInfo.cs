using System;
using System.Collections.Generic;
using System.Text;

namespace Model.MySql
{
    public sealed partial class MySqlTableInfo
    {

        public String TABLE_CATALOG { get; set; }

        /// <summary>
        /// 数据库信息
        /// </summary>
        public String TABLE_SCHEMA { get; set; }

        /// <summary>
        /// 表名称
        /// </summary>
        public String TABLE_NAME { get; set; }
        public String TABLE_TYPE { get; set; }
        public String ENGINE { get; set; }
        public String VERSION { get; set; }
        public String ROW_FORMAT { get; set; }

        /// <summary>
        /// 行数
        /// </summary>
        public String TABLE_ROWS { get; set; }
        public String AVG_ROW_LENGTH { get; set; }
        public String DATA_LENGTH { get; set; }
        public String MAX_DATA_LENGTH { get; set; }
        public String INDEX_LENGTH { get; set; }
        public String DATA_FREE { get; set; }
        public String AUTO_INCREMENT { get; set; }
        public String CREATE_TIME { get; set; }
        public String UPDATE_TIME { get; set; }
        public String CHECK_TIME { get; set; }
        public String TABLE_COLLATION { get; set; }
        public String CHECKSUM { get; set; }
        public String CREATE_OPTIONS { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        public String TABLE_COMMENT { get; set; }

    }
}
