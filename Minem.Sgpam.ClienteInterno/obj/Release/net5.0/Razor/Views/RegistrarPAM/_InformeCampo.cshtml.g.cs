#pragma checksum "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_InformeCampo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d53b25087e189f878acf5458c7c83e35402b7ca9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegistrarPAM__InformeCampo), @"mvc.1.0.view", @"/Views/RegistrarPAM/_InformeCampo.cshtml")]
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
#line 1 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\_ViewImports.cshtml"
using Minem.Sgpam.ClienteInterno;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\_ViewImports.cshtml"
using Minem.Sgpam.ClienteInterno.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d53b25087e189f878acf5458c7c83e35402b7ca9", @"/Views/RegistrarPAM/_InformeCampo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3de714567e47f746db7c935497043b8a0ac7cf3f", @"/Views/_ViewImports.cshtml")]
    public class Views_RegistrarPAM__InformeCampo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Minem.Sgpam.TransporteDatos.DtoEntidades.Comp_Info_CampoDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"x_titleGrupo\">\r\n    <div align=\"center\" class=\"titulo-m\">\r\n    </div>\r\n    <ul class=\"nav navbar-right panel_toolbox\">\r\n        <li>\r\n            <div class=\"boton\">\r\n                <a href=\"#\" data-toggle=\"modal\" data-target=\"#modal22\"");
            BeginWriteAttribute("onclick", " onclick=\"", 332, "\"", 423, 4);
            WriteAttributeValue("", 342, "ShowModal(\'", 342, 11, true);
#nullable restore
#line 9 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_InformeCampo.cshtml"
WriteAttributeValue("", 353, Url.Action("CrearInformeCampo", "RegistrarPAM"), 353, 48, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 401, "\',", 401, 2, true);
            WriteAttributeValue(" ", 403, "\'fullInformeCampo\')", 404, 20, true);
            EndWriteAttribute();
            WriteLiteral(@">Agregar  <i class=""fa fa-plus""></i></a>
            </div>
        </li>

    </ul>
    <div class=""clearfix""></div>
</div>

<div class=""clearfix""></div>
<div class=""table-responsive"">
    <table id=""fulltbl16"" class=""table table-striped jambo_table bulk_action"">
        <thead>
            <tr class=""headings"">
                <th class=""column-title"">Informe</th>
                <th class=""column-title"">Fecha</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 27 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_InformeCampo.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"odd pointer\">\r\n                    <td class=\" \">\r\n                        ");
#nullable restore
#line 31 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_InformeCampo.cshtml"
                   Write(item.Nro_Informe);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\" \">\r\n                        ");
#nullable restore
#line 34 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_InformeCampo.cshtml"
                   Write(item.Fecha_Informe.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 37 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_InformeCampo.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Minem.Sgpam.TransporteDatos.DtoEntidades.Comp_Info_CampoDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
