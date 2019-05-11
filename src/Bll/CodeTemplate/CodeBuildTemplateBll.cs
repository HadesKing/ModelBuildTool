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

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="codeBuildTemplateDto"></param>
        /// <returns></returns>
        public Int32 Add(Dto.CodeTemplate.CodeBuildTemplateDto codeBuildTemplateDto)
        {
            if (null == codeBuildTemplateDto || String.IsNullOrWhiteSpace(codeBuildTemplateDto.Identity)) return 0;
            Model.CodeTemplate.CodeBuildTemplate model = 
                Util.AutoMapperHelper.Get<Dto.CodeTemplate.CodeBuildTemplateDto, Model.CodeTemplate.CodeBuildTemplate>(codeBuildTemplateDto);

            return CodeBuildTemplateDataBll.Add(model);
        }

    }
}
