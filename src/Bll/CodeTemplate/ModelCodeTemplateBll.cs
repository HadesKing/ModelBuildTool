using System;
using System.Collections.Generic;
using System.Text;

namespace Bll.CodeTemplate
{

    /// <summary>
    /// 
    /// </summary>
    public sealed class ModelCodeTemplateBll
    {
        private IDataBll.CodeTemplate.IModelCodeTemplateDataBll ModelCodeTemplateDataBll { get; set; }

        public ModelCodeTemplateBll(IDataBll.CodeTemplate.IModelCodeTemplateDataBll argModelCodeTemplateDataBll)
        {
            ModelCodeTemplateDataBll = argModelCodeTemplateDataBll;
        }

        public void Add()
        {

        }

    }
}
