using System;
using System.Collections.Generic;
using System.Text;

namespace IDal
{
    public interface IAdd
    {
        /// <summary>
        /// 添加记录
        /// </summary>
        /// <typeparam name="T">记录类型</typeparam>
        /// <returns>返回受影响的行数</returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-04-30</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        Int32 Add<T>();
    }
}
