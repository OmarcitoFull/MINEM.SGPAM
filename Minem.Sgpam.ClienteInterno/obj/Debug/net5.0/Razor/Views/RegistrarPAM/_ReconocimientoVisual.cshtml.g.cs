#pragma checksum "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96ee1347444bc2e03019501f7d11627f78faa15f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegistrarPAM__ReconocimientoVisual), @"mvc.1.0.view", @"/Views/RegistrarPAM/_ReconocimientoVisual.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96ee1347444bc2e03019501f7d11627f78faa15f", @"/Views/RegistrarPAM/_ReconocimientoVisual.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3de714567e47f746db7c935497043b8a0ac7cf3f", @"/Views/_ViewImports.cshtml")]
    public class Views_RegistrarPAM__ReconocimientoVisual : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Minem.Sgpam.TransporteDatos.DtoEntidades.Comp_ReconocimientoDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <br>
    <br>
    <!-- <h1 class=""grupoT"">MINERÍA SUBTERRÁNEA</h1> -->
    <div class=""clearfix""></div>
    <div id=""subterranea"" class=""divOculto"" style=""display: none"">
        <div class=""table-responsive "">
            <table class=""table table-striped jambo_table bulk_action"" style=""margin-bottom: 0px !important"">
                <thead>
                    <tr class=""headings"">
                        <th class=""column-title"">Nombre</th>
                        <th class=""column-title"">Base </th>
                        <th class=""column-title"">Altura</th>
                        <th class=""column-title"">Profundidad</th>
                    </tr>
                </thead>
                <tbody id=""ajuste1"">
");
#nullable restore
#line 19 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                     if (!Model.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"even pointer\">\r\n                        <td class=\" \" colspan=\"4\">\r\n                            No existe registros\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 26 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                    }
                    else
                    {
                    foreach (var item in Model.Where(x => x.Id_Tipo_Reconocimiento == 1))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"odd pointer\" data-id=\"");
#nullable restore
#line 31 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                                                Write(item.Id_Comp_Reconocimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <td width=\"30%\">\r\n                            ");
#nullable restore
#line 33 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                       Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1507, "\"", 1543, 1);
#nullable restore
#line 34 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 1515, item.Id_Tipo_Reconocimiento, 1515, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""Tipo"" />
                        </td>
                        <td>
                            <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                                <div class=""form-group"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 1862, "\"", 1880, 1);
#nullable restore
#line 39 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 1870, item.Base, 1870, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Largo"" max=""999999"" min=""-999999"" maxlength=""6"" oninput=""fMaxLength(this)"">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                                <div class=""form-group"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 2377, "\"", 2397, 1);
#nullable restore
#line 46 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 2385, item.Altura, 2385, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Ancho"" max=""999999"" min=""-999999"" maxlength=""6"" oninput=""fMaxLength(this)"">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                                <div class=""form-group"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 2894, "\"", 2919, 1);
#nullable restore
#line 53 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 2902, item.Profundidad, 2902, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"number\" class=\"form-control\" name=\"Altura\" max=\"999999\" min=\"-999999\" maxlength=\"6\" oninput=\"fMaxLength(this)\">\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 58 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                    }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>

        <div class=""table-responsive"">
            <table class=""table table-striped jambo_table bulk_action"" style=""margin-bottom: 0px !important"">
                <thead>
                    <tr class=""headings"">
                        <th class=""column-title"">Nombre</th>
                        <th class=""column-title"">largo </th>
                        <th class=""column-title"">Ancho</th>
                        <th class=""column-title"">Profundidad</th>
                    </tr>
                </thead>
                <tbody id=""ajuste2"">
");
#nullable restore
#line 75 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                     if (!Model.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"even pointer\">\r\n                        <td class=\" \" colspan=\"4\">\r\n                            No existe registros\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 82 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                    }
                    else
                    {
                    foreach (var item in Model.Where(x => x.Id_Tipo_Reconocimiento == 2))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"odd pointer\" data-id=\"");
#nullable restore
#line 87 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                                                Write(item.Id_Comp_Reconocimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <td width=\"30%\">\r\n                            ");
#nullable restore
#line 89 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                       Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 4525, "\"", 4561, 1);
#nullable restore
#line 90 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 4533, item.Id_Tipo_Reconocimiento, 4533, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""Tipo"" />
                        </td>
                        <td>
                            <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                                <div class=""form-group"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 4880, "\"", 4899, 1);
