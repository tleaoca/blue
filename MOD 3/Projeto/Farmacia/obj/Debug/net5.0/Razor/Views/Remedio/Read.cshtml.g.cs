#pragma checksum "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36d35ed7f7cd9e87641ca5d6b15760bd7bb5336f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Remedio_Read), @"mvc.1.0.view", @"/Views/Remedio/Read.cshtml")]
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
#nullable restore
#line 1 "C:\blue\MOD 3\Projeto\Farmacia\Views\_ViewImports.cshtml"
using Farmacia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\blue\MOD 3\Projeto\Farmacia\Views\_ViewImports.cshtml"
using Farmacia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36d35ed7f7cd9e87641ca5d6b15760bd7bb5336f", @"/Views/Remedio/Read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71497ad7aa79d8154948264ed88d88beb5a2f4a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Remedio_Read : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Remedio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Remedio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("<br />\r\n<br />\r\n<br />\r\n<br />\r\n<div class=\"alert alert-dark\" role=\"alert\">Remédio de registro nº ");
#nullable restore
#line 6 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                                                             Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<dl class=\"row\">\r\n    <dt class=\"col-sm-3\">");
#nullable restore
#line 8 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayNameFor(Model => Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd class=\"col-sm-9\">");
#nullable restore
#line 9 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayFor(Model => Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    <dt class=\"col-sm-3\">");
#nullable restore
#line 10 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayNameFor(Model => Model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd class=\"col-sm-9\">");
#nullable restore
#line 11 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayFor(Model => Model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    <dt class=\"col-sm-3\">");
#nullable restore
#line 12 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayNameFor(Model => Model.Fabricante));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd class=\"col-sm-9\">");
#nullable restore
#line 13 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayFor(Model => Model.Fabricante));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    <dt class=\"col-sm-3\">");
#nullable restore
#line 14 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayNameFor(Model => Model.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd class=\"col-sm-9\">R$");
#nullable restore
#line 15 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                      Write(Html.DisplayFor(Model => Model.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    <dt class=\"col-sm-3\">");
#nullable restore
#line 16 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayNameFor(Model => Model.Quantidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd class=\"col-sm-9\">");
#nullable restore
#line 17 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayFor(Model => Model.Quantidade));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Unidades</dd>\r\n    <dt class=\"col-sm-3\">");
#nullable restore
#line 18 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayNameFor(Model => Model.Validade));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd class=\"col-sm-9\">");
#nullable restore
#line 19 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayFor(Model => Model.Validade));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n</dl>\r\n");
#nullable restore
#line 21 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
 if (Model.Validade < DateTime.Today)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        Remédio vencido!\r\n    </div>\r\n");
#nullable restore
#line 27 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
 if (Model.Pedidos.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Pedidos:</h3>\r\n");
#nullable restore
#line 31 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
     foreach (Pedido p in Model.Pedidos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<dl class=\"row\">\r\n    <dt class=\"col-sm-3\">");
#nullable restore
#line 34 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayNameFor(x => p.dataPedido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd class=\"col-sm-9\">");
#nullable restore
#line 35 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayFor(x => p.dataPedido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    <dt class=\"col-sm-3\">");
#nullable restore
#line 36 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayNameFor(x => p.Cliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd class=\"col-sm-9\">");
#nullable restore
#line 37 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayFor(x => p.Cliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>    \r\n</dl>\r\n");
#nullable restore
#line 39 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36d35ed7f7cd9e87641ca5d6b15760bd7bb5336f10314", async() => {
                WriteLiteral("Voltar para Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36d35ed7f7cd9e87641ca5d6b15760bd7bb5336f11769", async() => {
                WriteLiteral("Visualizar toda lista");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Remedio> Html { get; private set; }
    }
}
#pragma warning restore 1591
