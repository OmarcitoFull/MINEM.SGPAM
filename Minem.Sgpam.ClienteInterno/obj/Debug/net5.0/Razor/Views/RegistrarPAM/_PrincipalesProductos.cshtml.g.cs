#pragma checksum "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_PrincipalesProductos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66cefc61edf4a48f3f15a6a41d192d072fee4332"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegistrarPAM__PrincipalesProductos), @"mvc.1.0.view", @"/Views/RegistrarPAM/_PrincipalesProductos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66cefc61edf4a48f3f15a6a41d192d072fee4332", @"/Views/RegistrarPAM/_PrincipalesProductos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3de714567e47f746db7c935497043b8a0ac7cf3f", @"/Views/_ViewImports.cshtml")]
    public class Views_RegistrarPAM__PrincipalesProductos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Minem.Sgpam.TransporteDatos.DtoEntidades.SituacionPrincipalesProductosDTO>>
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
                <th class=""column-title"">Año</th>
                <th class=""column-title"">Nombre Derecho Minero UEA</th>
                <th class=""column-title"">Situación</th>
                <th class=""column-title"">Tipo Concentrado</th>
                <th class=""column-title"">Cantidad (TM)</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 16 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_PrincipalesProductos.cshtml"
             if (!Model.Any())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"even pointer\">\r\n                    <td class=\" \" colspan=\"5\">\r\n                        No existe registros\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 23 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_PrincipalesProductos.cshtml"
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
#line 30 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_PrincipalesProductos.cshtml"
                       Write(item.Anopro);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\" \">\r\n                            ");
#nullable restore
#line 33 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_PrincipalesProductos.cshtml"
                       Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\" \">\r\n                            ");
#nullable restore
#line 36 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_PrincipalesProductos.cshtml"
                       Write(item.Situacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\" \">\r\n                            ");
#nullable restore
#line 39 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_PrincipalesProductos.cshtml"
                       Write(item.Tipo_Concentrado);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\" \">\r\n                            ");
#nullable restore
#line 42 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_PrincipalesProductos.cshtml"
                       Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 45 "D:\A FULLSOFT\2021\MINEM\Servidor\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_PrincipalesProductos.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Minem.Sgpam.TransporteDatos.DtoEntidades.SituacionPrincipalesProductosDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
