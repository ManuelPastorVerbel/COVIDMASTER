#pragma checksum "C:\Users\Familia\Downloads\ADSI (2175812)\MTIC\programacion basica\ciclo 3\COVID19-master2\COVID19-master\COVID.App.FrontEnd\Pages\PersonalAseo\DetallePersonalAseo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8149ad0d23f75897b93c9e991eff8fed4c92dafc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(COVID.App.FrontEnd.Pages.PersonalAseo.Pages_PersonalAseo_DetallePersonalAseo), @"mvc.1.0.razor-page", @"/Pages/PersonalAseo/DetallePersonalAseo.cshtml")]
namespace COVID.App.FrontEnd.Pages.PersonalAseo
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
#line 1 "C:\Users\Familia\Downloads\ADSI (2175812)\MTIC\programacion basica\ciclo 3\COVID19-master2\COVID19-master\COVID.App.FrontEnd\Pages\_ViewImports.cshtml"
using COVID.App.FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8149ad0d23f75897b93c9e991eff8fed4c92dafc", @"/Pages/PersonalAseo/DetallePersonalAseo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24c4285951707b1f20b83514cbfb2178d927e4df", @"/Pages/_ViewImports.cshtml")]
    public class Pages_PersonalAseo_DetallePersonalAseo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h1>Hoja de Detalles Personal de Aseo</h1>\n\n\n    <table class=\"table\">\n        <tr>\n            <td><b>Nombre:</b></td>\n            <td>");
#nullable restore
#line 11 "C:\Users\Familia\Downloads\ADSI (2175812)\MTIC\programacion basica\ciclo 3\COVID19-master2\COVID19-master\COVID.App.FrontEnd\Pages\PersonalAseo\DetallePersonalAseo.cshtml"
           Write(Model.personal_aseo.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td><b>Apellidos:</b></td>\n            <td>");
#nullable restore
#line 15 "C:\Users\Familia\Downloads\ADSI (2175812)\MTIC\programacion basica\ciclo 3\COVID19-master2\COVID19-master\COVID.App.FrontEnd\Pages\PersonalAseo\DetallePersonalAseo.cshtml"
           Write(Model.personal_aseo.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td><b>Edad:</b></td>\n            <td>");
#nullable restore
#line 19 "C:\Users\Familia\Downloads\ADSI (2175812)\MTIC\programacion basica\ciclo 3\COVID19-master2\COVID19-master\COVID.App.FrontEnd\Pages\PersonalAseo\DetallePersonalAseo.cshtml"
           Write(Model.personal_aseo.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n             <td><b>Estado COVID:</b></td>\n             <td>");
#nullable restore
#line 23 "C:\Users\Familia\Downloads\ADSI (2175812)\MTIC\programacion basica\ciclo 3\COVID19-master2\COVID19-master\COVID.App.FrontEnd\Pages\PersonalAseo\DetallePersonalAseo.cshtml"
            Write(Model.personal_aseo.estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr> \n        <tr>\n             <td><b>Turno:</b></td>\n             <td>");
#nullable restore
#line 27 "C:\Users\Familia\Downloads\ADSI (2175812)\MTIC\programacion basica\ciclo 3\COVID19-master2\COVID19-master\COVID.App.FrontEnd\Pages\PersonalAseo\DetallePersonalAseo.cshtml"
            Write(Model.personal_aseo.turno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n         \n    </table>\n    \n     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8149ad0d23f75897b93c9e991eff8fed4c92dafc6359", async() => {
                WriteLiteral("\n         <i class=\"fas fa-home\"></i>\n\n     ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<COVID.App.FrontEnd.Pages.DetallePersonalAseoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<COVID.App.FrontEnd.Pages.DetallePersonalAseoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<COVID.App.FrontEnd.Pages.DetallePersonalAseoModel>)PageContext?.ViewData;
        public COVID.App.FrontEnd.Pages.DetallePersonalAseoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
