#pragma checksum "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09c227623dea6c648a73aece32c743ecca30b918"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09c227623dea6c648a73aece32c743ecca30b918", @"/Views/RegistrarPAM/_ReconocimientoVisual.cshtml")]
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
#line 19 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                     if (!Model.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"even pointer\">\r\n                        <td class=\" \" colspan=\"4\">\r\n                            No existe registros\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 26 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
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
#line 31 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                                                Write(item.Id_Comp_Reconocimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <td width=\"30%\">\r\n                            ");
#nullable restore
#line 33 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                       Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1507, "\"", 1543, 1);
#nullable restore
#line 34 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
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
#line 39 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 1870, item.Base, 1870, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Base"" max=""9999999"" min=""-9999999"" maxlength=""7"" oninput=""fMaxLength(this)"">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                                <div class=""form-group"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 2378, "\"", 2398, 1);
#nullable restore
#line 46 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 2386, item.Altura, 2386, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Altura"" max=""99999.99"" min=""-99999.99"" maxlength=""7"" oninput=""fMaxLength(this)"">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                                <div class=""form-group"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 2900, "\"", 2925, 1);
#nullable restore
#line 53 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 2908, item.Profundidad, 2908, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Profundidad"" max=""9999.99"" min=""-9999.99"" maxlength=""7"" oninput=""fMaxLength(this)"">
                                </div>
                            </div>
                        </td>
                    </tr>
");
#nullable restore
#line 58 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
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
#line 75 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                     if (!Model.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"even pointer\">\r\n                        <td class=\" \" colspan=\"4\">\r\n                            No existe registros\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 82 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
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
#line 87 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                                                Write(item.Id_Comp_Reconocimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <td width=\"30%\">\r\n                            ");
#nullable restore
#line 89 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                       Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 4538, "\"", 4574, 1);
#nullable restore
#line 90 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 4546, item.Id_Tipo_Reconocimiento, 4546, 28, false);

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
            BeginWriteAttribute("value", " value=\"", 4893, "\"", 4912, 1);
#nullable restore
#line 95 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 4901, item.Largo, 4901, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Largo"" max=""99999999"" min=""-99999999"" maxlength=""8"" oninput=""fMaxLength(this)"">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                                <div class=""form-group"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 5413, "\"", 5432, 1);
#nullable restore
#line 102 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 5421, item.Ancho, 5421, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Ancho"" max=""99999999"" min=""-99999999"" maxlength=""8"" oninput=""fMaxLength(this)"">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                                <div class=""form-group"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 5933, "\"", 5958, 1);
#nullable restore
#line 109 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 5941, item.Profundidad, 5941, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Profundidad"" max=""9999.99"" min=""-9999.99"" maxlength=""7"" oninput=""fMaxLength(this)"">
                                </div>
                            </div>
                        </td>
                    </tr>
");
#nullable restore
#line 114 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
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
#line 131 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                     if (!Model.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"even pointer\">\r\n                        <td class=\" \" colspan=\"4\">\r\n                            No existe registros\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 138 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
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
#line 143 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                                                Write(item.Id_Comp_Reconocimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <td width=\"30%\">\r\n                            ");
#nullable restore
#line 145 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                       Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 7571, "\"", 7607, 1);
#nullable restore
#line 146 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 7579, item.Id_Tipo_Reconocimiento, 7579, 28, false);

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
            BeginWriteAttribute("value", " value=\"", 7926, "\"", 7944, 1);
#nullable restore
#line 151 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 7934, item.Base, 7934, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Base"" max=""9999999"" min=""-9999999"" maxlength=""7"" oninput=""fMaxLength(this)"">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                                <div class=""form-group"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 8442, "\"", 8462, 1);
#nullable restore
#line 158 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 8450, item.Altura, 8450, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Altura"" max=""99999.99"" min=""-99999.99"" maxlength=""7"" oninput=""fMaxLength(this)"">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                                <div class=""form-group"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 8964, "\"", 8989, 1);
#nullable restore
#line 165 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 8972, item.Profundidad, 8972, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Profundidad"" max=""9999.99"" min=""-9999.99"" maxlength=""7"" oninput=""fMaxLength(this)"">
                                </div>
                            </div>
                        </td>
                    </tr>
");
#nullable restore
#line 170 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
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
#line 187 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                     if (!Model.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"even pointer\">\r\n                        <td class=\" \" colspan=\"4\">\r\n                            No existe registros\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 194 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
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
#line 199 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                                                Write(item.Id_Comp_Reconocimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <td width=\"30%\">\r\n                            ");
#nullable restore
#line 201 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                       Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 10602, "\"", 10638, 1);
#nullable restore
#line 202 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 10610, item.Id_Tipo_Reconocimiento, 10610, 28, false);

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
            BeginWriteAttribute("value", " value=\"", 10957, "\"", 10976, 1);
