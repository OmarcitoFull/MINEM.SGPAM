#pragma checksum "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_TitularesReferenciales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a45e5f5db217ed39e9fc80b0185c0ab6c59b723"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegistrarPAM__TitularesReferenciales), @"mvc.1.0.view", @"/Views/RegistrarPAM/_TitularesReferenciales.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a45e5f5db217ed39e9fc80b0185c0ab6c59b723", @"/Views/RegistrarPAM/_TitularesReferenciales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3de714567e47f746db7c935497043b8a0ac7cf3f", @"/Views/_ViewImports.cshtml")]
    public class Views_RegistrarPAM__TitularesReferenciales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Minem.Sgpam.TransporteDatos.DtoEntidades.TitularesReferencialesDerechosDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""clearfix""></div>
<div class=""table-responsive"">
    <table class=""table table-striped jambo_table bulk_action"">
        <thead>
            <tr class=""headings"">
                <th class=""column-title"">Titular Nombre Derecho Minero</th>
                <th class=""column-title"">Fec. Inicio</th>
                <th class=""column-title"">Fec. Fin</th>
                <th class=""column-title"">Estado</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 15 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_TitularesReferenciales.cshtml"
             if (!Model.Any())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"even pointer\">\r\n                    <td class=\" \" colspan=\"4\">\r\n                        No existe registros\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 22 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_TitularesReferenciales.cshtml"
            }
            else
            {
                foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"odd pointer\">\r\n                        <td class=\" \">\r\n                            ");
#nullable restore
#line 29 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_TitularesReferenciales.cshtml"
                       Write(item.Titular_Referencial);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\" \">\r\n                            ");
#nullable restore
#line 32 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_TitularesReferenciales.cshtml"
                       Write(item.Fecha_Inicio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\" \">\r\n                            ");
#nullable restore
#line 35 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_TitularesReferenciales.cshtml"
                       Write(item.Fecha_Final);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\" \">\r\n                            ");
#nullable restore
#line 38 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_TitularesReferenciales.cshtml"
                       Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 41 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_TitularesReferenciales.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Minem.Sgpam.TransporteDatos.DtoEntidades.TitularesReferencialesDerechosDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
