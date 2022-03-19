using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Minem.Sgpam.ClienteInterno.Helpers;
using Minem.Sgpam.ClienteInterno.Models;
using Minem.Sgpam.InfraEstructura;
using Minem.Sgpam.InfraEstructura.Enumerados;
using Minem.Sgpam.InfraEstructura.Utilitarios;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Minem.Sgpam.ClienteInterno.Controllers
{
    public class EumController : Controller
    {
        public IConfiguration Configuration { get; }

        public EumController(IConfiguration vIConfiguration)
        {
            Configuration = vIConfiguration;
        }


        public async Task<IActionResult> Index(string vNombreEUM = "")
        {
            ListarEumDTO vRecord = new ListarEumDTO();
            vRecord.ListaEum = await Services<MaestraDTO>.Listar("Eum/ListarPaginadoMaestraDTO?vFiltro=" + vNombreEUM + "&vNumPag=" + 5 + "&vCantRegxPag=" + 2);

            return View(vRecord);
        }

        [HttpGet]
        public async Task<IActionResult> AgregarEditar(int vId = 0)
        {
            RegistrarEumDTO vRecord = new RegistrarEumDTO();

            vRecord = await Services<RegistrarEumDTO>.Obtener("Eum/GetFull?vId=" + vId);
            if (vId == 0)
                vRecord.Eum = new MaestraDTO();

            ViewBag.CboTipoPam = vRecord.CboTipoPam.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Tipo_Pam.ToString() };
            });
            ViewBag.CboTipoOperacion = vRecord.CboTipoOperacion.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Tipo_Operacion.ToString() };
            });
            ViewBag.CboTipoSustancia = vRecord.CboTipoSustancia.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Tipo_Sustancia.ToString() };
            });
            ViewBag.CboConflictoSocial = vRecord.CboConflictoSocial.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Conflicto_Social.ToString() };
            });
            //ViewBag.CboCuencaPrincipal = Enum.GetValues(typeof(CuencaPrincipal)).Cast<CuencaPrincipal>().ToList().ConvertAll(x =>
            //{
            //    return new SelectListItem() { Text = x.ToString(), Value = ((int)x).ToString() };
            //});

            return View(vRecord);
        }

        [HttpPost]
        public async Task<IActionResult> AgregarEditar(MaestraDTO vEum)
        {
            vEum.Fec_Ingreso = vEum.Fec_Modifica = DateTime.Now;
            vEum.Usu_Ingreso = vEum.Usu_Modifica = "JPEREZ";
            vEum.Ip_Ingreso = vEum.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vEum = await Services<MaestraDTO>.Grabar("Eum/Save", vEum);
                return RedirectToAction(nameof(Index));
                //return Ok(new ComponentResultModel(vModel?.Id_Componente ?? 0));
            }
            return View(vEum);
        }


        [HttpPost]
        public async Task<IActionResult> CreateComponent(int vIdEum, int vIdTipo)
        {
            ComponenteDTO vRegistro = new ComponenteDTO
            {
                Id_Componente = 0,
                Id_Eum = vIdEum,
                Id_Tipo_Pam = vIdTipo,
                Flg_Estado = Constantes.Activo,
                Fec_Ingreso = DateTime.Now,
                Fec_Modifica = DateTime.Now,
                Usu_Ingreso = "ORODRIGUEZ",
                Usu_Modifica = "ORODRIGUEZ",
                Ip_Ingreso = DnsFullNet.GetIp(),
                Ip_Modifica = DnsFullNet.GetIp()
            };

            vRegistro = await Services<ComponenteDTO>.Grabar("Componente/Save", vRegistro);
            return Json(new ComponentResultModel { Operation = vRegistro.Id_Componente > 0 ? Constantes.Ok : Constantes.Error, Key = vRegistro.Id_Componente });
        }

        [HttpPost]
        public async Task<IActionResult> RemoveComponent(int vId)
        {
            ComponenteDTO vRegistro = new ComponenteDTO
            {
                Id_Componente = vId,
                Flg_Estado = Constantes.Activo,
                Fec_Ingreso = DateTime.Now,
                Fec_Modifica = DateTime.Now,
                Usu_Ingreso = "ORODRIGUEZ",
                Usu_Modifica = "ORODRIGUEZ",
                Ip_Ingreso = DnsFullNet.GetIp(),
                Ip_Modifica = DnsFullNet.GetIp()
            };
            bool vResult;
            vResult = await Services<ComponenteDTO>.Eliminar("Componente/Remove", vRegistro);
            return Json(new ComponentResultModel { Operation = vResult ? Constantes.Ok : Constantes.Error });
        }



        #region Inspeccion
        [HttpGet]
        public async Task<IActionResult> CrearInspeccion(int vIdEum)
        {
            RegistrarEumInspeccionDTO vRecord = await Services<RegistrarEumInspeccionDTO>.Obtener("Inspeccion/GetFull?vId=" + 0);
            vRecord.Eum_Inspeccion = new Eum_InspeccionDTO { Fecha_Inspeccion = DateTime.Now, Id_Eum = vIdEum };

            //ViewBag.CboTipoClima = vRecord.CboTipoClima.ConvertAll(x =>
            //{
            //    return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Tipo_Clima.ToString() };
            //});
            ViewBag.CboInspector = vRecord.CboInspector.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Nombre_Completo, Value = x.Id_Inspector.ToString() };
            });
            return PartialView("_ModalInspeccion", vRecord.Eum_Inspeccion);
        }

        [HttpPost]
        public async Task<JsonResult> GrabarInspeccion(Eum_InspeccionDTO vEum_Inspeccion)
        {
            vEum_Inspeccion.Flg_Estado = Constantes.Activo;
            vEum_Inspeccion.Fec_Ingreso = vEum_Inspeccion.Fec_Modifica = DateTime.Now;
            vEum_Inspeccion.Usu_Ingreso = vEum_Inspeccion.Usu_Modifica = "MSALVADOR";
            vEum_Inspeccion.Ip_Ingreso = vEum_Inspeccion.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vEum_Inspeccion = await Services<Eum_InspeccionDTO>.Grabar("Inspeccion/Save", vEum_Inspeccion);
                return Json(new ComponentResultModel { Operation = vEum_Inspeccion.Id_Eum_Inspeccion > 0 ? Constantes.Ok : Constantes.Error });
            }
            else
            {
                return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
            }
        }
        #endregion


        #region InfoGrafica
        [HttpGet]
        public IActionResult CrearInfoGrafica(int vIdEum)
        {
            //Eum_Info_GraficaDTO vRegistro = await Services<Eum_Info_GraficaDTO>.Obtener("InfoGrafica/Get?vId=" + vIdEum);
            //if (vIdEum == 0)
            Eum_Info_GraficaDTO vRegistro = new Eum_Info_GraficaDTO { Fec_Ingreso = DateTime.Now, Id_Eum = vIdEum };
            return PartialView("_ModalInfoGrafica", vRegistro);
        }

        [HttpPost]
        [Obsolete]
        public async Task<JsonResult> GrabarInfoGrafica(Eum_Info_GraficaDTO vInfo_Grafica, IFormFile vFile, [FromServices] IHostingEnvironment vHostingEnviroment)
        {
            vInfo_Grafica.Flg_Estado = Constantes.Activo;
            vInfo_Grafica.Fec_Ingreso = vInfo_Grafica.Fec_Modifica = DateTime.Now;
            vInfo_Grafica.Usu_Ingreso = vInfo_Grafica.Usu_Modifica = "MSALVADOR";
            vInfo_Grafica.Ip_Ingreso = vInfo_Grafica.Ip_Modifica = DnsFullNet.GetIp();

            if (vFile != null)
            {
                vInfo_Grafica.Extencion = Path.GetExtension(vFile.FileName).Substring(1);

                if (!string.IsNullOrEmpty(vInfo_Grafica.Extencion) && vInfo_Grafica.Extencion.Length <= 4)
                {
                    string vFileNameEmpty = Path.GetFileNameWithoutExtension(vFile.FileName);

                    if (!string.IsNullOrEmpty(vFileNameEmpty))
                    {
                        vFileNameEmpty = $"{vFileNameEmpty}-{DateTime.Now.ToString("yyyyMMdd-HHmmss")}{Path.GetExtension(vFile.FileName)}";
                        vInfo_Grafica.Nombre_Imagen = vFileNameEmpty;
                        vInfo_Grafica.Tamano = (int)vFile.Length;

                        try
                        {
                            var vDirectorioIG = Configuration.GetValue<string>("DirectoryEumIG");
                            var vDirectory = $"{vHostingEnviroment.WebRootPath}\\{vDirectorioIG}";
                            if (!Directory.Exists(vDirectory)) Directory.CreateDirectory(vDirectory);

                            string vSubDirectory = vInfo_Grafica.Id_Eum.ToString("D9");
                            vDirectory = $"{vDirectory}\\{vSubDirectory}";
                            if (!Directory.Exists(vDirectory)) Directory.CreateDirectory(vDirectory);

                            string vFileName = $"{vDirectory}\\{vFileNameEmpty}";
                            using (FileStream vFileStream = System.IO.File.Create(vFileName))
                            {
                                vFile.CopyTo(vFileStream);
                                vFileStream.Flush();
                            }

                            vInfo_Grafica.Ruta_Imagen = vFileName;

                            if (ModelState.IsValid)
                            {
                                vInfo_Grafica = await Services<Eum_Info_GraficaDTO>.Grabar("InfoGrafica/Save", vInfo_Grafica);
                                return Json(new ComponentResultModel { Operation = vInfo_Grafica.Id_Eum_Info_Grafica > 0 ? Constantes.Ok : Constantes.Error });
                            }
                            else
                            {
                                return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
                            }

                        }
                        catch (Exception)
                        {
                            return Json(new ComponentResultModel());
                        }
                    }
                    else
                    {
                        return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
                    }
                }
                else
                {
                    return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
                }

            }
            else
            {
                return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
            }
        }

        #endregion


        #region InfoDescargo
        [HttpGet]
        public IActionResult CrearInfoDescargo(int vIdEum)
        {
            Eum_Info_DescargoDTO vRegistro = new Eum_Info_DescargoDTO { Fecha_Descargo = DateTime.Now, Id_Eum = vIdEum };
            return PartialView("_ModalInfoDescargo", vRegistro);
        }

        [HttpPost]
        [Obsolete]
        public async Task<JsonResult> GrabarInfoDescargo(Eum_Info_DescargoDTO vInfo_Descargo, IFormFile vFile, [FromServices] IHostingEnvironment vHostingEnviroment)
        {
            vInfo_Descargo.Flg_Estado = Constantes.Activo;
            vInfo_Descargo.Fec_Ingreso = vInfo_Descargo.Fec_Modifica = DateTime.Now;
            vInfo_Descargo.Usu_Ingreso = vInfo_Descargo.Usu_Modifica = "MSALVADOR";
            vInfo_Descargo.Ip_Ingreso = vInfo_Descargo.Ip_Modifica = DnsFullNet.GetIp();

            if (vFile != null)
            {
                vInfo_Descargo.Extencion = Path.GetExtension(vFile.FileName).Substring(1);

                if (!string.IsNullOrEmpty(vInfo_Descargo.Extencion) && vInfo_Descargo.Extencion.Length <= 4)
                {
                    string vFileNameEmpty = Path.GetFileNameWithoutExtension(vFile.FileName);

                    if (!string.IsNullOrEmpty(vFileNameEmpty))
                    {
                        vFileNameEmpty = $"{vFileNameEmpty}-{DateTime.Now.ToString("yyyyMMdd-HHmmss")}{Path.GetExtension(vFile.FileName)}";
                        vInfo_Descargo.Nombre_Documento = vFileNameEmpty;
                        vInfo_Descargo.Tamano = (int)vFile.Length;

                        try
                        {
                            var vDirectorioIG = Configuration.GetValue<string>("DirectoryEumID");
                            var vDirectory = $"{vHostingEnviroment.WebRootPath}\\{vDirectorioIG}";
                            if (!Directory.Exists(vDirectory)) Directory.CreateDirectory(vDirectory);

                            string vSubDirectory = vInfo_Descargo.Id_Eum.ToString("D9");
                            vDirectory = $"{vDirectory}\\{vSubDirectory}";
                            if (!Directory.Exists(vDirectory)) Directory.CreateDirectory(vDirectory);

                            string vFileName = $"{vDirectory}\\{vFileNameEmpty}";
                            using (FileStream vFileStream = System.IO.File.Create(vFileName))
                            {
                                vFile.CopyTo(vFileStream);
                                vFileStream.Flush();
                            }

                            vInfo_Descargo.Ruta_Documento = vFileName;

                            if (ModelState.IsValid)
                            {
                                vInfo_Descargo = await Services<Eum_Info_DescargoDTO>.Grabar("InfoDescargo/Save", vInfo_Descargo);
                                return Json(new ComponentResultModel { Operation = vInfo_Descargo.Id_Eum_Info_Descargo > 0 ? Constantes.Ok : Constantes.Error });
                            }
                            else
                            {
                                return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
                            }

                        }
                        catch (Exception)
                        {
                            return Json(new ComponentResultModel());
                        }
                    }
                    else
                    {
                        return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
                    }
                }
                else
                {
                    return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
                }

            }
            else
            {
                return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
            }
        }


        #endregion


        #region Informe

        #endregion


    }
}
