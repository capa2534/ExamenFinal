#pragma checksum "C:\Users\valer\OneDrive\Escritorio\Proyecto44\ExamenFinal\ExamenFinalBryan.responsive\Views\Shared\_PartialViewUpdateVehiculo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee0e1ab8c592d6d75e2660e905d482bf592d622f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialViewUpdateVehiculo), @"mvc.1.0.view", @"/Views/Shared/_PartialViewUpdateVehiculo.cshtml")]
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
#line 1 "C:\Users\valer\OneDrive\Escritorio\Proyecto44\ExamenFinal\ExamenFinalBryan.responsive\Views\_ViewImports.cshtml"
using Proyecto.responsive;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\valer\OneDrive\Escritorio\Proyecto44\ExamenFinal\ExamenFinalBryan.responsive\Views\_ViewImports.cshtml"
using Proyecto.domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\valer\OneDrive\Escritorio\Proyecto44\ExamenFinal\ExamenFinalBryan.responsive\Views\_ViewImports.cshtml"
using Proyecto.domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\valer\OneDrive\Escritorio\Proyecto44\ExamenFinal\ExamenFinalBryan.responsive\Views\_ViewImports.cshtml"
using Proyecto.domain.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\valer\OneDrive\Escritorio\Proyecto44\ExamenFinal\ExamenFinalBryan.responsive\Views\_ViewImports.cshtml"
using Proyecto.domain.Models.InputModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\valer\OneDrive\Escritorio\Proyecto44\ExamenFinal\ExamenFinalBryan.responsive\Views\_ViewImports.cshtml"
using Proyecto.domain.Models.DataModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\valer\OneDrive\Escritorio\Proyecto44\ExamenFinal\ExamenFinalBryan.responsive\Views\_ViewImports.cshtml"
using Proyecto.domain.Models.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\valer\OneDrive\Escritorio\Proyecto44\ExamenFinal\ExamenFinalBryan.responsive\Views\_ViewImports.cshtml"
using Proyecto.domain.Models.DataTransferModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee0e1ab8c592d6d75e2660e905d482bf592d622f", @"/Views/Shared/_PartialViewUpdateVehiculo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"501aa1b7e4b744485bf159f68328799c737c2330", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__PartialViewUpdateVehiculo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cancel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"form-group inputs\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee0e1ab8c592d6d75e2660e905d482bf592d622f5786", async() => {
                WriteLiteral("\r\n        <i class=\"fa-solid fa-ban\"></i> Cancel\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <button id=\"submit2\" type=\"submit\" class=\"btn btn-outline-primary\">\r\n        <i class=\"fa-solid fa-floppy-disk\"></i>\r\n");
#nullable restore
#line 9 "C:\Users\valer\OneDrive\Escritorio\Proyecto44\ExamenFinal\ExamenFinalBryan.responsive\Views\Shared\_PartialViewUpdateVehiculo.cshtml"
         if (!string.IsNullOrEmpty(Model))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>Actualizar</span>\r\n");
#nullable restore
#line 12 "C:\Users\valer\OneDrive\Escritorio\Proyecto44\ExamenFinal\ExamenFinalBryan.responsive\Views\Shared\_PartialViewUpdateVehiculo.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>Crear</span>\r\n");
#nullable restore
#line 16 "C:\Users\valer\OneDrive\Escritorio\Proyecto44\ExamenFinal\ExamenFinalBryan.responsive\Views\Shared\_PartialViewUpdateVehiculo.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </button>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
