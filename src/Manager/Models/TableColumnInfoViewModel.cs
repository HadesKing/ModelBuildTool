using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manager.Models
{
    [Serializable]
    public sealed class TableColumnInfoViewModel
    {

        public String Name { get; set; }

        public String DataType { get; set; }

        public String Description { get; set; }

        public Int32 IsNullable { get; set; }

    }
}
