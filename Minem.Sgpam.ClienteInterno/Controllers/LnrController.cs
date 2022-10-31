using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class LnrController : Controller
    {
        private readonly ILogger<LnrController> Logger;
        public IConfiguration Configuration { get; }

        public LnrController(IConfiguration vIConfiguration, ILogger<LnrController> vILogger)
        {
            Configuration = vIConfiguration;
            Logger = vILogger;
        }



















        [HttpGet]
        public async Task<IActionResult> AgregarEditar(int vId = 0, int vIdExpediente = 0)
        {
            try
            {
                RegistrarLnrDTO vRecord = new RegistrarLnrDTO();

                vRecord = await Services<RegistrarLnrDTO>.Obtener("Lnr/GetFull?vId=" + vId);
                if (vId == 0)
                    vRecord.Lnr = new LnrDTO { Id_Expediente = vIdExpediente };

                ViewBag.CboTipoLnr = vRecord.CboTipo.ConvertAll(x =>
                {
                    return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Tipo_Pam.ToString() };
                });
                ViewBag.CboSubTipoLnr = vRecord.CboSubTipo.Where(x => x.Id_Tipo_Pam == vRecord.Lnr.Id_Tipo_Lnr).ToList().ConvertAll(x =>
                {
                    return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Sub_Tipo_Pam.ToString() };
                });

                ViewBag.CboTemporalidad = vRecord.CboTemporalidad.ConvertAll(x =>
                {
                    return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Temporalidad.ToString() };
                });

                ViewBag.CboZona = Enum.GetValues(typeof(Zona)).Cast<Zona>().ToList().ConvertAll(x =>
                {
                    return new SelectListItem() { Text = x.ToString(), Value = ((int)x).ToString() };
                });

                ViewBag.CboRegion = vRecord.CboUbigeo.Select(x => new { x.Id_Departamento, x.Departamento }).Distinct().OrderBy(x => x.Departamento).ToList().ConvertAll(x =>
                {
                    return new SelectListItem() { Text = x.Departamento, Value = x.Id_Departamento.ToString() };
                });

                ViewBag.CboProvincia = vRecord.CboUbigeo.Where(x => x.Id_Departamento == vRecord.Lnr.Id_Region).Select(x => new { x.Id_Provincia, x.Provincia }).Distinct().OrderBy(x => x.Provincia).ToList().ConvertAll(x =>
                {
                    return new SelectListItem() { Text = x.Provincia, Value = x.Id_Provincia.ToString() };
                });

                ViewBag.CboDistrito = vRecord.CboUbigeo.Where(x => x.Id_Provincia == vRecord.Lnr.Id_Provincia).Select(x => new { x.Id_Distrito, x.Distrito }).Distinct().OrderBy(x => x.Distrito).ToList().ConvertAll(x =>
                {
                    return new SelectListItem() { Text = x.Distrito, Value = x.Id_Distrito.ToString() };
                });

                ViewBag.FullUbigeo = vRecord.CboUbigeo.Select(x => new { x.Id_Departamento, x.Departamento, x.Id_Provincia, x.Provincia, x.Id_Distrito, x.Distrito }).Distinct().OrderBy(x => x.Departamento).ThenBy(x => x.Provincia).ThenBy(x => x.Distrito).ToList();

                return View(vRecord);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message, ex);
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> AgregarEditar(LnrDTO vModel)
        {
            try
            {
                vModel.Fec_Ingreso = vModel.Fec_Modifica = DateTime.Now;
                vModel.Usu_Ingreso = vModel.Usu_Modifica = GlobalAppSession.GetCurrentSesion(User);
                vModel.Ip_Ingreso = vModel.Ip_Modifica = DnsFullNet.GetIp();
                if (ModelState.IsValid)
                {
                    vModel = await Services<LnrDTO>.Grabar("Lnr/Save", vModel);
                    return Ok(new ComponentResultModel(vModel?.Id_Lnr ?? 0));
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


        [HttpGet]
        public async Task<IActionResult> Evaluar(int vId = 0, int vIdExpediente = 0)
        {
            RegistrarEvaluacionLnrDTO vRecord = new RegistrarEvaluacionLnrDTO();

            vRecord = await Services<RegistrarEvaluacionLnrDTO>.Obtener("Lnr/Evaluar?vId=" + vId);
            if (vId == 0)
                vRecord.Lnr = new LnrDTO { Id_Expediente = vIdExpediente };

            return View(vRecord);
        }



        #region InfoGrafica
        [HttpGet]
        public IActionResult CrearInfoGrafica(int vIdLnr)
        {
            //Eum_Info_GraficaDTO vRegistro = await Services<Eum_Info_GraficaDTO>.Obtener("InfoGrafica/Get?vId=" + vIdEum);
            //if (vIdEum == 0)
            Lnr_Info_GraficaDTO vRegistro = new Lnr_Info_GraficaDTO { Fec_Ingreso = DateTime.Now, Id_Lnr = vIdLnr };
            return PartialView("_ModalInfoGrafica", vRegistro);
        }

        [HttpPost]
        [Obsolete]
        public async Task<JsonResult> GrabarInfoGrafica(Lnr_Info_GraficaDTO vInfo_Grafica, IFormFile vFile, [FromServices] IHostingEnvironment vHostingEnviroment)
        {
            vInfo_Grafica.Flg_Estado = Constantes.Activo;
            vInfo_Grafica.Fec_Ingreso = vInfo_Grafica.Fec_Modifica = DateTime.Now;
            vInfo_Grafica.Usu_Ingreso = vInfo_Grafica.Usu_Modifica = GlobalAppSession.GetCurrentSesion(User);
            vInfo_Grafica.Ip_Ingreso = vInfo_Grafica.Ip_Modifica = DnsFullNet.GetIp();

            if (vFile != null)
            {
                vInfo_Grafica.Extencion = Path.GetExtension(vFile.FileName).Substring(1);

                if (!string.IsNullOrEmpty(vInfo_Grafica.Extencion) && vInfo_Grafica.Extencion.Length <= 4)
                {
                    if (vInfo_Grafica.Extencion != "jpg" && vInfo_Grafica.Extencion != "png")
                    {
                        return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
                    }

                    string vFileNameEmpty = Path.GetFileNameWithoutExtension(vFile.FileName);

                    if (!string.IsNullOrEmpty(vFileNameEmpty))
                    {
                        vFileNameEmpty = $"{vFileNameEmpty}-{DateTime.Now.ToString("yyyyMMdd-HHmmss")}{Path.GetExtension(vFile.FileName)}";
                        vInfo_Grafica.Nombre_Imagen = vFileNameEmpty;
                        vInfo_Grafica.Tamano = (int)vFile.Length;

                        try
                        {
                            var vDirectorioIG = Configuration.GetValue<string>("DirectoryLnrIG");
                            var vDirectory = $"{vHostingEnviroment.WebRootPath}\\{vDirectorioIG}";
                            if (!Directory.Exists(vDirectory)) Directory.CreateDirectory(vDirectory);

                            string vSubDirectory = vInfo_Grafica.Id_Lnr.ToString("D9");
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
                                var vCarpetaLF = Configuration.GetValue<string>("DirectoryLFLnrIG");
                                string vResult = await ServicesLF.ObtenerProceso("SubirArchivo?vCarpeta=" + vCarpetaLF + "&vRutaArchivo=" + vInfo_Grafica.Ruta_Imagen + "&vNombreArchivo=" + vInfo_Grafica.Nombre_Imagen);
                                if (vResult != Constantes.Error)
                                {
                                    vInfo_Grafica.Id_LaserFiche = Convert.ToInt64(vResult.Replace("\"", ""));
                                    vInfo_Grafica = await Services<Lnr_Info_GraficaDTO>.Grabar("LnrInfoGrafica/Save", vInfo_Grafica);
                                    return Json(new ComponentResultModel { Operation = vInfo_Grafica.Id_Lnr_Info_Grafica > 0 ? Constantes.Ok : Constantes.Error });
                                }
                                else
                                {
                                    return Json(new ComponentResultModel() { Type = TipoErr.LASERFICHE });
                                }
                                //vInfo_Grafica = await Services<Lnr_Info_GraficaDTO>.Grabar("InfoGrafica/Save", vInfo_Grafica);
                                //return Json(new ComponentResultModel { Operation = vInfo_Grafica.Id_Lnr_Info_Grafica > 0 ? Constantes.Ok : Constantes.Error });
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



        #region InfoDocumento
        [HttpGet]
        public IActionResult CrearInfoDocumento(int vIdLnr)
        {
            Lnr_Info_DocumentoDTO vRegistro = new Lnr_Info_DocumentoDTO { Fecha_Documento = DateTime.Now, Id_Lnr = vIdLnr };
            return PartialView("_ModalInfoDocumento", vRegistro);
        }

        [HttpPost]
        [Obsolete]
        public async Task<JsonResult> GrabarInfoDocumento(Lnr_Info_DocumentoDTO vInfo_Documento, IFormFile vFile, [FromServices] IHostingEnvironment vHostingEnviroment)
        {
            vInfo_Documento.Flg_Estado = Constantes.Activo;
            vInfo_Documento.Fec_Ingreso = vInfo_Documento.Fec_Modifica = DateTime.Now;
            vInfo_Documento.Usu_Ingreso = vInfo_Documento.Usu_Modifica = GlobalAppSession.GetCurrentSesion(User);
            vInfo_Documento.Ip_Ingreso = vInfo_Documento.Ip_Modifica = DnsFullNet.GetIp();

            if (vFile != null)
            {
                vInfo_Documento.Extencion = Path.GetExtension(vFile.FileName).Substring(1);

                if (!string.IsNullOrEmpty(vInfo_Documento.Extencion) && vInfo_Documento.Extencion.Length <= 4)
                {
                    if (vInfo_Documento.Extencion != "doc" && vInfo_Documento.Extencion != "docx" && vInfo_Documento.Extencion != "pdf")
                    {
                        return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
                    }

                    string vFileNameEmpty = Path.GetFileNameWithoutExtension(vFile.FileName);

                    if (!string.IsNullOrEmpty(vFileNameEmpty))
                    {
                        vFileNameEmpty = $"{vFileNameEmpty}-{DateTime.Now.ToString("yyyyMMdd-HHmmss")}{Path.GetExtension(vFile.FileName)}";
                        vInfo_Documento.Nombre_Documento = vFileNameEmpty;
                        vInfo_Documento.Tamano = (int)vFile.Length;

                        try
                        {
                            var vDirectorioIG = Configuration.GetValue<string>("DirectoryLnrID");
                            var vDirectory = $"{vHostingEnviroment.WebRootPath}\\{vDirectorioIG}";
                            if (!Directory.Exists(vDirectory)) Directory.CreateDirectory(vDirectory);

                            string vSubDirectory = vInfo_Documento.Id_Lnr.ToString("D9");
                            vDirectory = $"{vDirectory}\\{vSubDirectory}";
                            if (!Directory.Exists(vDirectory)) Directory.CreateDirectory(vDirectory);

                            string vFileName = $"{vDirectory}\\{vFileNameEmpty}";
                            using (FileStream vFileStream = System.IO.File.Create(vFileName))
                            {
                                vFile.CopyTo(vFileStream);
                                vFileStream.Flush();
                            }

                            vInfo_Documento.Ruta_Documento = vFileName;

                            if (ModelState.IsValid)
                            {
                                var vCarpetaLF = Configuration.GetValue<string>("DirectoryLFLnrID");
                                string vResult = await ServicesLF.ObtenerProceso("SubirArchivo?vCarpeta=" + vCarpetaLF + "&vRutaArchivo=" + vInfo_Documento.Ruta_Documento + "&vNombreArchivo=" + vInfo_Documento.Nombre_Documento);
                                if (vResult != Constantes.Error)
                                {
                                    vInfo_Documento.Id_LaserFiche = Convert.ToInt64(vResult.Replace("\"", ""));
                                    vInfo_Documento = await Services<Lnr_Info_DocumentoDTO>.Grabar("LnrInfoDocumento/Save", vInfo_Documento);
                                    return Json(new ComponentResultModel { Operation = vInfo_Documento.Id_Lnr_Info_Documento > 0 ? Constantes.Ok : Constantes.Error });
                                }
                                else
                                {
                                    return Json(new ComponentResultModel() { Type = TipoErr.LASERFICHE });
                                }
                                //vInfo_Documento = await Services<Lnr_Info_DocumentoDTO>.Grabar("InfoDescargo/Save", vInfo_Documento);
                                //return Json(new ComponentResultModel { Operation = vInfo_Documento.Id_Lnr_Info_Documento > 0 ? Constantes.Ok : Constantes.Error });
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


    }
}
