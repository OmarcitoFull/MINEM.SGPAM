#pragma checksum "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\Expediente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60fc5e899629152d67b16e0f51a3f5d88fd4d53b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Expediente_Index), @"mvc.1.0.view", @"/Views/Expediente/Index.cshtml")]
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
#nullable restore
#line 1 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\Expediente\Index.cshtml"
using Minem.Sgpam.InfraEstructura;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60fc5e899629152d67b16e0f51a3f5d88fd4d53b", @"/Views/Expediente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3de714567e47f746db7c935497043b8a0ac7cf3f", @"/Views/_ViewImports.cshtml")]
    public class Views_Expediente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Minem.Sgpam.TransporteDatos.DtoEntidades.ListarExpedienteDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AgregarEditar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("MyForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Expediente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\Expediente\Index.cshtml"
  
    ViewData["Title"] = "GESTIÓN DE LABORES NO REHABILITADAS – LNR";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60fc5e899629152d67b16e0f51a3f5d88fd4d53b7043", async() => {
                WriteLiteral(@"

    <div class=""row"">

        <div class=""col-md-3 col-sm-12 col-xs-12 form-group"">
            <div class=""form-group"">
                <label class=""control-label col-md-3 col-sm-3 col-xs-12"">Expediente</label>
                <div class=""col-md-9 col-sm-9 col-xs-12"">
                    <input type=""text"" class=""form-control text-uppercase"" name=vNroExp maxlength=""20"">
                </div>
            </div>
        </div>

        <div class=""col-md-6 col-sm-12 col-xs-12 form-group"">
            <div class=""form-group"">
                <label class=""control-label col-md-4 col-sm-4 col-xs-12"">Zona-Concesion-Proyecto</label>
                <div class=""col-md-8 col-sm-8 col-xs-12"">
                    <input type=""text"" class=""form-control text-uppercase"" name=vZona maxlength=""50"">
                </div>
            </div>
        </div>

        <div class=""col-md-2 col-sm-12 col-xs-12 form-group"">
            <div class=""boton"">
                <button type=""submit"">Buscar  <i");
                WriteLiteral(" class=\"fa fa-search\"></i></button>\r\n");
                WriteLiteral(@"            </div>
        </div>

        <div class=""col-md-3 col-sm-12 col-xs-12 form-group"">
            <div class=""form-group"">
                <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""cboDepartamento"">Región:</label>
                <div class=""col-md-9 col-sm-9 col-xs-12"">
                    <select class=""select2_single form-control"" id=""cboDepartamento"" tabindex=""-1"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60fc5e899629152d67b16e0f51a3f5d88fd4d53b8921", async() => {
                    WriteLiteral("Seleccione");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
            </div>
        </div>

        <div class=""col-md-3 col-sm-12 col-xs-12 form-group"">
            <div class=""form-group"">
                <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""cboProvincia"">Provincia:</label>
                <div class=""col-md-9 col-sm-9 col-xs-12"">
                    <select class=""select2_single form-control"" id=""cboProvincia"" tabindex=""-1"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60fc5e899629152d67b16e0f51a3f5d88fd4d53b10737", async() => {
                    WriteLiteral("Seleccione");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
            </div>
        </div>

        <div class=""col-md-4 col-sm-12 col-xs-12 form-group"">
            <div class=""form-group"">
                <label class=""control-label col-md-3 col-sm-3 col-xs-12"" for=""cboDistrito"">Distrito:</label>
                <div class=""col-md-9 col-sm-9 col-xs-12"">
                    <select class=""select2_single form-control"" id=""cboDistrito"" tabindex=""-1"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60fc5e899629152d67b16e0f51a3f5d88fd4d53b12551", async() => {
                    WriteLiteral("Seleccione");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
            </div>
        </div>
    </div>

    <div class=""x_title2"">
        <div align=""center"" class=""titulo-m"">
            <h3>Inventario de LNR</h3>
        </div>
        <ul class=""nav navbar-right panel_toolbox"">
            <li>
                <div class=""boton"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60fc5e899629152d67b16e0f51a3f5d88fd4d53b14239", async() => {
                    WriteLiteral(" Agregar <i class=\"fa fa-plus\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </li>\r\n");
                WriteLiteral("        </ul>\r\n        <div class=\"clearfix\"></div>\r\n    </div>\r\n\r\n");
                WriteLiteral("\r\n    <div id=\"DivInformacionGrafica\">\r\n        ");
#nullable restore
#line 136 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\Expediente\Index.cshtml"
   Write(Html.Partial("_PartialExpediente", Model.ListaExpediente));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n\r\n\r\n");
                WriteLiteral("    <input type=\"hidden\" name=\"vZona\" id=\"vZona\" />\r\n    <input type=\"hidden\" name=\"vUbigeo\" id=\"vUbigeo\" />\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            var IdUbigeo = ");
#nullable restore
#line 150 "D:\fullshito\Fuente\MINEM.SGPAM\Minem.Sgpam.ClienteInterno\Views\Expediente\Index.cshtml"
                      Write(Html.Raw(Json.Serialize(ViewBag.Ubigeo)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
            const dpto = [...new Map(IdUbigeo.map(function (a) { return { id_Departamento: a.id_Departamento, departamento: a.departamento } }).map(a => [a.id_Departamento, a])).values()];
            dpto.sort((a, b) => {
                if (a.departamento.toLowerCase() < b.departamento.toLowerCase()) { return -1; }
                if (a.departamento.toLowerCase() > b.departamento.toLowerCase()) { return 1; }
                return 0;
            });
            dpto.forEach(function (o, t) { $(""#cboDepartamento"").append('<option value=""' + o.id_Departamento + '"">' + o.departamento + ""</option>"") });
            $(""#cboDepartamento"").on(""change"", function () {
                var data = IdUbigeo.filter(o => o.id_Departamento == $(""#cboDepartamento"").val());
                const prov = [...new Map(data.map(function (o) { return { id_Provincia: o.id_Provincia, provincia: o.provincia } }).map(o => [o.id_Provincia, o])).values()];
                prov.sort((a, b) => {
                    if (a.pro");
                WriteLiteral(@"vincia.toLowerCase() < b.provincia.toLowerCase()) { return -1; }
                    if (a.provincia.toLowerCase() > b.provincia.toLowerCase()) { return 1; }
                    return 0;
                });
                $(""#cboProvincia"").empty();
                $(""#cboProvincia"").append('<option value=""0"">Seleccione</option>');
                prov.forEach(function (o, i) { $(""#cboProvincia"").append('<option value=""' + o.id_Provincia + '"">' + o.provincia + ""</option>"") })
                $(""#vUbigeo"").val($(""#cboDepartamento"").val());
            });

            $('#cboProvincia').on('change', function () {
                var data = IdUbigeo.filter(x => x.id_Provincia == $('#cboProvincia').val());
                const dist = [...new Map(data.map(function (o) { return { id_Distrito: o.id_Distrito, distrito: o.distrito } }).map(o => [o.id_Distrito, o])).values()];
                dist.sort((a, b) => {
                    if (a.distrito.toLowerCase() < b.distrito.toLowerCase()) { return -1");
                WriteLiteral(@"; }
                    if (a.distrito.toLowerCase() > b.distrito.toLowerCase()) { return 1; }
                    return 0;
                });
                $('#cboDistrito').empty();
                $('#cboDistrito').append('<option value=""0"">Seleccione</option>');
                dist.forEach(function (o, i) { $('#cboDistrito').append('<option value=""' + o.id_Distrito + '"">' + o.distrito + '</option>') })
                if ($(""#cboProvincia"").val() === '0')
                    $(""#vUbigeo"").val($(""#cboDepartamento"").val());
                else
                    $(""#vUbigeo"").val($(""#cboProvincia"").val());
            });

            $('#cboDistrito').on('change', function () {
                var data = IdUbigeo.filter(x => x.id_Distrito == $('#cboDistrito').val());
                if ($(""#cboDistrito"").val() === '0')
                    $(""#vUbigeo"").val($(""#cboProvincia"").val());
                else
                    $(""#vUbigeo"").val($(""#cboDistrito"").val());
            })");
                WriteLiteral(";\r\n\r\n        });\r\n\r\n\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Minem.Sgpam.TransporteDatos.DtoEntidades.ListarExpedienteDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591