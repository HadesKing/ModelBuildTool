using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace ManagerWeb.Code.EntityMap
{
    public abstract class BaseProfile : Profile
    {
        public BaseProfile()
        {
            Init();
        }

        protected abstract void Init();

    }
}