#nullable restore
#line 207 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 10965, item.Largo, 10965, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Largo"" max=""99999999"" min=""-99999999"" maxlength=""8"" oninput=""fMaxLength(this)"">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                                <div class=""form-group"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 11477, "\"", 11496, 1);
#nullable restore
#line 214 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 11485, item.Ancho, 11485, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Ancho"" max=""99999999"" min=""-99999999"" maxlength=""8"" oninput=""fMaxLength(this)"">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                                <div class=""form-group"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 11997, "\"", 12022, 1);
#nullable restore
#line 221 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 12005, item.Profundidad, 12005, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Profundidad"" max=""9999.99"" min=""-9999.99"" maxlength=""7"" oninput=""fMaxLength(this)"">
                                </div>
                            </div>
                        </td>
                    </tr>
");
#nullable restore
#line 226 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
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
#line 242 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                     if (!Model.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"even pointer\">\r\n                        <td class=\" \" colspan=\"3\">\r\n                            No existe registros\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 249 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
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
#line 254 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                                                Write(item.Id_Comp_Reconocimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <td width=\"30%\">\r\n                            ");
#nullable restore
#line 256 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                       Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 13568, "\"", 13604, 1);
#nullable restore
#line 257 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 13576, item.Id_Tipo_Reconocimiento, 13576, 28, false);

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
            BeginWriteAttribute("value", " value=\"", 13923, "\"", 13942, 1);
#nullable restore
#line 262 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 13931, item.Largo, 13931, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Largo"" max=""99999999"" min=""-99999999"" maxlength=""8"" oninput=""fMaxLength(this)"">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                                <div class=""form-group"">
                                    <input");
            BeginWriteAttribute("value", " value=\"", 14443, "\"", 14462, 1);
#nullable restore
#line 269 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 14451, item.Ancho, 14451, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Ancho"" max=""99999999"" min=""-99999999"" maxlength=""8"" oninput=""fMaxLength(this)"">
                                </div>
                            </div>
                        </td>
                    </tr>
");
#nullable restore
#line 274 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
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
#line 295 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                 if (!Model.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"even pointer\">\r\n                    <td class=\" \" colspan=\"5\">\r\n                        No existe registros\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 302 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
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
#line 307 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                                            Write(item.Id_Comp_Reconocimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    <td width=\"30%\">\r\n                        ");
#nullable restore
#line 309 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
                   Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 16099, "\"", 16135, 1);
#nullable restore
#line 310 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 16107, item.Id_Tipo_Reconocimiento, 16107, 28, false);

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
            BeginWriteAttribute("value", " value=\"", 16434, "\"", 16453, 1);
#nullable restore
#line 315 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 16442, item.Largo, 16442, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Largo"" max=""99999999"" min=""-99999999"" maxlength=""8"" oninput=""fMaxLength(this)"">
                            </div>
                        </div>
                    </td>
                    <td>
                        <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                            <div class=""form-group"">
                                <input");
            BeginWriteAttribute("value", " value=\"", 16926, "\"", 16945, 1);
#nullable restore
#line 322 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 16934, item.Ancho, 16934, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Ancho"" max=""99999999"" min=""-99999999"" maxlength=""8"" oninput=""fMaxLength(this)"">
                            </div>
                        </div>
                    </td>
                    <td>
                        <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                            <div class=""form-group"">
                                <input");
            BeginWriteAttribute("value", " value=\"", 17418, "\"", 17443, 1);
#nullable restore
#line 329 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 17426, item.Profundidad, 17426, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number"" class=""form-control"" name=""Profundidad"" max=""9999.99"" min=""-9999.99"" maxlength=""7"" oninput=""fMaxLength(this)"">
                            </div>
                        </div>
                    </td>
                    <td>
                        <div class=""col-md-12 col-sm-12 col-xs-12"" style=""padding-left: 5px; padding-right: 5px; margin-bottom: 5px;"">
                            <div class=""form-group"">
                                <input");
            BeginWriteAttribute("value", " value=\"", 17920, "\"", 17938, 1);
#nullable restore
#line 336 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
WriteAttributeValue("", 17928, item.Area, 17928, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"number\" class=\"form-control\" name=\"Area\" max=\"9999999.99\" min=\"-9999999.99\" maxlength=\"9\" oninput=\"fMaxLength(this)\">\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 341 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\RegistrarPAM\_ReconocimientoVisual.cshtml"
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