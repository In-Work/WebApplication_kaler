#pragma checksum "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\Shared\Components\Menu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b88637324bb1f5cf687c22c7c7ab218385a80c8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Menu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Menu_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b88637324bb1f5cf687c22c7c7ab218385a80c8b", @"/Views/Shared/Components/Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"948600237f23e87e4f0de0902814eed3f1a90b5c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MenuItem>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 26, true);
            WriteLiteral("<div class=\"navbar-nav\">\r\n");
            EndContext();
#line 3 "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\Shared\Components\Menu\Default.cshtml"
     foreach (var item in Model)
    {
        

#line default
#line hidden
#line 5 "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\Shared\Components\Menu\Default.cshtml"
         if (item.IsPage)
        {

#line default
#line hidden
            BeginContext(135, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(147, 164, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b88637324bb1f5cf687c22c7c7ab218385a80c8b4038", async() => {
                BeginContext(265, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(284, 9, false);
#line 10 "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\Shared\Components\Menu\Default.cshtml"
           Write(item.Text);

#line default
#line hidden
                EndContext();
                BeginContext(293, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 157, "nav-item", 157, 8, true);
            AddHtmlAttributeValue(" ", 165, "nav-link", 166, 9, true);
#line 7 "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\Shared\Components\Menu\Default.cshtml"
AddHtmlAttributeValue(" ", 174, item.Active, 175, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
#line 8 "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\Shared\Components\Menu\Default.cshtml"
             WriteLiteral(item.Area);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-area", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 9 "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\Shared\Components\Menu\Default.cshtml"
             WriteLiteral(item.Page);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(311, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 12 "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\Shared\Components\Menu\Default.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(349, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(361, 180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b88637324bb1f5cf687c22c7c7ab218385a80c8b7732", async() => {
                BeginContext(495, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(514, 9, false);
#line 18 "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\Shared\Components\Menu\Default.cshtml"
           Write(item.Text);

#line default
#line hidden
                EndContext();
                BeginContext(523, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 371, "nav-item", 371, 8, true);
            AddHtmlAttributeValue(" ", 379, "nav-link", 380, 9, true);
#line 15 "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\Shared\Components\Menu\Default.cshtml"
AddHtmlAttributeValue(" ", 388, item.Active, 389, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
#line 16 "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\Shared\Components\Menu\Default.cshtml"
                   WriteLiteral(item.Controller);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 17 "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\Shared\Components\Menu\Default.cshtml"
               WriteLiteral(item.Action);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(541, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 20 "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\Shared\Components\Menu\Default.cshtml"
        }

#line default
#line hidden
#line 20 "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Views\Shared\Components\Menu\Default.cshtml"
         
    }

#line default
#line hidden
            BeginContext(561, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MenuItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
