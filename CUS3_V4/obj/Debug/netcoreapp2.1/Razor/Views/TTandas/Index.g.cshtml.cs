#pragma checksum "C:\Users\alumno.LABORATORIOS\source\CUS3-vf\CUS3_V4\Views\TTandas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d12c2eb26766735dce74aefec46f755fbe22b76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TTandas_Index), @"mvc.1.0.view", @"/Views/TTandas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TTandas/Index.cshtml", typeof(AspNetCore.Views_TTandas_Index))]
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
#line 1 "C:\Users\alumno.LABORATORIOS\source\CUS3-vf\CUS3_V4\Views\_ViewImports.cshtml"
using CUS3_V4;

#line default
#line hidden
#line 2 "C:\Users\alumno.LABORATORIOS\source\CUS3-vf\CUS3_V4\Views\_ViewImports.cshtml"
using CUS3_V4.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d12c2eb26766735dce74aefec46f755fbe22b76", @"/Views/TTandas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d533b1f7ef4476706da44c2737b4bfc0f796cba1", @"/Views/_ViewImports.cshtml")]
    public class Views_TTandas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CUS3_V4.Models.TTanda>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(42, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\alumno.LABORATORIOS\source\CUS3-vf\CUS3_V4\Views\TTandas\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(127, 25, true);
            WriteLiteral("\n<h2>Index</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(152, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f5ac4c515b14131a2f489b9ceadacc3", async() => {
                BeginContext(175, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(189, 86, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(276, 49, false);
#line 17 "C:\Users\alumno.LABORATORIOS\source\CUS3-vf\CUS3_V4\Views\TTandas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VtDescripcion));

#line default
#line hidden
            EndContext();
            BeginContext(325, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(378, 50, false);
#line 20 "C:\Users\alumno.LABORATORIOS\source\CUS3-vf\CUS3_V4\Views\TTandas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VtDescripcion1));

#line default
#line hidden
            EndContext();
            BeginContext(428, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(481, 45, false);
#line 23 "C:\Users\alumno.LABORATORIOS\source\CUS3-vf\CUS3_V4\Views\TTandas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ItGanador));

#line default
#line hidden
            EndContext();
            BeginContext(526, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(579, 47, false);
#line 26 "C:\Users\alumno.LABORATORIOS\source\CUS3-vf\CUS3_V4\Views\TTandas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VtTipoTanda));

#line default
#line hidden
            EndContext();
            BeginContext(626, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(679, 44, false);
#line 29 "C:\Users\alumno.LABORATORIOS\source\CUS3-vf\CUS3_V4\Views\TTandas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ItEstado));

#line default
#line hidden
            EndContext();
            BeginContext(723, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(776, 47, false);
#line 32 "C:\Users\alumno.LABORATORIOS\source\CUS3-vf\CUS3_V4\Views\TTandas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DtFechaHora));

#line default
#line hidden
            EndContext();
            BeginContext(823, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 38 "C:\Users\alumno.LABORATORIOS\source\CUS3-vf\CUS3_V4\Views\TTandas\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(934, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(981, 48, false);
#line 41 "C:\Users\alumno.LABORATORIOS\source\CUS3-vf\CUS3_V4\Views\TTandas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VtDescripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1029, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1082, 49, false);
#line 44 "C:\Users\alumno.LABORATORIOS\source\CUS3-vf\CUS3_V4\Views\TTandas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VtDescripcion1));

#line default
#line hidden
            EndContext();
            BeginContext(1131, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1184, 44, false);
#line 47 "C:\Users\alumno.LABORATORIOS\source\CUS3-vf\CUS3_V4\Views\TTandas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ItGanador));

#line default
#line hidden
            EndContext();
            BeginContext(1228, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1281, 46, false);
#line 50 "C:\Users\alumno.LABORATORIOS\source\CUS3-vf\CUS3_V4\Views\TTandas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VtTipoTanda));

#line default
#line hidden
            EndContext();
            BeginContext(1327, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1380, 43, false);
#line 53 "C:\Users\alumno.LABORATORIOS\source\CUS3-vf\CUS3_V4\Views\TTandas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ItEstado));

#line default
#line hidden
            EndContext();
            BeginContext(1423, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1476, 46, false);
#line 56 "C:\Users\alumno.LABORATORIOS\source\CUS3-vf\CUS3_V4\Views\TTandas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DtFechaHora));

#line default
#line hidden
            EndContext();
            BeginContext(1522, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1574, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "282448b50eae437396d7acf256e4c86d", async() => {
                BeginContext(1627, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\alumno.LABORATORIOS\source\CUS3-vf\CUS3_V4\Views\TTandas\Index.cshtml"
                                       WriteLiteral(item.PkItCodTan);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1635, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(1654, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee0f21d8d5874091af70097ab783cb4a", async() => {
                BeginContext(1710, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\alumno.LABORATORIOS\source\CUS3-vf\CUS3_V4\Views\TTandas\Index.cshtml"
                                          WriteLiteral(item.PkItCodTan);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1721, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(1740, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87ab6074474c49b2bf6826e0320bf5e4", async() => {
                BeginContext(1795, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\alumno.LABORATORIOS\source\CUS3-vf\CUS3_V4\Views\TTandas\Index.cshtml"
                                         WriteLiteral(item.PkItCodTan);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1805, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 64 "C:\Users\alumno.LABORATORIOS\source\CUS3-vf\CUS3_V4\Views\TTandas\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1840, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CUS3_V4.Models.TTanda>> Html { get; private set; }
    }
}
#pragma warning restore 1591
