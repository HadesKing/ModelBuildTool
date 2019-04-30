using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerWeb.BllProcessor
{
    public sealed class TemplateProcessor
    {

        private static String RootPath
        {
            get
            {
                return System.AppDomain.CurrentDomain.BaseDirectory;
            }
        }

        private static String DirectoryPath
        {
            get
            {
                return RootPath + "\\Templates\\";
            }
        }

        /// <summary>
        /// 获取目标文件内容
        /// </summary>
        /// <returns></returns>
        public static String GetPropertyTemplateFileContent()
        {
            String strConent = null;
            String strKey = "PropertyCodeTemplateContent";
            strConent = Common.CacheHelper.Get<String>(strKey);

            if(null == strConent)
            {
                String strFilePath = DirectoryPath + "PropertyCodeTemplate.txt";
                if (!System.IO.File.Exists(strFilePath))
                    throw new Exception(String.Format("The file is not exists. The file path is {0}", strFilePath));

                using (System.IO.StreamReader reader = new System.IO.StreamReader(strFilePath, System.Text.Encoding.Default))
                {
                    strConent = reader.ReadToEnd();

                    reader.Close();
                }
                if(String.IsNullOrWhiteSpace(strConent))
                    throw new Exception(String.Format("The file is empty. The file path is {0}", strFilePath));
                Common.CacheHelper.Set(strKey, strConent, 300); //缓存5分钟
            }

            return strConent;
        }

    }
}
