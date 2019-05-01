using System;
using System.Collections.Generic;
using System.Text;

namespace IDal
{

    /// <summary>
    /// 添加记录 接口
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <author>刘迪</author>
    /// <createtime>2019-05-01</createtime>
    /// <updator></updator>
    /// <updatetime></updatetime>
    /// <description></description>
    public interface IAdd
    {
        /// <summary>
        /// 添加记录
        /// </summary>
        /// <typeparam name="TEntity">记录类型</typeparam>
        /// <param name="entity">需要添加的记录</param>
        /// <returns>返回受影响的行数</returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-04-30</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        Int32 Add<TEntity>(TEntity entity);

    }
}
