#pragma checksum "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\EUM\_Inspecciones.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95e05c2c548c9df6e961a8a60249009cc2a97338"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EUM__Inspecciones), @"mvc.1.0.view", @"/Views/EUM/_Inspecciones.cshtml")]
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
#line 1 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\_ViewImports.cshtml"
using Minem.Sgpam.ClienteInterno;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\_ViewImports.cshtml"
using Minem.Sgpam.ClienteInterno.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95e05c2c548c9df6e961a8a60249009cc2a97338", @"/Views/EUM/_Inspecciones.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3de714567e47f746db7c935497043b8a0ac7cf3f", @"/Views/_ViewImports.cshtml")]
    public class Views_EUM__Inspecciones : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Minem.Sgpam.TransporteDatos.DtoEntidades.Eum_InspeccionDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <div class=""x_titleGrupo"">
        <div align=""center"" class=""titulo-m"">
        </div>

        <ul class=""nav navbar-right panel_toolbox"">
            <li>
                <div class=""boton"">
                    <a href=""#"" data-toggle=""modal"" data-target=""#modal7"">Agregar  <i class=""fa fa-plus""></i></a>
                </div>
            </li>
        </ul>
        <div class=""clearfix""></div>
    </div>

    <div class=""clearfix""></div>
    <div class=""table-responsive"">
        <table class=""table table-striped jambo_table bulk_action"">
            <thead>
                <tr class=""headings"">
                    <th class=""column-title"">Inspector </th>
                    <th class=""column-title"">Fecha de Inspeccion </th>
                    <th class=""column-title"">Hora Inspección</th>
                    <th class=""column-title"">Clima</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 29 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\EUM\_Inspecciones.cshtml"
                 if (!Model.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"even pointer\">\r\n                        <td class=\" \" colspan=\"4\">\r\n                            No existe registros\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 36 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\EUM\_Inspecciones.cshtml"
                }
                else
                {
                    foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"even pointer\">\r\n                            <td class=\" \">\r\n                                ");
#nullable restore
#line 43 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\EUM\_Inspecciones.cshtml"
                           Write(item.Id_Inspector);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\" \">\r\n                                ");
#nullable restore
#line 46 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\EUM\_Inspecciones.cshtml"
                           Write(item.Fecha_Inspeccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\" \">\r\n                                ");
#nullable restore
#line 49 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\EUM\_Inspecciones.cshtml"
                           Write(item.Fecha_Inspeccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\" \">\r\n                                ");
#nullable restore
#line 52 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\EUM\_Inspecciones.cshtml"
                           Write(item.Id_Tipo_Clima);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 55 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\EUM\_Inspecciones.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Minem.Sgpam.TransporteDatos.DtoEntidades.Eum_InspeccionDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591