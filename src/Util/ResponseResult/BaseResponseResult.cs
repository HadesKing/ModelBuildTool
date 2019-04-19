using System;
using System.Collections.Generic;
using System.Text;

namespace Util.ResponseResult
{
    /// <summary>
    /// 响应结果基类
    /// </summary>
    public abstract class BaseResponseResult
    {
        public BaseResponseResult()
        {
            IsSuccess = false;
            Description = "";
            Remark = "";
        }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        public String Remark { get; set; }

    }
}
