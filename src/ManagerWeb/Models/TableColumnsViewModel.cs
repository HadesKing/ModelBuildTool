using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerWeb.Models
{
    [Serializable]
    public sealed class TableColumnsViewModel
    {
        public IList<TableColumnInfoViewModel> Columns { get; set; }

        public Models.DbConnectStringViewModel DbConnectStringInfo { get; set; }
    }
}
