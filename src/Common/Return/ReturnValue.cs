using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Return
{

    /// <summary>
    /// 返回值
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class ReturnValue<T> : BaseReturn
    {

        /// <summary>
        /// 返回值
        /// </summary>
        public T Value { get; set; }

    }
}
