#pragma checksum "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\EUM\_ModalTipoOperacion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5761f31235ef083daf6cb170b92539d084c0a8e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EUM__ModalTipoOperacion), @"mvc.1.0.view", @"/Views/EUM/_ModalTipoOperacion.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5761f31235ef083daf6cb170b92539d084c0a8e5", @"/Views/EUM/_ModalTipoOperacion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3de714567e47f746db7c935497043b8a0ac7cf3f", @"/Views/_ViewImports.cshtml")]
    public class Views_EUM__ModalTipoOperacion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Minem.Sgpam.TransporteDatos.DtoEntidades.Eum_OperacionDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"rowGroup\">\r\n    <h1 class=\"grupoT\">Tipo Operación</h1>\r\n\r\n    <table id=\"datatable\" class=\"table table-striped jambo_table bulk_action\">\r\n");
            WriteLiteral("        <thead>\r\n            <tr class=\"headings\">\r\n");
            WriteLiteral("                <th class=\"column-title \">ID</th>\r\n                <th class=\"column-title \">Descripción Tipo Operación</th>\r\n                <th class=\"column-title \"></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 43 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\EUM\_ModalTipoOperacion.cshtml"
             if (!Model.Any())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"even pointer\">\r\n                    <td class=\" \" colspan=\"4\">No existen registros</td>\r\n                </tr>\r\n");
#nullable restore
#line 48 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\EUM\_ModalTipoOperacion.cshtml"
            }
            else
            {
                foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"even pointer\">\r\n                        <td class=\"numero\"");
            BeginWriteAttribute("asp-for", " asp-for=\"", 2162, "\"", 2184, 1);
#nullable restore
#line 54 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\EUM\_ModalTipoOperacion.cshtml"
WriteAttributeValue("", 2172, item.Id_Eum, 2172, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden=\"hidden\">");
#nullable restore
#line 54 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\EUM\_ModalTipoOperacion.cshtml"
                                                                             Write(item.Id_Eum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"numero\"");
            BeginWriteAttribute("asp-for", " asp-for=\"", 2263, "\"", 2296, 1);
#nullable restore
#line 55 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\EUM\_ModalTipoOperacion.cshtml"
WriteAttributeValue("", 2273, item.Id_Tipo_Operacion, 2273, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 55 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\EUM\_ModalTipoOperacion.cshtml"
                                                                        Write(item.Id_Tipo_Operacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 56 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\EUM\_ModalTipoOperacion.cshtml"
                       Write(item.Tipo_Operacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\" col-lg-1\" style=\"text-align:center\">\r\n                            <button type=\"button\" class=\"boton2\" style=\"margin-right: 0px;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2548, "\"", 2629, 6);
            WriteAttributeValue("", 2558, "GrabarTipoOperacion(", 2558, 20, true);
#nullable restore
#line 58 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\EUM\_ModalTipoOperacion.cshtml"
WriteAttributeValue("", 2578, item.Id_Tipo_Operacion.ToString(), 2578, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2612, ",", 2612, 1, true);
            WriteAttributeValue(" ", 2613, "\'", 2614, 2, true);
#nullable restore
#line 58 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\EUM\_ModalTipoOperacion.cshtml"
WriteAttributeValue("", 2615, item.Id_Eum, 2615, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2627, "\')", 2627, 2, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-save\"></i></button>\r\n                        </td>\r\n");
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 68 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\EUM\_ModalTipoOperacion.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n\r\n    <div class=\"clearfix\"></div>\r\n    <div class=\"x_title2\">\r\n        <div align=\"center\" class=\"titulo-m\">\r\n");
            WriteLiteral("        </div>\r\n        <ul class=\"nav navbar-right panel_toolbox\">\r\n");
            WriteLiteral(@"            <li>
                <div class=""boton"" data-dismiss=""modal"">
                    <a href=""#"">Cancelar  <i class=""fa fa-ban""></i></a>
                </div>
            </li>
        </ul>
        <div class=""clearfix""></div>
    </div>
    <div class=""clearfix""></div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Minem.Sgpam.TransporteDatos.DtoEntidades.Eum_OperacionDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591