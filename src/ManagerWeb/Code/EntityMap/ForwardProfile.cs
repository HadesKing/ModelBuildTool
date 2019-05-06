using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace ManagerWeb.Code.EntityMap
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class ForwardProfile : BaseProfile
    {

        /// <summary>
        /// 初始化
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-06</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        protected override void Init()
        {
            /*
             * 说明：
             *     这里的映射，应该写在服务层中，但是由于没有服务层，所以写在了UI层
             */
            CreateMap<Dto.CodeTemplate.ModelCodeTemplateDto, Model.CodeTemplate.ModelCodeTemplate>().ReverseMap();      //调用ReverseMap方法，设置为反向


        }

    }
}
