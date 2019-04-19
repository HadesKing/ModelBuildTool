using System;
using System.Collections.Generic;
using System.Text;

namespace Common.EnumType
{
    /// <summary>
    /// 自定义返回值类型
    /// </summary>
    public class EnumberCreditType
    {
        /// <summary>  
        /// 枚举的描述  
        /// </summary>  
        public string Description { set; get; }

        /// <summary>  
        /// 枚举名称  
        /// </summary>  
        public string Key { set; get; }

        /// <summary>  
        /// 枚举对象的值  
        /// </summary>  
        public int Value { set; get; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// 分类
        /// </summary>
        public int Classification { set; get; }
    }


}
