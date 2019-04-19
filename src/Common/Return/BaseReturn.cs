using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Return
{
    /// <summary>
    /// 返回操作类型基类
    /// </summary>
    public abstract class BaseReturn
    {

        public BaseReturn()
        {

        }

        /// <summary>
        /// 是否操作成功
        /// </summary>
        public bool IsOperateSuccess { get; set; }
        
        /// <summary>
        /// 操作结果描述
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public String Remark { get; set; }

    }
}
