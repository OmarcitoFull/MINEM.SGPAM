#pragma checksum "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_RiesgosFaunaSilvestre.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b6c244662cb4ea900e8df9aa65078ad670ebd57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegistrarPAM__RiesgosFaunaSilvestre), @"mvc.1.0.view", @"/Views/RegistrarPAM/_RiesgosFaunaSilvestre.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b6c244662cb4ea900e8df9aa65078ad670ebd57", @"/Views/RegistrarPAM/_RiesgosFaunaSilvestre.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3de714567e47f746db7c935497043b8a0ac7cf3f", @"/Views/_ViewImports.cshtml")]
    public class Views_RegistrarPAM__RiesgosFaunaSilvestre : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Minem.Sgpam.TransporteDatos.DtoEntidades.Comp_Riesgo_Fau_ConDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"x_titleGrupo\">\r\n    <div align=\"center\" class=\"titulo-m\">\r\n    </div>\r\n\r\n    <ul class=\"nav navbar-right panel_toolbox\">\r\n        <li>\r\n            <div class=\"boton\">\r\n                <a href=\"#\" data-toggle=\"modal\" data-target=\"#modal11\"");
            BeginWriteAttribute("onclick", " onclick=\"", 338, "\"", 447, 4);
            WriteAttributeValue("", 348, "ShowModal(\'", 348, 11, true);
#nullable restore
#line 10 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_RiesgosFaunaSilvestre.cshtml"
WriteAttributeValue("", 359, Url.Action("CrearRiesgosFaunaSilvestre", "RegistrarPAM"), 359, 57, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 416, "\',", 416, 2, true);
            WriteAttributeValue(" ", 418, "\'fullRiesgosFaunaSilvestre\')", 419, 29, true);
            EndWriteAttribute();
            WriteLiteral(@">Agregar  <i class=""fa fa-plus""></i></a>
            </div>
        </li>
    </ul>
    <div class=""clearfix""></div>
</div>

<div class=""clearfix""></div>
<div class=""table-responsive"">
    <table id=""fulltbl5"" class=""table table-striped jambo_table bulk_action"">
        <thead>
            <tr class=""headings"">
                <th class=""column-title"">Accesibilidad y escape para la fauna</th>
                <th class=""column-title"">Atracción de fauna silv</th>
                <th class=""column-title"">Vegetación en el sitio y alred </th>
                <th class=""column-title"">Proximidad a áreas prote</th>
                <th class=""column-title"">Sensibilidad del </th>
                <th class=""column-title"">Drenaje o filtración hacia cuerpos</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 31 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_RiesgosFaunaSilvestre.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"odd pointer\">\r\n                    <td class=\" \">\r\n                        ");
#nullable restore
#line 35 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_RiesgosFaunaSilvestre.cshtml"
                   Write(item.Acceso_Fauna);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\" \">\r\n                        ");
#nullable restore
#line 38 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_RiesgosFaunaSilvestre.cshtml"
                   Write(item.Atraccion_Fauna);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\" \">\r\n                        ");
#nullable restore
#line 41 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_RiesgosFaunaSilvestre.cshtml"
                   Write(item.Vegetacion_Invasiva);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\" \">\r\n                        ");
#nullable restore
#line 44 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_RiesgosFaunaSilvestre.cshtml"
                   Write(item.Cerca_Area_Protegida);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                        \r\n                    <td class=\" \">\r\n                        ");
#nullable restore
#line 48 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_RiesgosFaunaSilvestre.cshtml"
                   Write(item.Sensibilidad_Area);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\" \">\r\n                        ");
#nullable restore
#line 51 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_RiesgosFaunaSilvestre.cshtml"
                   Write(item.Agua_Contaminada);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 54 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_RiesgosFaunaSilvestre.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Minem.Sgpam.TransporteDatos.DtoEntidades.Comp_Riesgo_Fau_ConDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
