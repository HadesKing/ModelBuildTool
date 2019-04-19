using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manager.Models
{
    [Serializable]
    public sealed class DbConnectStringViewModel
    {
        public Common.EnumType.DatabaseType DatabaseType { get; set; }

        /// <summary>
        /// 服务器地址/IP
        /// </summary>
        public String Server { get; set; }

        /// <summary>
        /// 端口号
        /// </summary>
        public Int32 Port { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public String UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public String Password { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        public String DatabaseName { get; set; }

        /// <summary>
        /// 数据库表名称
        /// </summary>
        public String TableName { get; set; }

    }
}
