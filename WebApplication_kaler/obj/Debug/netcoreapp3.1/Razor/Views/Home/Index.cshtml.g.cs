#pragma checksum "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4ca24831ea52b57991df45093bb851388420b4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\_ViewImports.cshtml"
using WebApplication_kaler;

#line default
#line hidden
#line 2 "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\_ViewImports.cshtml"
using WebApplication_kaler.Models;

#line default
#line hidden
#line 3 "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\_ViewImports.cshtml"
using WebApplication_kaler.DAL.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4ca24831ea52b57991df45093bb851388420b4e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"948600237f23e87e4f0de0902814eed3f1a90b5c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Главная страница";


#line default
#line hidden
            BeginContext(52, 9, true);
            WriteLiteral("\r\n \r\n<h2>");
            EndContext();
            BeginContext(62, 16, false);
#line 8 "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\Home\Index.cshtml"
Write(ViewData["Text"]);

#line default
#line hidden
            EndContext();
            BeginContext(78, 43, true);
            WriteLiteral("</h2>\r\n\r\n<h2>Список</h2>\r\n\r\n<ol type=\"A\">\r\n");
            EndContext();
#line 13 "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\Home\Index.cshtml"
     for (int i = 1; i < 5; i++)
    {

#line default
#line hidden
            BeginContext(162, 20, true);
            WriteLiteral("        <li>элемент ");
            EndContext();
            BeginContext(183, 1, false);
#line 15 "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\Home\Index.cshtml"
               Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(184, 14, true);
            WriteLiteral(" списка</li>\r\n");
            EndContext();
#line 16 "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(205, 35, true);
            WriteLiteral("</ol>\r\n\r\n<hr>\r\n\r\n<h1>Форма</h1>\r\n\r\n");
            EndContext();
            BeginContext(240, 2737, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4ca24831ea52b57991df45093bb851388420b4e5501", async() => {
                BeginContext(260, 2443, true);
                WriteLiteral(@"
    <div style=""margin-left: 17%"">
        <div class=""form-group row"">

            <div class=""col-sm-10"">

                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox"" name=""checkbox1"" value=""true"" id=""defaultCheck1"">
                    <label class=""form-check-label"" for=""defaultCheck1"">Чек-бокс 1 </label>
                </div>

                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox"" name=""checkbox2"" value=""true"" id=""defaultCheck2"">
                    <label class=""form-check-label"" for=""defaultCheck2"">Чек-бокс 2 </label>
                </div>

            </div>

        </div>

        <div class=""form-group row"">

            <div class=""col-sm-10"">

                <div class=""form-check form-check-inline"">
                    <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions1"" id=""inlineRadio1"" value=""option1"">
                    <label class=""form-c");
                WriteLiteral(@"heck-label"" for=""inlineRadio1"">Радио-1</label>
                </div>

                <div class=""form-check form-check-inline"">
                    <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions2"" id=""inlineRadio2"" value=""option2"">
                    <label class=""form-check-label"" for=""inlineRadio2"">Радио-2</label>
                </div>

                <div class=""form-check form-check-inline"">
                    <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions3"" id=""inlineRadio3"" value=""option3"">
                    <label class=""form-check-label"" for=""inlineRadio3"">Радио-3</label>
                </div>

            </div>
        </div>
    </div>

    <div class=""form-group row"">

        <label for=""inputEmail3"" class=""col-sm-2 col-form-label"">Логин:</label>

        <div class=""col-sm-10"">
            <input name=""inputEmail"" type=""email"" class=""form-control"" id=""inputEmail"" placeholder=""Введите имя"">
        </div>

    </div>");
                WriteLiteral(@"

    <div class=""form-group row"">

        <label for=""inputPassword3"" class=""col-sm-2 col-form-label"">Пароль:</label>

        <div class=""col-sm-10"">
            <input name=""inputPassword"" type=""password"" class=""form-control"" id=""inputPassword"" placeholder=""Введите пароль"">
        </div>
    </div>

    <div class=""form-group row"">
        <div class=""col-sm-10"">
            ");
                EndContext();
                BeginContext(2703, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4ca24831ea52b57991df45093bb851388420b4e8528", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 87 "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewData["Lst"] as SelectList;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2763, 207, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group row\">\r\n        <div class=\"col-sm-10\">\r\n            <button type=\"submit\" class=\"btn btn-primary\">Отправить</button>\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2977, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
