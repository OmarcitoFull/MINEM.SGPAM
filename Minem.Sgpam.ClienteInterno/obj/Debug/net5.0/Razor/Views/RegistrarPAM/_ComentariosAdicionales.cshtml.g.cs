#pragma checksum "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ComentariosAdicionales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bb6208b189e2cf090a6401a9e85febdbccdbf83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegistrarPAM__ComentariosAdicionales), @"mvc.1.0.view", @"/Views/RegistrarPAM/_ComentariosAdicionales.cshtml")]
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
#line 1 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\_ViewImports.cshtml"
using Minem.Sgpam.ClienteInterno;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\_ViewImports.cshtml"
using Minem.Sgpam.ClienteInterno.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bb6208b189e2cf090a6401a9e85febdbccdbf83", @"/Views/RegistrarPAM/_ComentariosAdicionales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3de714567e47f746db7c935497043b8a0ac7cf3f", @"/Views/_ViewImports.cshtml")]
    public class Views_RegistrarPAM__ComentariosAdicionales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Minem.Sgpam.TransporteDatos.DtoEntidades.Comp_ComentarioDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"x_titleGrupo\">\r\n    <div align=\"center\" class=\"titulo-m\">\r\n    </div>\r\n\r\n    <ul class=\"nav navbar-right panel_toolbox\">\r\n        <li>\r\n            <div class=\"boton\">\r\n                <a href=\"#\" data-toggle=\"modal\" data-target=\"#modal14\"");
            BeginWriteAttribute("onclick", " onclick=\"", 334, "\"", 434, 4);
            WriteAttributeValue("", 344, "ShowModal(\'", 344, 11, true);
#nullable restore
#line 10 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ComentariosAdicionales.cshtml"
WriteAttributeValue("", 355, Url.Action("CrearComentarios", "RegistrarPAM"), 355, 47, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 402, "\',", 402, 2, true);
            WriteAttributeValue(" ", 404, "\'fullComentariosAdicionales\')", 405, 30, true);
            EndWriteAttribute();
            WriteLiteral(@">Agregar  <i class=""fa fa-plus""></i></a>
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
                <th class=""column-title"">Fecha</th>
                <th class=""column-title"">Descripción</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 27 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ComentariosAdicionales.cshtml"
             if (!Model.Any())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"even pointer\">\r\n                    <td class=\" \" colspan=\"2\">\r\n                        No existe registros\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 34 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ComentariosAdicionales.cshtml"
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
#line 41 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ComentariosAdicionales.cshtml"
                       Write(item.Fecha.GetValueOrDefault().ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\" \">\r\n                            ");
#nullable restore
#line 44 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ComentariosAdicionales.cshtml"
                       Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 47 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ComentariosAdicionales.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Minem.Sgpam.TransporteDatos.DtoEntidades.Comp_ComentarioDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
