#pragma checksum "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_EstudiosAmbientales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f24fc0f96d844d9bf9696fde76e779f03cb8ef84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegistrarPAM__EstudiosAmbientales), @"mvc.1.0.view", @"/Views/RegistrarPAM/_EstudiosAmbientales.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24fc0f96d844d9bf9696fde76e779f03cb8ef84", @"/Views/RegistrarPAM/_EstudiosAmbientales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3de714567e47f746db7c935497043b8a0ac7cf3f", @"/Views/_ViewImports.cshtml")]
    public class Views_RegistrarPAM__EstudiosAmbientales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Minem.Sgpam.TransporteDatos.DtoEntidades.Comp_Est_AmbDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"x_titleGrupo\">\r\n    <div align=\"center\" class=\"titulo-m\">\r\n    </div>\r\n\r\n    <ul class=\"nav navbar-right panel_toolbox\">\r\n        <li>\r\n            <div class=\"boton\">\r\n                <a href=\"#\" data-toggle=\"modal\" data-target=\"#modal19\"");
            BeginWriteAttribute("onclick", " onclick=\"", 331, "\"", 434, 4);
            WriteAttributeValue("", 341, "ShowModal(\'", 341, 11, true);
#nullable restore
#line 10 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_EstudiosAmbientales.cshtml"
WriteAttributeValue("", 352, Url.Action("CrearEstudioAmbientales", "RegistrarPAM"), 352, 54, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 406, "\',", 406, 2, true);
            WriteAttributeValue(" ", 408, "\'fullEstudioAmbientales\')", 409, 26, true);
            EndWriteAttribute();
            WriteLiteral(@">Agregar  <i class=""fa fa-plus""></i></a>
            </div>
        </li>
    </ul>
    <div class=""clearfix""></div>
</div>

<div class=""clearfix""></div>
<div class=""table-responsive"">
    <table id=""fulltbl13"" class=""table table-striped jambo_table bulk_action"">
        <thead>
            <tr class=""headings"">
                <th class=""column-title"">Tipo</th>
                <th class=""column-title"">Nombre</th>
                <th class=""column-title"">Unidad Ambienta</th>
                <th class=""column-title"">Nombre Proyecto</th>
                <th class=""column-title"">Resolución de Aprobación</th>
                <th class=""column-title"">Fecha de Resolución</th>
                <th class=""column-title"">Número Expediente </th>
                <th class=""column-title"">Fecha Expediente </th>
                <th class=""column-title"">Situación </th>
                <th class=""column-title"">Acción </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 35 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_EstudiosAmbientales.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"odd pointer\">\r\n                <td class=\" \">\r\n                    ");
#nullable restore
#line 39 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_EstudiosAmbientales.cshtml"
               Write(item.Tipo_Estudio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\" \">\r\n                    ");
#nullable restore
#line 42 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_EstudiosAmbientales.cshtml"
               Write(item.Des_Nom_Titular);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\" \">\r\n                    ");
#nullable restore
#line 45 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_EstudiosAmbientales.cshtml"
               Write(item.Des_Und_Ambiental);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\" \">\r\n                    ");
#nullable restore
#line 48 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_EstudiosAmbientales.cshtml"
               Write(item.Des_Nom_Proyecto);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\" \">\r\n                    ");
#nullable restore
#line 51 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_EstudiosAmbientales.cshtml"
               Write(item.Res_Aprobacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\" \">\r\n                    ");
#nullable restore
#line 54 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_EstudiosAmbientales.cshtml"
               Write(item.Fec_Resolucion.GetValueOrDefault().ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\" \">\r\n                    ");
#nullable restore
#line 57 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_EstudiosAmbientales.cshtml"
               Write(item.Nro_Expediente);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\" \">\r\n                    ");
#nullable restore
#line 60 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_EstudiosAmbientales.cshtml"
               Write(item.Fec_Expediente.GetValueOrDefault().ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\" \">\r\n                    ");
#nullable restore
#line 63 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_EstudiosAmbientales.cshtml"
               Write(item.Des_Situacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\" \" style=\"text-align:center\">\r\n");
#nullable restore
#line 66 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_EstudiosAmbientales.cshtml"
                     if (item.Id_LaserFiche.GetValueOrDefault() > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button type=\"button\" class=\"boton2\" style=\"margin-right: 0px;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2719, "\"", 2803, 6);
            WriteAttributeValue("", 2729, "DescargarArchivo(", 2729, 17, true);
#nullable restore
#line 68 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_EstudiosAmbientales.cshtml"
WriteAttributeValue("", 2746, item.Id_LaserFiche.ToString(), 2746, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2776, ",", 2776, 1, true);
            WriteAttributeValue(" ", 2777, "\'", 2778, 2, true);
#nullable restore
#line 68 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_EstudiosAmbientales.cshtml"
WriteAttributeValue("", 2779, item.Nombre_Documento, 2779, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2801, "\')", 2801, 2, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-download\"></i></button>\r\n");
#nullable restore
#line 69 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_EstudiosAmbientales.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 72 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_EstudiosAmbientales.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Minem.Sgpam.TransporteDatos.DtoEntidades.Comp_Est_AmbDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591