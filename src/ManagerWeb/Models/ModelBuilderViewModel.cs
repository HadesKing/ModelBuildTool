﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerWeb.Models
{
    [Serializable]
    public sealed class ModelBuilderViewModel
    {

        public Int32 DatabaseType { get; set; }

    }
}
