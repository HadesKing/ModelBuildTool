using System;
using System.Collections.Generic;
using System.Text;

namespace IDal
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <author>刘迪</author>
    /// <createtime>2019-05-02</createtime>
    /// <updator></updator>
    /// <updatetime></updatetime>
    /// <description></description>
    public interface IUpdate
    {
        /// <summary>
        /// 更新记录
        /// </summary>
        /// <typeparam name="TEntity">记录类型</typeparam>
        /// <param name="entity">需要更新的记录</param>
        /// <returns>返回受影响的行数</returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-02</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        Int32 Update<TEntity>(TEntity entity);

    }
}
