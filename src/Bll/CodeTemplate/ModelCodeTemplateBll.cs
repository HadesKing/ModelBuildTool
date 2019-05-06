using System;
using System.Collections.Generic;
using System.Text;

namespace Bll.CodeTemplate
{

    /// <summary>
    /// 
    /// </summary>
    public sealed class CodeBuildTemplateBll
    {
        private IDataBll.CodeTemplate.ICodeBuildTemplateDataBll CodeBuildTemplateDataBll { get; set; }

        public CodeBuildTemplateBll(IDataBll.CodeTemplate.ICodeBuildTemplateDataBll argCodeBuildTemplateDataBll)
        {
            CodeBuildTemplateDataBll = argCodeBuildTemplateDataBll;
        }

        public void Add()
        {

        }

    }
}
