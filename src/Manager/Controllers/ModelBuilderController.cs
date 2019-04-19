using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.EnumType;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Manager.Controllers
{
    public class ModelBuilderController : Controller
    {
        public IActionResult Index()
        {

            ViewData["DatabaseTypeList"] = GenerateDatabaseTypeList();
            return View();
        }

        private SelectList GenerateDatabaseTypeList()
        {
            List<SelectListItem> items = new List<SelectListItem>()
            {
                new SelectListItem(){ Text="请选择...", Value="-1" }
            };

            IList<EnumberCreditType> dbTypeList = Common.EnumHelper.EnumToList<Common.EnumType.DatabaseType>();
            items.AddRange(
                dbTypeList.Select(x => new SelectListItem()
                {
                    Text = x.Description
                    ,
                    Value = x.Key
                })
            );
            SelectList generateList = new SelectList(items, "Value", "Text");

            return generateList;
        }

        /// <summary>
        /// 获取数据库连接字符串
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private String GetConnectString(Models.DbConnectStringViewModel model)
        {
            String strMySqlConnectStringTemplate = "server={0};port={1};uid={2};password={3};database={4};";
            String strSqlServerConnectStringTemplate = "data source={0},{1};uid={2};pwd={3};database={4};";
            String strConnectString = null;
            String strDatabaseName = model.DatabaseName;
            switch (model.DatabaseType)
            {
                case DatabaseType.MySql:
                    if (String.IsNullOrWhiteSpace(strDatabaseName)) strDatabaseName = "mysql";
                    strConnectString = String.Format(strMySqlConnectStringTemplate, model.Server, model.Port, model.UserName, model.Password, strDatabaseName);
                    break;
                case DatabaseType.SqlServer:
                    if (String.IsNullOrWhiteSpace(strDatabaseName)) strDatabaseName = "master";
                    strConnectString = String.Format(strSqlServerConnectStringTemplate, model.Server, model.Port, model.UserName, model.Password, strDatabaseName);
                    break;
            }

            return strConnectString;
        }

        /// <summary>
        /// 获取数据库信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetDatabase([FromBody]Models.DbConnectStringViewModel model)
        {
            IList<String> databases = new List<String>();

            String strConnectString = GetConnectString(model);

            switch (model.DatabaseType)
            {
                case DatabaseType.MySql:
                    databases = new DataBll.MySql.MySqlDatabaseDataBll().Get(strConnectString);
                    break;
                case DatabaseType.SqlServer:
                    databases = new DataBll.SqlServer.SqlServerDatabaseDataBll().Get(strConnectString);
                    break;
            }

            return Json(databases);
        }

        /// <summary>
        /// 获取数据库表信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetTable([FromBody]Models.DbConnectStringViewModel model)
        {
            IList<String> tables = new List<String>();

            String strConnectString = GetConnectString(model);

            switch (model.DatabaseType)
            {
                case DatabaseType.MySql:
                    IList<Model.MySql.MySqlTableInfo> list1 = new DataBll.MySql.MySqlTableDataBll().Get(strConnectString, model.DatabaseName);
                    if (null != list1 && list1.Count > 0)
                    {
                        tables = list1.Select(x => x.TABLE_NAME).ToList();
                    }
                    break;
                case DatabaseType.SqlServer:
                    tables = new DataBll.SqlServer.SqlServerTableDataBll().Get(strConnectString, model.DatabaseName);
                    break;
            }

            return Json(tables);

        }

        /// <summary>
        /// 生成代码
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Build([FromBody]Models.DbConnectStringViewModel model)
        {
            String strConnectString = GetConnectString(model);

            Models.TableColumnsViewModel tableColumns = new Models.TableColumnsViewModel();
            tableColumns.DbConnectStringInfo = model;

            switch (model.DatabaseType)
            {
                case DatabaseType.MySql:
                    IList<Model.MySql.MySqlTableColumnInfo> tableColumnInfos = new DataBll.MySql.MySqlTableDataBll().GetColumnInfo(strConnectString, model.DatabaseName, model.TableName);
                    tableColumns.Columns = tableColumnInfos.Select(x => new Models.TableColumnInfoViewModel()
                    {
                        Name = x.COLUMN_NAME
                        ,
                        Description = x.COLUMN_COMMENT
                        ,
                        DataType = x.DATA_TYPE
                        ,
                        IsNullable = String.IsNullOrWhiteSpace(x.IS_NULLABLE) 
                            || x.IS_NULLABLE.ToLower() == "null"
                            || x.IS_NULLABLE.ToLower() == "0"
                            ? 0 : 1
                    }).ToList();
                    break;
                case DatabaseType.SqlServer:
                    IList<Model.SqlServer.SqlServerTableColumnInfo> sqlServerColumnInfos = 
                        new DataBll.SqlServer.SqlServerTableDataBll().GetColumns(strConnectString, model.TableName);
                    if (null != sqlServerColumnInfos)
                    {
                        tableColumns.Columns = sqlServerColumnInfos.Select(x => new Models.TableColumnInfoViewModel()
                        {
                            Name = x.ColumnName
                        ,
                            Description = x.ColumnDescription
                        ,
                            DataType = x.ColumnDataType
                        ,
                            IsNullable = x.IsNullable
                        }).ToList();
                    }

                    break;
            }

            return View(tableColumns);
        }


    }
}