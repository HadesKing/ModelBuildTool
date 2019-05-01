using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Common
{
    public sealed class DatabaseTypeHelper
    {
        /// <summary>
        /// mysql 类型 转换
        /// </summary>
        /// <param name="argDatabaseType"></param>
        /// <returns></returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-01</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        private static String MySqlTypeConvert(String argDatabaseType)
        {
            String strReturn = null;
            switch(argDatabaseType.ToLower())
            {
                case "bit":
                    strReturn = DbType.SByte.ToString();
                    break;
                case "smallint":
                    strReturn = DbType.Int16.ToString();
                    break;
            }
            return strReturn;
        }

        /// <summary>
        /// 数据库类型转换成字符串
        /// </summary>
        /// <param name="argDatabaseType">数据库类型</param>
        /// <param name="argIsNullable">数据库列字段是否可以为NULL</param>
        /// <returns></returns>
        /// <remarks>
        /// 
        /// </remarks>
        /// <author>刘迪</author>
        /// <createtime>2019-05-01</createtime>
        /// <updator></updator>
        /// <updatetime></updatetime>
        /// <description></description>
        public static String DbTypeConvertToString(String argDatabaseType, bool argIsNullable = false)
        {
            if (String.IsNullOrWhiteSpace(argDatabaseType)) return "String";

            String strReturn = MySqlTypeConvert(argDatabaseType);
            if (!String.IsNullOrWhiteSpace(strReturn)) return strReturn;
            //DbType dbType = (DbType)Enum.Parse(typeof(DbType), argDatabaseType, true);
            //Log.LogHelper.Debug(argDatabaseType);
            DbType dbType = EnumHelper.Get(typeof(DbType), argDatabaseType, DbType.AnsiString);
            switch (dbType)
            {
                case DbType.AnsiString:
                    strReturn = "String";
                    break;
                case DbType.AnsiStringFixedLength:
                    strReturn = "String";
                    break;
                case DbType.Binary:
                    strReturn = "Byte[]";
                    break;
                case DbType.Boolean:
                    strReturn = "bool";
                    break;
                case DbType.Byte:
                    strReturn = "Byte";
                    break;
                case DbType.Currency:
                    strReturn = "Decimal";
                    break;
                case DbType.Date:
                    strReturn = "DateTime";
                    break;
                case DbType.DateTime:
                    strReturn = "DateTime";
                    break;
                case DbType.Decimal:
                    strReturn = "Decimal";
                    break;
                case DbType.Double:
                    strReturn = "Double";
                    break;
                case DbType.Guid:
                    strReturn = "Guid";
                    break;
                case DbType.Int16:
                    strReturn = "Int16";
                    break;
                case DbType.Int32:
                    strReturn = "Int32";
                    break;
                case DbType.Int64:
                    strReturn = "Int64";
                    break;
                case DbType.Object:
                    strReturn = "Object";
                    break;
                case DbType.SByte:
                    strReturn = "SByte";
                    break;
                case DbType.Single:
                    strReturn = "Float";
                    break;
                case DbType.String:
                    strReturn = "String";
                    break;
                case DbType.StringFixedLength:
                    strReturn = "String";
                    break;
                case DbType.Time:
                    strReturn = "TimeSpan";
                    break;
                case DbType.UInt16:
                    strReturn = "UInt16";
                    break;
                case DbType.UInt32:
                    strReturn = "UInt32";
                    break;
                case DbType.UInt64:
                    strReturn = "UInt64";
                    break;
                case DbType.VarNumeric:
                    strReturn = "Decimal";
                    break;
                default:
                    strReturn = "String";
                    break;
            }

            return strReturn;
        }

    }
}
