#pragma checksum "E:\刘迪\个人文件\TestProject\TestModelBuild\Git-CodeBuildSolution\ModelBuildTool\src\Manager\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4a3302e05f73f80fd73cd70c771f3139649c818"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Index.cshtml", typeof(AspNetCore.Views_Login_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4a3302e05f73f80fd73cd70c771f3139649c818", @"/Views/Login/Index.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition login-page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\刘迪\个人文件\TestProject\TestModelBuild\Git-CodeBuildSolution\ModelBuildTool\src\Manager\Views\Login\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(198, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(225, 1528, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4a3302e05f73f80fd73cd70c771f3139649c8183479", async() => {
                BeginContext(231, 100, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <title>");
                EndContext();
                BeginContext(332, 17, false);
#line 16 "E:\刘迪\个人文件\TestProject\TestModelBuild\Git-CodeBuildSolution\ModelBuildTool\src\Manager\Views\Login\Index.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(349, 239, true);
                WriteLiteral("</title>\r\n    <!-- Tell the browser to be responsive to screen width -->\r\n    <meta content=\"width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no\" name=\"viewport\">\r\n    <!-- Bootstrap 3.3.7 -->\r\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 588, "\"", 679, 1);
#line 20 "E:\刘迪\个人文件\TestProject\TestModelBuild\Git-CodeBuildSolution\ModelBuildTool\src\Manager\Views\Login\Index.cshtml"
WriteAttributeValue("", 595, Url.Content("~/lib/AdminLTE/bower_components/bootstrap/dist/css/bootstrap.min.css"), 595, 84, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(680, 56, true);
                WriteLiteral(">\r\n    <!-- Font Awesome -->\r\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 736, "\"", 828, 1);
#line 22 "E:\刘迪\个人文件\TestProject\TestModelBuild\Git-CodeBuildSolution\ModelBuildTool\src\Manager\Views\Login\Index.cshtml"
WriteAttributeValue("", 743, Url.Content("~/lib/AdminLTE/bower_components/font-awesome/css/font-awesome.min.css"), 743, 85, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(829, 52, true);
                WriteLiteral(">\r\n    <!-- Ionicons -->\r\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 881, "\"", 965, 1);
#line 24 "E:\刘迪\个人文件\TestProject\TestModelBuild\Git-CodeBuildSolution\ModelBuildTool\src\Manager\Views\Login\Index.cshtml"
WriteAttributeValue("", 888, Url.Content("~/lib/AdminLTE/bower_components/Ionicons/css/ionicons.min.css"), 888, 77, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(966, 55, true);
                WriteLiteral(">\r\n    <!-- Theme style -->\r\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1021, "\"", 1084, 1);
#line 26 "E:\刘迪\个人文件\TestProject\TestModelBuild\Git-CodeBuildSolution\ModelBuildTool\src\Manager\Views\Login\Index.cshtml"
WriteAttributeValue("", 1028, Url.Content("~/lib/AdminLTE/dist/css/AdminLTE.min.css"), 1028, 56, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1085, 50, true);
                WriteLiteral(">\r\n    <!-- iCheck -->\r\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1135, "\"", 1203, 1);
#line 28 "E:\刘迪\个人文件\TestProject\TestModelBuild\Git-CodeBuildSolution\ModelBuildTool\src\Manager\Views\Login\Index.cshtml"
WriteAttributeValue("", 1142, Url.Content("~/lib/AdminLTE/plugins/iCheck/square/blue.css"), 1142, 61, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1204, 542, true);
                WriteLiteral(@">
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
    <script src=""https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js""></script>
    <script src=""https://oss.maxcdn.com/respond/1.4.2/respond.min.js""></script>
    <![endif]-->
    <!-- Google Font -->
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1753, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1755, 8032, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4a3302e05f73f80fd73cd70c771f3139649c8188717", async() => {
                BeginContext(1796, 65, true);
                WriteLiteral("\r\n    <div class=\"login-box\">\r\n        <div class=\"login-logo\">\r\n");
                EndContext();
                BeginContext(1926, 248, true);
                WriteLiteral("            <b>D</b>I\r\n        </div>\r\n        <!-- /.login-logo -->\r\n        <div class=\"login-box-body\">\r\n            <form id=\"loginForm\">\r\n                <p class=\"login-box-msg\">欢 迎</p>\r\n                <div class=\"form-group has-feedback\">\r\n");
                EndContext();
                BeginContext(2395, 305, true);
                WriteLiteral(@"                    <input type=""text"" class=""form-control"" placeholder=""账户/邮箱/手机号码"" id=""UserName"" name=""UserName"" maxlength=""30"">
                    <span class=""glyphicon glyphicon-envelope form-control-feedback""></span>
                </div>
                <div class=""form-group has-feedback"">
");
                EndContext();
                BeginContext(2820, 671, true);
                WriteLiteral(@"                    <input type=""password"" class=""form-control"" placeholder=""请输入密码"" id=""Password"" name=""Password"" maxlength=""20"">
                    <span class=""glyphicon glyphicon-lock form-control-feedback""></span>
                </div>
                <div class=""row"">
                    <div class=""col-xs-8"">
                        <div class=""checkbox icheck"">
                            <label>
                                <input type=""checkbox"" id=""rememberme""> 记住我
                            </label>
                        </div>
                    </div>
                    <!-- /.col -->
                    <div class=""col-xs-4"">
");
                EndContext();
                BeginContext(3609, 207, true);
                WriteLiteral("                        <input type=\"button\" class=\"btn btn-primary btn-block btn-flat\" id=\"btnLogin\" value=\"登  录\" />\r\n                    </div>\r\n                    <!-- /.col -->\r\n                </div>\r\n");
                EndContext();
                BeginContext(4418, 46, true);
                WriteLiteral("                <!-- /.social-auth-links -->\r\n");
                EndContext();
                BeginContext(4621, 236, true);
                WriteLiteral("                <span style=\"color:red;\" class=\"login-box-msg right\" id=\"errorMsg\"></span>\r\n            </form>\r\n        </div>\r\n        <!-- /.login-box-body -->\r\n    </div>\r\n    <!-- /.login-box -->\r\n    <!-- jQuery 3 -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 4857, "\"", 4936, 1);
#line 95 "E:\刘迪\个人文件\TestProject\TestModelBuild\Git-CodeBuildSolution\ModelBuildTool\src\Manager\Views\Login\Index.cshtml"
WriteAttributeValue("", 4863, Url.Content("~/lib/AdminLTE/bower_components/jquery/dist/jquery.min.js"), 4863, 73, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4937, 53, true);
                WriteLiteral("></script>\r\n    <!-- Bootstrap 3.3.7 -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 4990, "\"", 5078, 1);
#line 97 "E:\刘迪\个人文件\TestProject\TestModelBuild\Git-CodeBuildSolution\ModelBuildTool\src\Manager\Views\Login\Index.cshtml"
WriteAttributeValue("", 4996, Url.Content("~/lib/AdminLTE/bower_components/bootstrap/dist/js/bootstrap.min.js"), 4996, 82, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5079, 44, true);
                WriteLiteral("></script>\r\n    <!-- iCheck -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 5123, "\"", 5188, 1);
#line 99 "E:\刘迪\个人文件\TestProject\TestModelBuild\Git-CodeBuildSolution\ModelBuildTool\src\Manager\Views\Login\Index.cshtml"
WriteAttributeValue("", 5129, Url.Content("~/lib/AdminLTE/plugins/iCheck/icheck.min.js"), 5129, 59, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5189, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 5212, "\"", 5285, 1);
#line 100 "E:\刘迪\个人文件\TestProject\TestModelBuild\Git-CodeBuildSolution\ModelBuildTool\src\Manager\Views\Login\Index.cshtml"
WriteAttributeValue("", 5218, Url.Content("~/lib/jquery-validation/dist/jquery.validate.min.js"), 5218, 67, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5286, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 5309, "\"", 5391, 1);
#line 101 "E:\刘迪\个人文件\TestProject\TestModelBuild\Git-CodeBuildSolution\ModelBuildTool\src\Manager\Views\Login\Index.cshtml"
WriteAttributeValue("", 5315, Url.Content("~/lib/jquery-validation/dist/localization/messages_zh.min.js"), 5315, 76, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5392, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 5415, "\"", 5457, 1);
#line 102 "E:\刘迪\个人文件\TestProject\TestModelBuild\Git-CodeBuildSolution\ModelBuildTool\src\Manager\Views\Login\Index.cshtml"
WriteAttributeValue("", 5421, Url.Content("~/lib/layer/layer.js"), 5421, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5458, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 5481, "\"", 5515, 1);
#line 103 "E:\刘迪\个人文件\TestProject\TestModelBuild\Git-CodeBuildSolution\ModelBuildTool\src\Manager\Views\Login\Index.cshtml"
WriteAttributeValue("", 5487, Url.Content("~/lib/url.js"), 5487, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5516, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 5539, "\"", 5582, 1);
#line 104 "E:\刘迪\个人文件\TestProject\TestModelBuild\Git-CodeBuildSolution\ModelBuildTool\src\Manager\Views\Login\Index.cshtml"
WriteAttributeValue("", 5545, Url.Content("~/lib/AlertMessage.js"), 5545, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5583, 51, true);
                WriteLiteral("></script>\r\n    <script>\r\n        $(function () {\r\n");
                EndContext();
                BeginContext(6225, 3555, true);
                WriteLiteral(@"            $(""#loginForm"").validate({
                rules: {
                    UserName: {
                        required: true,
                        minlength: 3,
                        maxlength: 30
                    },
                    Password: {
                        required: true,
                        minlength: 6,
                        maxlength: 20
                    }
                },
                messages: {
                    username: {
                        required: ""请输入用户名"",
                        minlength: ""用户名最少需要输入3个字符"",
                        maxlength: ""用户名最多只能输入30个字符""
                    },
                    password: {
                        required: ""请输入密码"",
                        minlength: ""用户名最少需要输入6个字符"",
                        maxlength: ""用户名最多只能输入20个字符""
                    }
                },
                errorElement: ""em"",
                errorPlacement: function (error, element) {
                    // Add");
                WriteLiteral(@" the `help-block` class to the error element
                    error.addClass(""help-block"");

                    if (element.prop(""type"") === ""checkbox"") {
                        error.insertAfter(element.parent(""label""));
                    } else {
                        error.insertAfter(element);
                    }
                },
                highlight: function (element, errorClass, validClass) {
                    $(element).parents("".col-sm-5"").addClass(""has-error"").removeClass(""has-success"");
                },
                unhighlight: function (element, errorClass, validClass) {
                    $(element).parents("".col-sm-5"").addClass(""has-success"").removeClass(""has-error"");
                }
            });

            $('input').iCheck({
              checkboxClass: 'icheckbox_square-blue',
              radioClass: 'iradio_square-blue',
              increaseArea: '20%' // optional
            });

            /* 登录事件 */
            $(""#btnLogin"").");
                WriteLiteral(@"click(function () {
                var validateResult = $(""#loginForm"").validate();
                if (validateResult.errorList.length > 0) return;

                var userName = $(""#UserName"").val();
                if (!userName) {
                    $(""#errorMsg"").text(""请输入用户名"");
                    return false;
                }
                var password = $(""#Password"").val();
                if (!password) {
                    $(""#errorMsg"").text(""请输入密码"");
                    return false;
                }
                var isremember = $(""#rememberme"").is("":checked"");
                $.ajax({
                    type: ""POST"",
                    url: loginUrl,
                    data: { userName: userName, password: password, remember: isremember },
                    dataType: receiveDataType,
                    success: function (data) {
                        var jsonData = eval(data);
                        //判断是否登录成功
                        if (jsonData.isSu");
                WriteLiteral(@"ccess) {
                            window.location.href = mainWebUrl;
                        }
                        else {
                            //AlertTips(""#UserName"", jsonData.description);
                            //AlertTips(""#Password"", jsonData.description);
                            $(""#errorMsg"").text(jsonData.description);
                        }

                    }
                });

            });

          });
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9787, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
