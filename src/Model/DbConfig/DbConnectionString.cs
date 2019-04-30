using System;
using System.Collections.Generic;
using System.Text;

namespace Model.DbConfig
{

    /// <summary>
    /// 数据库连接字符串配置信息
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <author>刘迪</author>
    /// <createtime>2019-04-29</createtime>
    /// <updator></updator>
    /// <updatetime></updatetime>
    /// <description></description>
    public sealed partial class DbConnectionString
    {
        public DbConnectionString()
        {
            IsEnable = 1;
        }

        /// <summary>
        /// 自增字段
        /// </summary>
        public String Id { get; set; }
        
        /// <summary>
        /// 身份标识
        /// </summary>
        public String Identity { get; set; }
        
        /// <summary>
        /// 配置名称
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        public String DbName { get; set; }

        /// <summary>
        /// 数据库类型
        /// </summary>
        public String DbType { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// 连接字符串的其他信息
        /// </summary>
        public String Other { get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        public String Port { get; set; }
        
        /// <summary>
        /// 备注 
        /// </summary>
        public String Remark { get; set; }

        /// <summary>
        /// 数据库服务器地址/IP
        /// </summary>
        public String Server { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public String Username { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public String Password { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public Int32 IsEnable { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public String CreateBy { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime LastUpdateTime { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public String UpdateBy { get; set; }


    }
}
