#pragma checksum "C:\Users\Alexandra\Source\CUS3-vf\CUS3_V4\Views\TTandas\Buscar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bddeb2b67d5de9c31382541c5e1bd4cd7f02bf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TTandas_Buscar), @"mvc.1.0.view", @"/Views/TTandas/Buscar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TTandas/Buscar.cshtml", typeof(AspNetCore.Views_TTandas_Buscar))]
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
#line 1 "C:\Users\Alexandra\Source\CUS3-vf\CUS3_V4\Views\_ViewImports.cshtml"
using CUS3_V4;

#line default
#line hidden
#line 2 "C:\Users\Alexandra\Source\CUS3-vf\CUS3_V4\Views\_ViewImports.cshtml"
using CUS3_V4.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bddeb2b67d5de9c31382541c5e1bd4cd7f02bf8", @"/Views/TTandas/Buscar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6d23f9f4fdae9c1a37e5ac1ac4110f29e9f0315", @"/Views/_ViewImports.cshtml")]
    public class Views_TTandas_Buscar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CUS3_V4.Models.TTanda>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BuscarT", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-info glyphicon glyphicon-check"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-1.10.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jqGrid/js/i18n/grid.locale-es.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jqGrid/js/jquery.jqGrid.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/JSBuscarTanda.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Alexandra\Source\CUS3-vf\CUS3_V4\Views\TTandas\Buscar.cshtml"
  
    ViewData["Title"] = "Buscar";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(134, 369, true);
            WriteLiteral(@"
<h2>CALIFICAR</h2>

<div class=""container"">
    <div class=""row "">
        <div class=""col-lg-12 col-md-12 col-sm-12"">
            <div class=""form-group"">
                <label class=""text-center text-dark font-weight-bold"" for=""name"">Tanda</label>
                <select class=""col-lg-12 col-md-12 col-sm-12 form-control"" id=""tandaa"">
                    ");
            EndContext();
            BeginContext(503, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7644d0c19b4d402ba9230e04200bc5d9", async() => {
                BeginContext(520, 10, true);
                WriteLiteral("Seleccione");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(539, 879, true);
            WriteLiteral(@"
                </select>
            </div>
        </div>

        <div class=""col-lg-12 col-md-12 col-sm-12"" style=""width : 20% ; margin: 15px 0px 50px 65px"">
            <div class=""form-group"">
                <button onclick=""getlistpuntajes(true)"" , class=""btn btn-dark text-danger"" style=""margin: 0px 0px 0px 280px""><span class=""glyphicon glyphicon-search""></span> Buscar</button>
            </div>
        </div>

    </div>
</div>

<table class=""table"" hidden=""hidden"">
    <thead>
        <tr>
            <th>
                Tanda
            </th>
            <th>
                Modalidad
            </th>
            <th>
                Categoria
            </th>
            <th>
                Tipo Tanda
            </th>
            <th>
                Acion
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 51 "C:\Users\Alexandra\Source\CUS3-vf\CUS3_V4\Views\TTandas\Buscar.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1467, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1528, 45, false);
#line 55 "C:\Users\Alexandra\Source\CUS3-vf\CUS3_V4\Views\TTandas\Buscar.cshtml"
               Write(Html.DisplayFor(modelItem => item.PkItCodTan));

#line default
#line hidden
            EndContext();
            BeginContext(1573, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1641, 48, false);
#line 58 "C:\Users\Alexandra\Source\CUS3-vf\CUS3_V4\Views\TTandas\Buscar.cshtml"
               Write(Html.DisplayFor(modelItem => item.VtDescripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1689, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1757, 49, false);
#line 61 "C:\Users\Alexandra\Source\CUS3-vf\CUS3_V4\Views\TTandas\Buscar.cshtml"
               Write(Html.DisplayFor(modelItem => item.VtDescripcion1));

#line default
#line hidden
            EndContext();
            BeginContext(1806, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1874, 46, false);
#line 64 "C:\Users\Alexandra\Source\CUS3-vf\CUS3_V4\Views\TTandas\Buscar.cshtml"
               Write(Html.DisplayFor(modelItem => item.VtTipoTanda));

#line default
#line hidden
            EndContext();
            BeginContext(1920, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 67 "C:\Users\Alexandra\Source\CUS3-vf\CUS3_V4\Views\TTandas\Buscar.cshtml"
                     if (item.ItEstado == 1)
                    {
                        

#line default
#line hidden
            BeginContext(2323, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2347, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc017526732945998113ef11258c7c62", async() => {
                BeginContext(2460, 9, true);
                WriteLiteral("Calificar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "C:\Users\Alexandra\Source\CUS3-vf\CUS3_V4\Views\TTandas\Buscar.cshtml"
                                                  WriteLiteral(item.PkItCodTan);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2473, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 73 "C:\Users\Alexandra\Source\CUS3-vf\CUS3_V4\Views\TTandas\Buscar.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2547, 80, true);
            WriteLiteral("                        <p class=\"text-center text-primary\">YA CALIFICADO!</p>\r\n");
            EndContext();
#line 77 "C:\Users\Alexandra\Source\CUS3-vf\CUS3_V4\Views\TTandas\Buscar.cshtml"
                    }

#line default
#line hidden
            BeginContext(2650, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 80 "C:\Users\Alexandra\Source\CUS3-vf\CUS3_V4\Views\TTandas\Buscar.cshtml"
        }

#line default
#line hidden
            BeginContext(2703, 330, true);
            WriteLiteral(@"    </tbody>
</table>
<br />

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-body"" align=""center"">
                <table id=""table-listar-tandas""></table>
                <div id=""pager-listar-tandas""></div>
            </div>
        </div>
    </div>
</div>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3050, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3056, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bc2328de46445dc972afde733cd081f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3105, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3111, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ab08885fa4d4362bb969fcde612d181", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3173, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3179, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39f0459268044a5f9997d5c3b86d90df", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3235, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3241, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0a35d0b833e482da0a000ba45a6d860", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3286, 7, true);
                WriteLiteral("\r\n   \r\n");
                EndContext();
                BeginContext(3871, 6, true);
                WriteLiteral("    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CUS3_V4.Models.TTanda>> Html { get; private set; }
    }
}
#pragma warning restore 1591
