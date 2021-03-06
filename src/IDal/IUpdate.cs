﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IDal
{
    /// <summary>
    /// 修改纪录
    /// </summary>
    /// <typeparam name="TEntity">记录类型</typeparam>
    /// <remarks>
    /// 
    /// </remarks>
    /// <author>刘迪</author>
    /// <createtime>2019-05-02</createtime>
    /// <updator></updator>
    /// <updatetime></updatetime>
    /// <description></description>
    public interface IUpdate<TEntity> where TEntity : class
    {
        /// <summary>
        /// 更新记录
        /// </summary>
        /// <param name="entity">需要更新的记录</param>
        /// <returns>返回受影响的行数</returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-02</createtime>
        /// <updator>刘迪</updator>
        /// <updatetime>2019-05-11</updatetime>
        /// <description>
        ///     将操作数据类型（记录类型）放在接口层次进行限制（不放在方法层次进行限制）
        /// </description>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        Int32 Update(TEntity entity);

    }
}
