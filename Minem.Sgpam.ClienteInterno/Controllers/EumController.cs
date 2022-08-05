using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<EumController> Logger;
        public IConfiguration Configuration { get; }

        public EumController(IConfiguration vIConfiguration, ILogger<EumController> vILogger)
        {
            Configuration = vIConfiguration;
            Logger = vILogger;
        }


        public async Task<IActionResult> Index(string vNombreEUM = "", string vUbigeo = "0")
        {
            try
            {
                ListarEumDTO vRecord = new ListarEumDTO();
                vRecord.ListaEum = await Services<MaestraDTO>.Listar("Eum/ListarPaginadoMaestraDTO?vFiltro=" + vNombreEUM + "&vUbigeo=" + vUbigeo + "&vNumPag=" + 1 + "&vCantRegxPag=" + 10);
                vRecord.ListaUbigeo = await Services<Ubigeo_IneiDTO>.Listar("Ubigeo/List_Ubigeo_Inei");                //Logger.LogInformation("PASO UBIGEO");
                ViewBag.Ubigeo = vRecord.ListaUbigeo;
                return View(vRecord);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message, ex);
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> AgregarEditar(int vId = 0)
        {
            try
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

                return View(vRecord);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message, ex);
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> AgregarEditar(MaestraDTO vModel)
        {
            try
            {
                vModel.Fec_Ingreso = vModel.Fec_Modifica = DateTime.Now;
                vModel.Usu_Ingreso = vModel.Usu_Modifica = Constantes.GuestUser;
                vModel.Ip_Ingreso = vModel.Ip_Modifica = DnsFullNet.GetIp();
                if (ModelState.IsValid)
                {
                    vModel = await Services<MaestraDTO>.Grabar("Eum/Save", vModel);
                    return Ok(new ComponentResultModel(vModel?.Id_Eum ?? 0));
                }
                else
                {
                    return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
                }
                //return View(vModel);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message, ex);
                throw;
            }
        }



        [HttpPost]
        public async Task<IActionResult> CreateComponent(int vIdEum, int vIdTipo)
        {
            try
            {
                ComponenteDTO vRegistro = new ComponenteDTO
                {
                    Id_Componente = 0,
                    Id_Eum = vIdEum,
                    Id_Tipo_Pam = vIdTipo,
                    Flg_Estado = Constantes.Activo,
                    Fec_Ingreso = DateTime.Now,
                    Fec_Modifica = DateTime.Now,
                    Usu_Ingreso = Constantes.GuestUser,
                    Usu_Modifica = Constantes.GuestUser,
                    Ip_Ingreso = DnsFullNet.GetIp(),
                    Ip_Modifica = DnsFullNet.GetIp()
                };

                vRegistro = await Services<ComponenteDTO>.Grabar("Componente/Save", vRegistro);
                return Json(new ComponentResultModel { Operation = vRegistro.Id_Componente > 0 ? Constantes.Ok : Constantes.Error, Key = vRegistro.Id_Componente });
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message, ex);
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> RemoveComponent(int vId)
        {
            try
            {
                ComponenteDTO vRegistro = new ComponenteDTO
                {
                    Id_Componente = vId,
                    Flg_Estado = Constantes.Activo,
                    Fec_Ingreso = DateTime.Now,
                    Fec_Modifica = DateTime.Now,
                    Usu_Ingreso = Constantes.GuestUser,
                    Usu_Modifica = Constantes.GuestUser,
                    Ip_Ingreso = DnsFullNet.GetIp(),
                    Ip_Modifica = DnsFullNet.GetIp()
                };
                bool vResult;
                vResult = await Services<ComponenteDTO>.Eliminar("Componente/Remove", vRegistro);
                return Json(new ComponentResultModel { Operation = vResult ? Constantes.Ok : Constantes.Error });
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message, ex);
                throw;
            }
        }



        #region Inspeccion
        [HttpGet]
        public async Task<IActionResult> CrearInspeccion(int vIdEum)
        {
            try
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
            catch (Exception ex)
            {
                Logger.LogError(ex.Message, ex);
                throw;
            }
        }

        [HttpPost]
        public async Task<JsonResult> GrabarInspeccion(Eum_InspeccionDTO vEum_Inspeccion)
        {
            try
            {
                vEum_Inspeccion.Flg_Estado = Constantes.Activo;
                vEum_Inspeccion.Fec_Ingreso = vEum_Inspeccion.Fec_Modifica = DateTime.Now;
                vEum_Inspeccion.Usu_Ingreso = vEum_Inspeccion.Usu_Modifica = Constantes.GuestUser;
                vEum_Inspeccion.Ip_Ingreso = vEum_Inspeccion.Ip_Modifica = DnsFullNet.GetIp();
                if (ModelState.IsValid)
                {
                    vEum_Inspeccion = await Services<Eum_InspeccionDTO>.Grabar("Inspeccion/Save", vEum_Inspeccion);
                    return Json(new ComponentResultModel { Operation = vEum_Inspeccion.Id_Eum_Inspeccion > 0 ? Constantes.Ok : Constantes.Error });
                }
                else
                    return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message, ex);
                throw;
            }
        }

        [HttpPost]
        public async Task<JsonResult> RemoveInspeccion(int vId)
        {
            try
            {
                Eum_InspeccionDTO vRegistro = new Eum_InspeccionDTO
                {
                    Id_Eum_Inspeccion = vId,
                    Flg_Estado = Constantes.Inactivo,
                    Fec_Modifica = DateTime.Now,
                    Usu_Modifica = Constantes.GuestUser,
                    Ip_Modifica = DnsFullNet.GetIp()
                };
                if (ModelState.IsValid)
                {
                    bool vResult;
                    vResult = await Services<Eum_InspeccionDTO>.Eliminar("Inspeccion/Remove", vRegistro);
                    return Json(new ComponentResultModel { Operation = vResult ? Constantes.Ok : Constantes.Error });
                }
                else
                    return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message, ex);
                throw;
            }
        }
        #endregion



        #region EumOperacion
        [HttpGet]
        public async Task<IActionResult> CrearTipoOperacion(int vIdEum)
        {
            try
            {
                RegistrarTipoOperacionDTO vRegistro1 = new RegistrarTipoOperacionDTO();
                vRegistro1.ListaTipoOperacion = await Services<Tipo_OperacionDTO>.Listar("TipoOperacion/ListSinIdEum?vIdEum=" + vIdEum);
                //vRegistro.Id_Eum =  vIdEum;
                RegistrarEumOperacionDTO vRegistro = new RegistrarEumOperacionDTO();
                List<Eum_OperacionDTO> vLista = new List<Eum_OperacionDTO>();
                Eum_OperacionDTO vEum_Operacion;
                foreach (var item in vRegistro1.ListaTipoOperacion)
                {
                    vEum_Operacion = new Eum_OperacionDTO();
                    vEum_Operacion.Id_Eum_Operacion = 0;
                    vEum_Operacion.Id_Eum = vIdEum;
                    vEum_Operacion.Id_Tipo_Operacion = item.Id_Tipo_Operacion;
                    vEum_Operacion.Tipo_Operacion = item.Descripcion;
                    vLista.Add(vEum_Operacion);
                }
                vRegistro.ListaEumOperacion = vLista;
                return PartialView("_ModalTipoOperacion", vRegistro);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message, ex);
                throw;
            }
        }

        [HttpPost]
        public async Task<JsonResult> GrabarTipoOperacion(List<Eum_OperacionDTO> vLista)
        {
            //int res = 0;
            if (ModelState.IsValid)
            {
                Eum_OperacionDTO vEum_Operacion = new Eum_OperacionDTO();
                //foreach (Tipo_OperacionDTO item in vLista)
                //{
                //    vEum_Operacion = new Eum_OperacionDTO();
                //    vEum_Operacion.Id_Eum_Operacion = 0;
                //    vEum_Operacion.Id_Eum = 10;
                //    vEum_Operacion.Id_Tipo_Operacion = item.Id_Tipo_Operacion;
                //    vEum_Operacion.Flg_Estado = Constantes.Activo;
                //    vEum_Operacion.Fec_Ingreso = vEum_Operacion.Fec_Modifica = DateTime.Now;
                //    vEum_Operacion.Usu_Ingreso = vEum_Operacion.Usu_Modifica = "MSALVADOR";
                //    vEum_Operacion.Ip_Ingreso = vEum_Operacion.Ip_Modifica = DnsFullNet.GetIp();
                //    vEum_Operacion = await Services<Eum_OperacionDTO>.Grabar("EumOperacion/Save", vEum_Operacion);
                //}
                return Json(new ComponentResultModel { Operation = vEum_Operacion.Id_Eum_Operacion > 0 ? Constantes.Ok : Constantes.Error });

                //foreach (Eum_OperacionDTO item in vLista)
                //{
                //    item.Flg_Estado = Constantes.Activo;
                //    item.Fec_Ingreso = item.Fec_Modifica = DateTime.Now;
                //    item.Usu_Ingreso = item.Usu_Modifica = "MSALVADOR";
                //    item.Ip_Ingreso = item.Ip_Modifica = DnsFullNet.GetIp();
                //    await Services<Eum_OperacionDTO>.Grabar("EumOperacion/Save", item);
                //    res = 1; 
                //    //new ComponentResultModel { Operation = item.Id_Eum_Operacion > 0 ? Constantes.Ok : Constantes.Error };
                //}
                //return Json(new ComponentResultModel { Operation = res > 0 ? Constantes.Ok : Constantes.Error });
            }
            else
            {
                return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
            }

        }

        [HttpPost]
        public async Task<JsonResult> RemoveEumOperacion(int vId)
        {
            try
            {
                Eum_OperacionDTO vRegistro = new Eum_OperacionDTO
                {
                    Id_Eum_Operacion = vId,
                    Flg_Estado = Constantes.Inactivo,
                    Fec_Modifica = DateTime.Now,
                    Usu_Modifica = Constantes.GuestUser,
                    Ip_Modifica = DnsFullNet.GetIp()
                };
                if (ModelState.IsValid)
                {
                    bool vResult;
                    vResult = await Services<Eum_OperacionDTO>.Eliminar("EumOperacion/Remove", vRegistro);
                    return Json(new ComponentResultModel { Operation = vResult ? Constantes.Ok : Constantes.Error });
                }
                else
                    return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message, ex);
                throw;
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
            vInfo_Grafica.Usu_Ingreso = vInfo_Grafica.Usu_Modifica = Constantes.GuestUser;
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
                                var vCarpetaLF = Configuration.GetValue<string>("DirectoryLFEumIG");
                                string vResult = await ServicesLF.ObtenerProceso("SubirArchivo?vCarpeta=" + vCarpetaLF + "&vRutaArchivo=" + vInfo_Grafica.Ruta_Imagen + "&vNombreArchivo=" + vInfo_Grafica.Nombre_Imagen);
                                if (vResult != Constantes.Error)
                                {
                                    vInfo_Grafica.Id_LaserFiche = Convert.ToInt64(vResult.Replace("\"", ""));
                                    vInfo_Grafica = await Services<Eum_Info_GraficaDTO>.Grabar("InfoGrafica/Save", vInfo_Grafica);
                                    return Json(new ComponentResultModel { Operation = vInfo_Grafica.Id_Eum_Info_Grafica > 0 ? Constantes.Ok : Constantes.Error });
                                }
                                else
                                {
                                    return Json(new ComponentResultModel() { Type = TipoErr.LASERFICHE });
                                }
                                //vInfo_Grafica = await Services<Eum_Info_GraficaDTO>.Grabar("InfoGrafica/Save", vInfo_Grafica);
                                //return Json(new ComponentResultModel { Operation = vInfo_Grafica.Id_Eum_Info_Grafica > 0 ? Constantes.Ok : Constantes.Error });
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
            vInfo_Descargo.Usu_Ingreso = vInfo_Descargo.Usu_Modifica = Constantes.GuestUser;
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
                                var vCarpetaLF = Configuration.GetValue<string>("DirectoryLFEumID");
                                string vResult = await ServicesLF.ObtenerProceso("SubirArchivo?vCarpeta=" + vCarpetaLF + "&vRutaArchivo=" + vInfo_Descargo.Ruta_Documento + "&vNombreArchivo=" + vInfo_Descargo.Nombre_Documento);
                                if (vResult != Constantes.Error)
                                {
                                    vInfo_Descargo.Id_LaserFiche = Convert.ToInt64(vResult.Replace("\"", ""));
                                    vInfo_Descargo = await Services<Eum_Info_DescargoDTO>.Grabar("InfoDescargo/Save", vInfo_Descargo);
                                    return Json(new ComponentResultModel { Operation = vInfo_Descargo.Id_Eum_Info_Descargo > 0 ? Constantes.Ok : Constantes.Error });
                                }
                                else
                                {
                                    return Json(new ComponentResultModel() { Type = TipoErr.LASERFICHE });
                                }
                                //vInfo_Descargo = await Services<Eum_Info_DescargoDTO>.Grabar("InfoDescargo/Save", vInfo_Descargo);
                                //return Json(new ComponentResultModel { Operation = vInfo_Descargo.Id_Eum_Info_Descargo > 0 ? Constantes.Ok : Constantes.Error });
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

        [HttpPost]
        public async Task<JsonResult> RemoveEumDescargo(int vId)
        {
            try
            {
                Eum_Info_DescargoDTO vRegistro = new Eum_Info_DescargoDTO
                {
                    Id_Eum_Info_Descargo = vId,
                    Flg_Estado = Constantes.Inactivo,
                    Fec_Modifica = DateTime.Now,
                    Usu_Modifica = Constantes.GuestUser,
                    Ip_Modifica = DnsFullNet.GetIp()
                };
                if (ModelState.IsValid)
                {
                    bool vResult;
                    vResult = await Services<Eum_Info_DescargoDTO>.Eliminar("InfoDescargo/Remove", vRegistro);
                    return Json(new ComponentResultModel { Operation = vResult ? Constantes.Ok : Constantes.Error });
                }
                else
                    return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message, ex);
                throw;
            }
        }
        #endregion



        #region Informe
        [HttpGet]
        public IActionResult CrearInforme(int vIdEum)
        {
            //Eum_Info_GraficaDTO vRegistro = await Services<Eum_Info_GraficaDTO>.Obtener("InfoGrafica/Get?vId=" + vIdEum);
            //if (vIdEum == 0)
            Eum_InformeDTO vRegistro = new Eum_InformeDTO { Fec_Ingreso = DateTime.Now, Id_Eum = vIdEum };
            return PartialView("_ModalInforme", vRegistro);
        }

        [HttpGet]
        public async Task<IActionResult> DescargarInformePam(int vKey)
        {
            try
            {
                var vLista = await Services<ReportePamDTO>.Obtener("Reportes/GetReportPam?vId=" + vKey);

                string vRouteTemplate = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, Configuration.GetSection("Reports:DirectorySource").Value));
                string vRouteDestination = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, Configuration.GetSection("Reports:DirectoryDestination").Value));
                string vFileTemplate = vRouteTemplate + Configuration.GetSection("Reports:TemplatePam").Value;
                string vReportName = Configuration.GetSection("Reports:ReportName").Value + DateTime.Now.ToString("yyyyMMddHHmmssff") + ".docx";
                string vReportFile = vRouteDestination + @"\" + vReportName;

                System.IO.File.Copy(vFileTemplate, vReportFile);
                Reports.ReplaceLabels(vReportFile, vLista);

                var fileStream = System.IO.File.OpenRead(vReportFile);
                return File(fileStream, "application/vnd.ms-word", vReportName);
            }
            catch (Exception ex)
            {
                return Json("ERROR");
            }
        }
        #endregion


    }
}