#nullable restore
#line 95 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 4888, item.Largo, 4888, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Largo"" max=""999999"" min=""-999999"" maxlength=""6"" oninput=""fMaxLength(this)"">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                                <div class=""form-group"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 5396, "\"", 5415, 1);
#nullable restore
#line 102 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 5404, item.Ancho, 5404, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Ancho"" max=""999999"" min=""-999999"" maxlength=""6"" oninput=""fMaxLength(this)"">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                                <div class=""form-group"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 5912, "\"", 5937, 1);
#nullable restore
#line 109 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 5920, item.Profundidad, 5920, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"number\" class=\"form-control\" name=\"Altura\" max=\"999999\" min=\"-999999\" maxlength=\"6\" oninput=\"fMaxLength(this)\">\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 114 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                    }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>

        <div class=""table-responsive"">
            <table class=""table table-striped jambo_table bulk_action"" style=""margin-bottom: 0px !important"">
                <thead>
                    <tr class=""headings"">
                        <th class=""column-title"">Nombre</th>
                        <th class=""column-title"">Base </th>
                        <th class=""column-title"">Altura</th>
                        <th class=""column-title"">Profundidad</th>
                    </tr>
                </thead>
                <tbody id=""ajuste3"">
");
#nullable restore
#line 131 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                     if (!Model.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"even pointer\">\r\n                        <td class=\" \" colspan=\"4\">\r\n                            No existe registros\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 138 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                    }
                    else
                    {
                    foreach (var item in Model.Where(x => x.Id_Tipo_Reconocimiento == 3))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"odd pointer\" data-id=\"");
#nullable restore
#line 143 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                                                Write(item.Id_Comp_Reconocimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <td width=\"30%\">\r\n                            ");
#nullable restore
#line 145 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                       Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 7543, "\"", 7579, 1);
#nullable restore
#line 146 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 7551, item.Id_Tipo_Reconocimiento, 7551, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""Tipo"" />
                        </td>
                        <td>
                            <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                                <div class=""form-group"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 7898, "\"", 7916, 1);
#nullable restore
#line 151 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 7906, item.Base, 7906, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Largo"" max=""999999"" min=""-999999"" maxlength=""6"" oninput=""fMaxLength(this)"">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                                <div class=""form-group"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 8413, "\"", 8433, 1);
#nullable restore
#line 158 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 8421, item.Altura, 8421, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Altura"" max=""999999"" min=""-999999"" maxlength=""6"" oninput=""fMaxLength(this)"">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                                <div class=""form-group"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 8931, "\"", 8956, 1);
#nullable restore
#line 165 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 8939, item.Profundidad, 8939, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"number\" class=\"form-control\" name=\"Area\" max=\"999999\" min=\"-999999\" maxlength=\"6\" oninput=\"fMaxLength(this)\">\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 170 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                    }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>

        <div class=""table-responsive"">
            <table class=""table table-striped jambo_table bulk_action"" style=""margin-bottom: 0px !important"">
                <thead>
                    <tr class=""headings"">
                        <th class=""column-title"">Nombre</th>
                        <th class=""column-title"">largo </th>
                        <th class=""column-title"">Ancho</th>
                        <th class=""column-title"">Profundidad</th>
                    </tr>
                </thead>
                <tbody id=""ajuste4"">
");
#nullable restore
#line 187 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                     if (!Model.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"even pointer\">\r\n                        <td class=\" \" colspan=\"4\">\r\n                            No existe registros\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 194 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                    }
                    else
                    {
                    foreach (var item in Model.Where(x => x.Id_Tipo_Reconocimiento == 4))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"odd pointer\" data-id=\"");
#nullable restore
#line 199 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                                                Write(item.Id_Comp_Reconocimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <td width=\"30%\">\r\n                            ");
#nullable restore
#line 201 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                       Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 10560, "\"", 10596, 1);
#nullable restore
#line 202 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 10568, item.Id_Tipo_Reconocimiento, 10568, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""Tipo"" />
                        </td>
                        <td>
                            <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                                <div class=""form-group"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 10915, "\"", 10934, 1);
#nullable restore
#line 207 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 10923, item.Largo, 10923, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Largo"" max=""999999"" min=""-999999"" maxlength=""6"" oninput=""fMaxLength(this)"">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                                <div class=""form-group"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 11431, "\"", 11450, 1);
#nullable restore
#line 214 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 11439, item.Ancho, 11439, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Ancho"" max=""999999"" min=""-999999"" maxlength=""6"" oninput=""fMaxLength(this)"">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                                <div class=""form-group"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 11947, "\"", 11972, 1);
#nullable restore
#line 221 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 11955, item.Profundidad, 11955, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"number\" class=\"form-control\" name=\"Altura\" max=\"999999\" min=\"-999999\" maxlength=\"6\" oninput=\"fMaxLength(this)\">\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 226 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                    }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>

        <div class=""table-responsive"">
            <table class=""table table-striped jambo_table bulk_action"" style=""margin-bottom: 0px !important"">
                <thead>
                    <tr class=""headings"">
                        <th class=""column-title"">Nombre</th>
                        <th class=""column-title"">Largo </th>
                        <th class=""column-title"">Ancho</th>
                    </tr>
                </thead>
                <tbody id=""ajuste5"">
