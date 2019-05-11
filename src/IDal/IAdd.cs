using System;
using System.Collections.Generic;
using System.Text;

namespace IDal
{

    /// <summary>
    /// 添加记录 接口
    /// </summary>
    /// <typeparam name="TEntity">记录类型</typeparam>
    /// <remarks>
    /// 
    /// </remarks>
    /// <author>刘迪</author>
    /// <createtime>2019-05-01</createtime>
    /// <updator></updator>
    /// <updatetime></updatetime>
    /// <description></description>
    public interface IAdd<TEntity> where TEntity : class
    {
        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="entity">需要添加的记录</param>
        /// <returns>返回受影响的行数</returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-04-30</createtime>
        /// <updator>刘迪</updator>
        /// <updatetime>2019-05-11</updatetime>
        /// <description>
        ///     将操作数据类型（记录类型）放在接口层次进行限制（不放在方法层次进行限制）
        /// </description>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        Int32 Add(TEntity entity);

    }
}
