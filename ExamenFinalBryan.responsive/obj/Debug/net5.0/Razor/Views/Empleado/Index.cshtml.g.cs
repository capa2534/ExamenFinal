#pragma checksum "C:\Users\capa6\Desktop\New folder (3)\ExamenFinal\ExamenFinalBryan.responsive\Views\Empleado\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3adf327949b61116967555aa12d9e1afbfbc13f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleado_Index), @"mvc.1.0.view", @"/Views/Empleado/Index.cshtml")]
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
#line 1 "C:\Users\capa6\Desktop\New folder (3)\ExamenFinal\ExamenFinalBryan.responsive\Views\_ViewImports.cshtml"
using ExamenFinalBryan.responsive;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\capa6\Desktop\New folder (3)\ExamenFinal\ExamenFinalBryan.responsive\Views\_ViewImports.cshtml"
using ExamenFinalBryan.domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\capa6\Desktop\New folder (3)\ExamenFinal\ExamenFinalBryan.responsive\Views\_ViewImports.cshtml"
using ExamenFinalBryan.domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\capa6\Desktop\New folder (3)\ExamenFinal\ExamenFinalBryan.responsive\Views\_ViewImports.cshtml"
using ExamenFinalBryan.domain.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\capa6\Desktop\New folder (3)\ExamenFinal\ExamenFinalBryan.responsive\Views\_ViewImports.cshtml"
using ExamenFinalBryan.domain.Models.InputModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\capa6\Desktop\New folder (3)\ExamenFinal\ExamenFinalBryan.responsive\Views\_ViewImports.cshtml"
using ExamenFinalBryan.domain.Models.DataModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\capa6\Desktop\New folder (3)\ExamenFinal\ExamenFinalBryan.responsive\Views\_ViewImports.cshtml"
using ExamenFinalBryan.domain.Models.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\capa6\Desktop\New folder (3)\ExamenFinal\ExamenFinalBryan.responsive\Views\_ViewImports.cshtml"
using ExamenFinalBryan.domain.Models.DataTransferModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3adf327949b61116967555aa12d9e1afbfbc13f", @"/Views/Empleado/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f46ceb074c5cd70c3ca30ce5b9fbab338a1b0fa4", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleado_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Empleado>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    body {
        background: rgb(52,58,64);
        background: linear-gradient(90deg, rgba(52,58,64,1) 0%, rgba(108,117,125,1) 25%, rgba(145,145,145,1) 50%, rgba(108,117,125,1) 75%, rgba(52,58,64,1) 100%);
        /*background: rgb(108,117,125);
        background: radial-gradient(circle, rgba(108,117,125,1) 0%, rgba(52,58,64,1) 80%, rgba(52,58,64,1) 100%);*/
    }
</style>

<div class=""row"">
    <div class=""col-6 offset-3 text-left text-center"">
        <h2 class=""text-dark border-bottom border-dark"" style=""font-size:100px;""><i class=""fa-solid fa-people-group""></i></h2>
    </div>
</div>


<div class=""row"">
    <div class=""col-12 text-lg-right"">
        <a href=""/Empleado/upsert/"" class=""btn btn-dark""><i class=""fa-solid fa-circle-plus""></i> &nbsp; Crear nuevo Empleado</a>

    </div>
</div>


<br />
");
            WriteLiteral(@"



<div class=""bg-dark p-4 border rounded "">
    <div class=""bg-light p-1"">
        <table id=""Empleados"" class=""table table-hover table-striped container"">
            <thead class=""thead-dark"">
                <tr class=""text-center"">
                    <th colspan=""5"">Empleados</th>
                </tr>
            </thead>
            <tbody");
            BeginWriteAttribute("class", " class=\"", 2570, "\"", 2578, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 71 "C:\Users\capa6\Desktop\New folder (3)\ExamenFinal\ExamenFinalBryan.responsive\Views\Empleado\Index.cshtml"
                 foreach (var Empleado in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr");
            BeginWriteAttribute("id", " id=\"", 2674, "\"", 2700, 2);
            WriteAttributeValue("", 2679, "Empleado_", 2679, 9, true);
#nullable restore
#line 73 "C:\Users\capa6\Desktop\New folder (3)\ExamenFinal\ExamenFinalBryan.responsive\Views\Empleado\Index.cshtml"
WriteAttributeValue("", 2688, Empleado.Id, 2688, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <td>\r\n                            ");
#nullable restore
#line 75 "C:\Users\capa6\Desktop\New folder (3)\ExamenFinal\ExamenFinalBryan.responsive\Views\Empleado\Index.cshtml"
                       Write(Empleado.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 78 "C:\Users\capa6\Desktop\New folder (3)\ExamenFinal\ExamenFinalBryan.responsive\Views\Empleado\Index.cshtml"
                       Write(Empleado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 81 "C:\Users\capa6\Desktop\New folder (3)\ExamenFinal\ExamenFinalBryan.responsive\Views\Empleado\Index.cshtml"
                       Write(Empleado.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 84 "C:\Users\capa6\Desktop\New folder (3)\ExamenFinal\ExamenFinalBryan.responsive\Views\Empleado\Index.cshtml"
                       Write(Empleado.CorreoElectronico);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <div class=\"text-right\">\r\n\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3266, "\"", 3302, 2);
            WriteAttributeValue("", 3273, "/Empleado/upsert/", 3273, 17, true);
#nullable restore
#line 89 "C:\Users\capa6\Desktop\New folder (3)\ExamenFinal\ExamenFinalBryan.responsive\Views\Empleado\Index.cshtml"
WriteAttributeValue("", 3290, Empleado.Id, 3290, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning text-white\" style=\"cursor:pointer\">\r\n                                    <i class=\"fas fa-edit\"></i>\r\n                                </a>\r\n\r\n                                <a onclick=Delete(\"");
#nullable restore
#line 93 "C:\Users\capa6\Desktop\New folder (3)\ExamenFinal\ExamenFinalBryan.responsive\Views\Empleado\Index.cshtml"
                                              Write(Empleado.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""") class=""btn btn-danger text-white"" style=""cursor:pointer"">
                                    <i class=""fas fa-trash-alt""></i>
                                </a>
                            </div>
                        </td>
                    </tr>
");
#nullable restore
#line 99 "C:\Users\capa6\Desktop\New folder (3)\ExamenFinal\ExamenFinalBryan.responsive\Views\Empleado\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>

    </div>
</div>


<script>

	function Delete(id) {
		swal({
			title: ""¿Esta seguro de eliminar el Empleado?"",
			text: ""¿Los datos no podran ser recuperandos una vez se hayan eliminado del sistema, esta seguro que desea eliminarlos completamente?"",
			icon: ""warning"",
			buttons: true,
			dangerMode: true
		}).then((willDelete) => {
			if (willDelete) {
				$.ajax({
					type: ""DELETE"",
					url: ""/Empleado/delete/"" + id,
					success: function(data) {
						if (data.success) {
							toastr.success(data.message);
							$(""#Empleado_"" + id).remove();
						}
						else {
							toastr.error(data.message);
						}
					}
				});
			}
		});
	}

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Empleado>> Html { get; private set; }
    }
}
#pragma warning restore 1591