");
#nullable restore
#line 242 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                     if (!Model.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"even pointer\">\r\n                        <td class=\" \" colspan=\"3\">\r\n                            No existe registros\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 249 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                    }
                    else
                    {
                    foreach (var item in Model.Where(x => x.Id_Tipo_Reconocimiento == 5))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"odd pointer\" data-id=\"");
#nullable restore
#line 254 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                                                Write(item.Id_Comp_Reconocimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <td width=\"30%\">\r\n                            ");
#nullable restore
#line 256 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                       Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 13511, "\"", 13547, 1);
#nullable restore
#line 257 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 13519, item.Id_Tipo_Reconocimiento, 13519, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""Tipo"" />
                        </td>
                        <td>
                            <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                                <div class=""form-group"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 13866, "\"", 13885, 1);
#nullable restore
#line 262 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 13874, item.Largo, 13874, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Largo"" max=""999999"" min=""-999999"" maxlength=""6"" oninput=""fMaxLength(this)"">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                                <div class=""form-group"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 14382, "\"", 14401, 1);
#nullable restore
#line 269 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 14390, item.Ancho, 14390, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"number\" class=\"form-control\" name=\"Ancho\" max=\"999999\" min=\"-999999\" maxlength=\"6\" oninput=\"fMaxLength(this)\">\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 274 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                    }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>


    <!--   <h1 class=""grupoT"">MINERÍA SUPERFICIAL</h1> -->
    <div id=""superficial"" class=""table-responsive divOculto"" style=""display: none"">
        <table class=""table table-striped jambo_table bulk_action"" style=""margin-bottom: 0px !important"">
            <thead>
                <tr class=""headings"">
                    <th class=""column-title"">Nombre</th>
                    <th class=""column-title"">Largo </th>
                    <th class=""column-title"">Ancho</th>
                    <th class=""column-title"">Profundidad</th>
                    <th class=""column-title"">Área</th>
                </tr>
            </thead>
            <tbody id=""ajuste"">
");
#nullable restore
#line 295 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                 if (!Model.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"even pointer\">\r\n                    <td class=\" \" colspan=\"5\">\r\n                        No existe registros\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 302 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                }
                else
                {
                foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"odd pointer\" data-id=\"");
#nullable restore
#line 307 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                                            Write(item.Id_Comp_Reconocimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    <td width=\"30%\">\r\n                        ");
#nullable restore
#line 309 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                   Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 16034, "\"", 16070, 1);
#nullable restore
#line 310 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 16042, item.Id_Tipo_Reconocimiento, 16042, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""Tipo"" />
                    </td>
                    <td>
                        <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                            <div class=""form-group"">
                                <input");
            BeginWriteAttribute("value", " value=\"", 16369, "\"", 16388, 1);
#nullable restore
#line 315 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 16377, item.Largo, 16377, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Largo"" max=""999999"" min=""-999999"" maxlength=""6"" oninput=""fMaxLength(this)"">
                            </div>
                        </div>
                    </td>
                    <td>
                        <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                            <div class=""form-group"">
                                <input");
            BeginWriteAttribute("value", " value=\"", 16857, "\"", 16876, 1);
#nullable restore
#line 322 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 16865, item.Ancho, 16865, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Ancho"" max=""999999"" min=""-999999"" maxlength=""6"" oninput=""fMaxLength(this)"">
                            </div>
                        </div>
                    </td>
                    <td>
                        <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                            <div class=""form-group"">
                                <input");
            BeginWriteAttribute("value", " value=\"", 17345, "\"", 17370, 1);
#nullable restore
#line 329 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 17353, item.Profundidad, 17353, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Altura"" max=""999999"" min=""-999999"" maxlength=""6"" oninput=""fMaxLength(this)"">
                            </div>
                        </div>
                    </td>
                    <td>
                        <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                            <div class=""form-group"">
                                <input");
            BeginWriteAttribute("value", " value=\"", 17840, "\"", 17858, 1);
#nullable restore
#line 336 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 17848, item.Area, 17848, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"number\" class=\"form-control\" name=\"Altura\" max=\"999999\" min=\"-999999\" maxlength=\"6\" oninput=\"fMaxLength(this)\">\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 341 "D:\fullshito\Fuentes\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <br>\r\n    <br>\r\n    <div class=\"clearfix\"></div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Minem.Sgpam.TransporteDatos.DtoEntidades.Comp_ReconocimientoDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591