#pragma checksum "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Areas\ApiDemo\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0aa60e72ff79771e70527228aed16b90ff2f35d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication_kaler.Areas.ApiDemo.Pages.Areas_ApiDemo_Pages_Index), @"mvc.1.0.razor-page", @"/Areas/ApiDemo/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/ApiDemo/Pages/Index.cshtml", typeof(WebApplication_kaler.Areas.ApiDemo.Pages.Areas_ApiDemo_Pages_Index), null)]
namespace WebApplication_kaler.Areas.ApiDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0aa60e72ff79771e70527228aed16b90ff2f35d5", @"/Areas/ApiDemo/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e58b46b3ebc633443e7e03052a585d0082d4dcbd", @"/Areas/ApiDemo/Pages/_ViewImports.cshtml")]
    public class Areas_ApiDemo_Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(74, 108, true);
            WriteLiteral("<table class=\"table table-striped table-sm\" id=\"list\">\r\n</table>\r\n<div class=\"lead\" id=\"info\"></div>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(201, 28, true);
                WriteLiteral("\r\n    <script>\r\n var url = \"");
                EndContext();
                BeginContext(230, 27, false);
#line 14 "E:\БГУИР\Резюме\WebApplication_kaler\WebApplication_kaler\Areas\ApiDemo\Pages\Index.cshtml"
       Write(Url.Action("Dishes", "api"));

#line default
#line hidden
                EndContext();
                BeginContext(257, 1400, true);
                WriteLiteral(@""";
 $(document).ready(function () {
 // послать запрос
 $.getJSON(url, function (data) {
 // найти таблицу по id
 var table = $(""#list"");
 // сформировать строку для каждого полученного объекта
 $.each(data, function (num, value) {
 createRow(num+1, value).appendTo(table);
 })
 });
 })
 // Функция формирования одной строки таблицы
 // index - порядковый номер
 // data - объект данных
 function createRow(index, data) {
 // создать строку таблицы
 var row = $(""<tr>"");
 // добавть колонку с порядковым номером
 row.append(""<td>"" + index + ""</td>"");
 // добавить колонку с названием
 row.append(""<td>"" + data.dishName + ""</td>"");
 // создать кнопку
 var button = $(""<button>"")
 .addClass(""btn btn-success"") // стиль кнопки
 .click(data.dishId, showDetails) // подписка на событие click
 .text(""Подробно""); // надпись
 // создать колонку с кнопкой
 var td = $(""<td>"").append(button);
 // добавить в строку таблицы
 row.append(td);
 return row;
 }
 //Функция выода информации о выбранном объе");
                WriteLiteral(@"кте
 function showDetails(e) {
 // Послать запрос
 $.getJSON(url + ""/"" + e.data, function (data) {
 // строка информации об объекте
 var details = data.dishName + "": ""
 + data.description + "" - ""
 + data.calories + "" калорий"";
 $(""#info"") // Найти блок для информации
 .empty() // очистить содержимое
.text(details); // записать новый текст
 })
 }
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication_kaler.Areas.ApiDemo.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication_kaler.Areas.ApiDemo.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication_kaler.Areas.ApiDemo.Pages.IndexModel>)PageContext?.ViewData;
        public WebApplication_kaler.Areas.ApiDemo.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591