#pragma checksum "C:\blue\MOD 4\Consultorio\Views\Consulta\Read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15f75d0ea6501f5793ff02bdfb64cb947e1fe73d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consulta_Read), @"mvc.1.0.view", @"/Views/Consulta/Read.cshtml")]
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
#line 1 "C:\blue\MOD 4\Consultorio\Views\_ViewImports.cshtml"
using Consultorio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\blue\MOD 4\Consultorio\Views\_ViewImports.cshtml"
using Consultorio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15f75d0ea6501f5793ff02bdfb64cb947e1fe73d", @"/Views/Consulta/Read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e61303434de2871114bc9584fe1dcbe96b867c11", @"/Views/_ViewImports.cshtml")]
    public class Views_Consulta_Read : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Consulta>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\blue\MOD 4\Consultorio\Views\Consulta\Read.cshtml"
 if(Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>CONSULTA NÃO EXISTE</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15f75d0ea6501f5793ff02bdfb64cb947e1fe73d3522", async() => {
                WriteLiteral("Voltar");
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
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\blue\MOD 4\Consultorio\Views\Consulta\Read.cshtml"
}
else { 


#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Visualizando consulta ");
#nullable restore
#line 10 "C:\blue\MOD 4\Consultorio\Views\Consulta\Read.cshtml"
                     Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("<dl class=\"row\">\r\n    <dt class=\"col-sm-3\">");
#nullable restore
#line 14 "C:\blue\MOD 4\Consultorio\Views\Consulta\Read.cshtml"
                    Write(Html.DisplayNameFor(Model => Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd class=\"col-sm-9\">");
#nullable restore
#line 15 "C:\blue\MOD 4\Consultorio\Views\Consulta\Read.cshtml"
                    Write(Html.DisplayFor(Model => Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n    <dt class=\"col-sm-3\">");
#nullable restore
#line 17 "C:\blue\MOD 4\Consultorio\Views\Consulta\Read.cshtml"
                    Write(Html.DisplayNameFor(Model => Model.DataHora));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd class=\"col-sm-9\">");
#nullable restore
#line 18 "C:\blue\MOD 4\Consultorio\Views\Consulta\Read.cshtml"
                    Write(Html.DisplayFor(Model => Model.DataHora));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n    <dt class=\"col-sm-3\">");
#nullable restore
#line 20 "C:\blue\MOD 4\Consultorio\Views\Consulta\Read.cshtml"
                    Write(Html.DisplayNameFor(Model => Model.paciente.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd class=\"col-sm-9\">");
#nullable restore
#line 21 "C:\blue\MOD 4\Consultorio\Views\Consulta\Read.cshtml"
                    Write(Html.DisplayFor(Model => Model.paciente.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n    <dt class=\"col-sm-3\">");
#nullable restore
#line 23 "C:\blue\MOD 4\Consultorio\Views\Consulta\Read.cshtml"
                    Write(Html.DisplayNameFor(Model => Model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd class=\"col-sm-9\">");
#nullable restore
#line 24 "C:\blue\MOD 4\Consultorio\Views\Consulta\Read.cshtml"
                    Write(Html.DisplayFor(Model => Model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n</dl>\r\n");
#nullable restore
#line 26 "C:\blue\MOD 4\Consultorio\Views\Consulta\Read.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Consulta> Html { get; private set; }
    }
}
#pragma warning restore 1591
