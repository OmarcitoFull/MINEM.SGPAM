using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    /// <summary>
    /// Objetivo:	Controladora que implementa todos los componentes
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	01/12/2021
    /// </summary>
    public class RegistrarPAMController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Infraestructura(int vId)
        {
            RegistrarPamDTO vRecord = await GetComponent(vId, TipoPam.INFRAESTRUCTURA);
            if (vRecord != null) return View(vRecord);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Infraestructura(ComponenteDTO vModel)
        {
            vModel.Fec_Ingreso = vModel.Fec_Modifica = DateTime.Now;
            vModel.Usu_Ingreso = vModel.Usu_Modifica = "ORODRIGUEZ";
            vModel.Ip_Ingreso = vModel.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vModel = await Services<ComponenteDTO>.Grabar("Componente/Save", vModel);
                return Ok(new ComponentResultModel(vModel?.Id_Componente ?? 0));
            }
            return View(vModel);
        }


        [HttpGet]
        public async Task<IActionResult> LaborMinera(int vId)
        {
            RegistrarPamDTO vRecord = await GetComponent(vId, TipoPam.LABOR_MINERA);
            if (vRecord != null) return View(vRecord);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> LaborMinera(ComponenteDTO vModel)
        {
            vModel.Fec_Ingreso = vModel.Fec_Modifica = DateTime.Now;
            vModel.Usu_Ingreso = vModel.Usu_Modifica = "ORODRIGUEZ";
            vModel.Ip_Ingreso = vModel.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vModel = await Services<ComponenteDTO>.Grabar("Componente/Save", vModel);
                return Ok(new ComponentResultModel(vModel?.Id_Componente ?? 0));
            }
            return View(vModel);
        }


        [HttpGet]
        public async Task<IActionResult> ResiduoMinero(int vId)
        {
            RegistrarPamDTO vRecord = await GetComponent(vId, TipoPam.RESIDUO_MINERO);
            if (vRecord != null) return View(vRecord);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> ResiduoMinero(ComponenteDTO vModel)
        {
            vModel.Fec_Ingreso = vModel.Fec_Modifica = DateTime.Now;
            vModel.Usu_Ingreso = vModel.Usu_Modifica = "ORODRIGUEZ";
            vModel.Ip_Ingreso = vModel.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vModel = await Services<ComponenteDTO>.Grabar("Componente/Save", vModel);
                return Ok(new ComponentResultModel(vModel?.Id_Componente ?? 0));
            }
            return View(vModel);
        }


        [HttpGet]
        public async Task<IActionResult> SustanciasQuimicas(int vId)
        {
            RegistrarPamDTO vRecord = await GetComponent(vId, TipoPam.SUSTANCIA_QUIMICA);
            if (vRecord != null) return View(vRecord);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> SustanciasQuimicas(ComponenteDTO vModel)
        {
            vModel.Fec_Ingreso = vModel.Fec_Modifica = DateTime.Now;
            vModel.Usu_Ingreso = vModel.Usu_Modifica = "ORODRIGUEZ";
            vModel.Ip_Ingreso = vModel.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vModel = await Services<ComponenteDTO>.Grabar("Componente/Save", vModel);
                return Ok(new ComponentResultModel(vModel?.Id_Componente ?? 0));
            }
            return View(vModel);
        }


        [HttpGet]
        public async Task<IActionResult> OtrosResiduos(int vId)
        {
            RegistrarPamDTO vRecord = await GetComponent(vId, TipoPam.OTRO_RESIDUO);
            if (vRecord != null) return View(vRecord);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> OtrosResiduos(ComponenteDTO vModel)
        {
            vModel.Fec_Ingreso = vModel.Fec_Modifica = DateTime.Now;
            vModel.Usu_Ingreso = vModel.Usu_Modifica = "ORODRIGUEZ";
            vModel.Ip_Ingreso = vModel.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vModel = await Services<ComponenteDTO>.Grabar("Componente/Save", vModel);
                return Ok(new ComponentResultModel(vModel?.Id_Componente ?? 0));
            }
            return View(vModel);
        }



        #region Observaciones
        [HttpGet]
        public async Task<IActionResult> ListarObservaciones(int vIdComponente)
        {
            List<Comp_ObservacionDTO> vLista = await Services<Comp_ObservacionDTO>.Listar("Observacion/List?vIdComponente=" + vIdComponente);
            return PartialView("_Observaciones", vLista);
        }

        [HttpGet]
        public IActionResult CrearObservacion(int vIdComponente)
        {
            Comp_ObservacionDTO vRegistro = new Comp_ObservacionDTO { Fecha = DateTime.Now, Id_Componente = vIdComponente };
            return PartialView("_ModalObservaciones", vRegistro);
        }

        [HttpPost]
        public async Task<JsonResult> GrabarObservacion(Comp_ObservacionDTO vObservacion)
        {
            vObservacion.Flg_Estado = Constantes.Activo;
            vObservacion.Fec_Ingreso = vObservacion.Fec_Modifica = DateTime.Now;
            vObservacion.Usu_Ingreso = vObservacion.Usu_Modifica = "ORODRIGUEZ";
            vObservacion.Ip_Ingreso = vObservacion.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vObservacion = await Services<Comp_ObservacionDTO>.Grabar("Observacion/Save", vObservacion);
                return Json(new ComponentResultModel { Operation = vObservacion.Id_Comp_Observacion > 0 ? Constantes.Ok : Constantes.Error });
            }
            else
            {
                return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
            }
        }
        #endregion

        #region Riesgos a la Seguridad Humana
        [HttpGet]
        public async Task<IActionResult> ListarRiesgosSeguridadHumana(int vIdComponente)
        {
            List<Comp_Riesgo_Seg_HumDTO> vLista = await Services<Comp_Riesgo_Seg_HumDTO>.Listar("RiesgosSeguridad/List?vIdComponente=" + vIdComponente);
            return PartialView("_RiesgosSeguridad", vLista);
        }

        [HttpGet]
        public async Task<IActionResult> CrearRiesgosSeguridadHumana(int vIdComponente)
        {
            Comp_Riesgo_Seg_HumDTO vRegistro = await Services<Comp_Riesgo_Seg_HumDTO>.Obtener("RiesgosSeguridad/Get?vId=0");
            vRegistro.Id_Componente = vIdComponente;
            ViewBag.CboAccesibilidad = vRegistro.CboAccesibilidad.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Accesibilidad.ToString() };
            });
            ViewBag.CboCondicionCierre = vRegistro.CboCondicionCierre.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Condicion_Cierre.ToString() };
            });
            ViewBag.CboHundimiento = vRegistro.CboHundimiento.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Hundimiento.ToString() };
            });
            ViewBag.CboPotenciaColapso = vRegistro.CboPotenciaColapso.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Pot_Colapso.ToString() };
            });
            ViewBag.CboPotenciaDanio = vRegistro.CboPotenciaDanio.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Pot_Caida_Persona.ToString() };
            });
            ViewBag.CboPresenciaEscombros = vRegistro.CboPresenciaEscombros.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Presencia_Advertencia.ToString() };
            });
            ViewBag.CboPresenciaSeniales = vRegistro.CboPresenciaSeniales.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Presencia_Elemento.ToString() };
            });
            return PartialView("_ModalRiesgosSeguridad", vRegistro);
        }

        [HttpPost]

        public async Task<JsonResult> GrabarRiesgosSeguridadHumana(Comp_Riesgo_Seg_HumDTO vRiesgo_Seg_Hum)
        {
            vRiesgo_Seg_Hum.Flg_Estado = Constantes.Activo;
            vRiesgo_Seg_Hum.Fec_Ingreso = vRiesgo_Seg_Hum.Fec_Modifica = DateTime.Now;
            vRiesgo_Seg_Hum.Usu_Ingreso = vRiesgo_Seg_Hum.Usu_Modifica = "ORODRIGUEZ";
            vRiesgo_Seg_Hum.Ip_Ingreso = vRiesgo_Seg_Hum.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vRiesgo_Seg_Hum = await Services<Comp_Riesgo_Seg_HumDTO>.Grabar("RiesgosSeguridad/Save", vRiesgo_Seg_Hum);
                return Json(new ComponentResultModel { Operation = vRiesgo_Seg_Hum.Id_Comp_Riesgo_Seg_Hum > 0 ? Constantes.Ok : Constantes.Error });
            }
            else
            {
                return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
            }
        }
        #endregion

        #region Riesgos a la Salud Humana y Ambiente Físico
        [HttpGet]
        public async Task<IActionResult> ListarRiesgosSaludHumana(int vIdComponente)
        {
            List<Comp_Riesgo_Sal_AmbDTO> vLista = await Services<Comp_Riesgo_Sal_AmbDTO>.Listar("RiesgosSaludHumana/List?vIdComponente=" + vIdComponente);
            return PartialView("_RiesgosSaludHumana", vLista);
        }

        [HttpGet]
        public async Task<IActionResult> CrearRiesgosSaludHumana(int vIdComponente)
        {
            Comp_Riesgo_Sal_AmbDTO vRegistro = await Services<Comp_Riesgo_Sal_AmbDTO>.Obtener("RiesgosSaludHumana/Get?vId=0");
            vRegistro.Id_Componente = vIdComponente;
            ViewBag.CboEvidencia_Erosion = vRegistro.CboEvidencia_Erosion.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Evidencia_Erosion.ToString() };
            });
            ViewBag.CboEvidencia_Inundacion = vRegistro.CboEvidencia_Inundacion.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Evidencia_Inundacion.ToString() };
            });
            ViewBag.CboPotencial_Ard = vRegistro.CboPotencial_Ard.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Potencial_Ard.ToString() };
            });
            ViewBag.CboEvidencia_Sus_Toxica = vRegistro.CboEvidencia_Sus_Toxica.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Evidencia_Sus_Toxica.ToString() };
            });

            return PartialView("_ModalRiesgosSaludHumana", vRegistro);
        }

        [HttpPost]
        public async Task<JsonResult> GrabarRiesgosSaludHumana(Comp_Riesgo_Sal_AmbDTO vRiesgo_Sal_Amb)
        {
            vRiesgo_Sal_Amb.Flg_Estado = Constantes.Activo;
            vRiesgo_Sal_Amb.Fec_Ingreso = vRiesgo_Sal_Amb.Fec_Modifica = DateTime.Now;
            vRiesgo_Sal_Amb.Usu_Ingreso = vRiesgo_Sal_Amb.Usu_Modifica = "ORODRIGUEZ";
            vRiesgo_Sal_Amb.Ip_Ingreso = vRiesgo_Sal_Amb.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vRiesgo_Sal_Amb = await Services<Comp_Riesgo_Sal_AmbDTO>.Grabar("RiesgosSaludHumana/Save", vRiesgo_Sal_Amb);
                return Json(new ComponentResultModel { Operation = vRiesgo_Sal_Amb.Id_Comp_Riesgo_Sal_Amb > 0 ? Constantes.Ok : Constantes.Error });
            }
            else
            {
                return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
            }
        }
        #endregion

        #region Riesgos a la Fauna Silvestre y Conservación
        [HttpGet]
        public async Task<IActionResult> ListarRiesgosFaunaSilvestre(int vIdComponente)
        {
            List<Comp_Riesgo_Fau_ConDTO> vLista = await Services<Comp_Riesgo_Fau_ConDTO>.Listar("RiesgosFaunaSilvestre/List?vIdComponente=" + vIdComponente);
            return PartialView("_RiesgosFaunaSilvestre", vLista);
        }

        [HttpGet]
        public async Task<IActionResult> CrearRiesgosFaunaSilvestre(int vIdComponente)
        {
            Comp_Riesgo_Fau_ConDTO vRegistro = await Services<Comp_Riesgo_Fau_ConDTO>.Obtener("RiesgosFaunaSilvestre/Get?vId=0");
            vRegistro.Id_Componente = vIdComponente;
            ViewBag.CboAcceso_Fauna = vRegistro.CboAcceso_Fauna.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Acceso_Fauna.ToString() };
            });
            ViewBag.CboAgua_Contaminada = vRegistro.CboAgua_Contaminada.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Agua_Contaminada.ToString() };
            });
            ViewBag.CboAtraccion_Fauna = vRegistro.CboAtraccion_Fauna.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Atraccion_Fauna.ToString() };
            });
            ViewBag.CboCerca_Area_Protegida = vRegistro.CboCerca_Area_Protegida.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Cerca_Area_Protegida.ToString() };
            });
            ViewBag.CboSensibilidad_Area = vRegistro.CboSensibilidad_Area.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Sensibilidad_Area.ToString() };
            });
            ViewBag.CboVegetacion_Invasiva = vRegistro.CboVegetacion_Invasiva.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Vegetacion_Invasiva.ToString() };
            });

            return PartialView("_ModalRiesgosFaunaSilvestre", vRegistro);
        }

        [HttpPost]
        public async Task<JsonResult> GrabarRiesgosFaunaSilvestre(Comp_Riesgo_Fau_ConDTO vRiesgo_Fau_Con)
        {
            vRiesgo_Fau_Con.Flg_Estado = Constantes.Activo;
            vRiesgo_Fau_Con.Fec_Ingreso = vRiesgo_Fau_Con.Fec_Modifica = DateTime.Now;
            vRiesgo_Fau_Con.Usu_Ingreso = vRiesgo_Fau_Con.Usu_Modifica = "ORODRIGUEZ";
            vRiesgo_Fau_Con.Ip_Ingreso = vRiesgo_Fau_Con.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vRiesgo_Fau_Con = await Services<Comp_Riesgo_Fau_ConDTO>.Grabar("RiesgosFaunaSilvestre/Save", vRiesgo_Fau_Con);
                return Json(new ComponentResultModel { Operation = vRiesgo_Fau_Con.Id_Comp_Riesgo_Fau_Con > 0 ? Constantes.Ok : Constantes.Error });
            }
            else
            {
                return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
            }
        }
        #endregion

        #region Mediciones de Campo
        [HttpGet]
        public async Task<IActionResult> ListarMedicionesCampo(int vIdComponente)
        {
            List<Comp_MedicionDTO> vLista = await Services<Comp_MedicionDTO>.Listar("MedicionCampo/List?vIdComponente=" + vIdComponente);
            return PartialView("_MedicionesCampo", vLista);
        }

        [HttpGet]
        public IActionResult CrearMedicionesCampo(int vIdComponente)
        {
            Comp_MedicionDTO vRegistro = new Comp_MedicionDTO { Fecha_Desicion = DateTime.Now, Id_Componente = vIdComponente };
            return PartialView("_ModalMedicionesCampo", vRegistro);
        }

        [HttpPost]
        public async Task<JsonResult> GrabarMedicionesCampo(Comp_MedicionDTO vMedicion)
        {
            vMedicion.Flg_Estado = Constantes.Activo;
            vMedicion.Fec_Ingreso = vMedicion.Fec_Modifica = DateTime.Now;
            vMedicion.Usu_Ingreso = vMedicion.Usu_Modifica = "ORODRIGUEZ";
            vMedicion.Ip_Ingreso = vMedicion.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vMedicion = await Services<Comp_MedicionDTO>.Grabar("MedicionCampo/Save", vMedicion);
                return Json(new ComponentResultModel { Operation = vMedicion.Id_Comp_Medicion > 0 ? Constantes.Ok : Constantes.Error });
            }
            else
            {
                return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
            }
        }
        #endregion

        #region Informacion Grafica
        [HttpGet]
        public async Task<IActionResult> ListarInformacionGrafica(int vIdComponente)
        {
            List<Comp_Info_GraficaDTO> vLista = await Services<Comp_Info_GraficaDTO>.Listar("InformacionGrafica/List?vIdComponente=" + vIdComponente);
            return PartialView("_InformacionGrafica", vLista);
        }

        [HttpGet]
        public IActionResult CrearInformacionGrafica(int vIdComponente)
        {
            Comp_Info_GraficaDTO vRegistro = new Comp_Info_GraficaDTO { Fec_Ingreso = DateTime.Now, Id_Componente = vIdComponente };
            return PartialView("_ModalInformacionGrafica", vRegistro);
        }

        [HttpPost]
        [Obsolete]
        public async Task<JsonResult> GrabarInformacionGrafica(Comp_Info_GraficaDTO vInfo_Grafica, IFormFile vFile, [FromServices] IHostingEnvironment vHostingEnviroment)
        {
            vInfo_Grafica.Flg_Estado = Constantes.Activo;
            vInfo_Grafica.Fec_Ingreso = vInfo_Grafica.Fec_Modifica = DateTime.Now;
            vInfo_Grafica.Usu_Ingreso = vInfo_Grafica.Usu_Modifica = "ORODRIGUEZ";
            vInfo_Grafica.Ip_Ingreso = vInfo_Grafica.Ip_Modifica = DnsFullNet.GetIp();

            if (vFile != null)
            {
                vInfo_Grafica.Extencion = Path.GetExtension(vFile.FileName).Substring(1);
                vInfo_Grafica.Nombre_Imagen = vFile.FileName;
                vInfo_Grafica.Tamano = (int)vFile.Length;

                var vDirectory = $"{vHostingEnviroment.WebRootPath}\\files";
                if (Directory.Exists(vDirectory))
                {
                    string vFileName = $"{vDirectory}\\{vFile.FileName}";
                    try
                    {
                        using (FileStream vFileStream = System.IO.File.Create(vFileName))
                        {
                            vFile.CopyTo(vFileStream);
                            vFileStream.Flush();
                        }

                        vInfo_Grafica.Ruta_Imagen = vFileName;

                        if (ModelState.IsValid)
                        {
                            vInfo_Grafica = await Services<Comp_Info_GraficaDTO>.Grabar("InformacionGrafica/Save", vInfo_Grafica);
                            return Json(new ComponentResultModel { Operation = vInfo_Grafica.Id_Comp_Info_Grafica > 0 ? Constantes.Ok : Constantes.Error });
                        }
                        else
                        {
                            return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
                        }
                    }
                    catch (Exception ex)
                    {
                        return Json(new ComponentResultModel());
                    }
                }
                else
                {
                    return Json(new ComponentResultModel());
                }
            }
            else
            {
                return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
            }
        }
        #endregion

        #region Comentarios Adicionales
        [HttpGet]
        public async Task<IActionResult> ListarComentarios(int vIdComponente)
        {
            List<Comp_ComentarioDTO> vLista = await Services<Comp_ComentarioDTO>.Listar("Comentario/List?vIdComponente=" + vIdComponente);
            return PartialView("_ComentariosAdicionales", vLista);
        }

        [HttpGet]
        public IActionResult CrearComentarios(int vIdComponente)
        {
            Comp_ComentarioDTO vRegistro = new Comp_ComentarioDTO { Fecha = DateTime.Now, Id_Componente = vIdComponente };
            return PartialView("_ModalComentariosAdicionales", vRegistro);
        }

        [HttpPost]
        public async Task<JsonResult> GrabarComentarios(Comp_ComentarioDTO vComentario)
        {
            vComentario.Flg_Estado = Constantes.Activo;
            vComentario.Fec_Ingreso = vComentario.Fec_Modifica = DateTime.Now;
            vComentario.Usu_Ingreso = vComentario.Usu_Modifica = "ORODRIGUEZ";
            vComentario.Ip_Ingreso = vComentario.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vComentario = await Services<Comp_ComentarioDTO>.Grabar("Comentario/Save", vComentario);
                return Json(new ComponentResultModel { Operation = vComentario.Id_Comp_Comentario > 0 ? Constantes.Ok : Constantes.Error });
            }
            else
            {
                return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
            }
        }
        #endregion

        #region Estudio Ambientales
        [HttpGet]
        public async Task<IActionResult> ListarEstudioAmbientales(int vIdComponente)
        {
            List<Comp_Est_AmbDTO> vLista = await Services<Comp_Est_AmbDTO>.Listar("EstudioAmbiental/List?vIdComponente=" + vIdComponente);
            return PartialView("_EstudiosAmbientales", vLista);
        }

        [HttpGet]
        public async Task<IActionResult> CrearEstudioAmbientales(int vIdComponente, int vId)
        {
            Comp_Est_AmbDTO vRegistro = new Comp_Est_AmbDTO { Id_Componente = vIdComponente };
            if (vId > 0)
            {
                vRegistro = await Services<Comp_Est_AmbDTO>.Obtener("EstudioAmbiental/Get?vId=" + vId.ToString());
            }

            return PartialView("_ModalEstudioAmbientales", vRegistro);
        }

        [HttpPost]
        public async Task<JsonResult> GrabarEstudioAmbientales(Comp_Est_AmbDTO vEst_Amb)
        {
            vEst_Amb.Flg_Estado = Constantes.Activo;
            vEst_Amb.Fec_Ingreso = vEst_Amb.Fec_Modifica = DateTime.Now;
            vEst_Amb.Usu_Ingreso = vEst_Amb.Usu_Modifica = "ORODRIGUEZ";
            vEst_Amb.Ip_Ingreso = vEst_Amb.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vEst_Amb = await Services<Comp_Est_AmbDTO>.Grabar("EstudioAmbiental/Save", vEst_Amb);
                return Json(new ComponentResultModel { Operation = vEst_Amb.Id_Comp_Est_Amb > 0 ? Constantes.Ok : Constantes.Error });
            }
            else
            {
                return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
            }
        }
        #endregion

        #region Encargo de Remediación
        [HttpGet]
        public async Task<IActionResult> ListarEncargoRemediacion(int vIdComponente)
        {
            List<Comp_Enc_RemDTO> vLista = await Services<Comp_Enc_RemDTO>.Listar("EncargoRemediacion/List?vIdComponente=" + vIdComponente);
            return PartialView("_EncargoRemediacion", vLista);
        }

        [HttpGet]
        public async Task<IActionResult> CrearEncargoRemediacion(int vIdComponente)
        {
            Comp_Enc_RemDTO vRegistro = await Services<Comp_Enc_RemDTO>.Obtener("EncargoRemediacion/Get?vId=0");
            vRegistro.Id_Componente = vIdComponente;
            ViewBag.CboTipoEncargo = vRegistro.CboTipoEncargo.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Tipo_Encargo.ToString() };
            });
            ViewBag.CboTipoResolucion = vRegistro.CboTipoResolucion.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Tipo_Resolucion.ToString() };
            });

            return PartialView("_ModalEncargoRemediacion", vRegistro);
        }

        [HttpPost]
        public async Task<JsonResult> GrabarEncargoRemediacion(Comp_Enc_RemDTO vEnc_Rem)
        {
            vEnc_Rem.Flg_Estado = Constantes.Activo;
            vEnc_Rem.Fec_Ingreso = vEnc_Rem.Fec_Modifica = DateTime.Now;
            vEnc_Rem.Usu_Ingreso = vEnc_Rem.Usu_Modifica = "ORODRIGUEZ";
            vEnc_Rem.Ip_Ingreso = vEnc_Rem.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vEnc_Rem = await Services<Comp_Enc_RemDTO>.Grabar("EncargoRemediacion/Save", vEnc_Rem);
                return Json(new ComponentResultModel { Operation = vEnc_Rem.Id_Comp_Enc_Rem > 0 ? Constantes.Ok : Constantes.Error });
            }
            else
            {
                return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
            }
        }
        #endregion

        #region Reaprovechamientos
        [HttpGet]
        public async Task<IActionResult> ListarReaprovechamiento(int vIdComponente)
        {
            List<Comp_ReaproDTO> vLista = await Services<Comp_ReaproDTO>.Listar("Reaprovechamiento/List?vIdComponente=" + vIdComponente);
            return PartialView("_Reaprovechamientos", vLista);
        }

        [HttpGet]
        public IActionResult CrearReaprovechamiento(int vIdComponente)
        {
            Comp_ReaproDTO vRegistro = new Comp_ReaproDTO { Id_Componente = vIdComponente };
            return PartialView("_ModalReaprovechamientos", vRegistro);
        }

        [HttpPost]
        public async Task<JsonResult> GrabarReaprovechamiento(Comp_ReaproDTO vReapro)
        {
            vReapro.Flg_Estado = Constantes.Activo;
            vReapro.Fec_Ingreso = vReapro.Fec_Modifica = DateTime.Now;
            vReapro.Usu_Ingreso = vReapro.Usu_Modifica = "ORODRIGUEZ";
            vReapro.Ip_Ingreso = vReapro.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vReapro = await Services<Comp_ReaproDTO>.Grabar("Reaprovechamiento/Save", vReapro);
                return Json(new ComponentResultModel { Operation = vReapro.Id_Comp_Reapro > 0 ? Constantes.Ok : Constantes.Error });
            }
            else
            {
                return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
            }
        }
        #endregion

        #region Informe de Campo
        [HttpGet]
        public async Task<IActionResult> ListarInformeCampo(int vIdComponente)
        {
            List<Comp_Info_CampoDTO> vLista = await Services<Comp_Info_CampoDTO>.Listar("InformeCampo/List?vIdComponente=" + vIdComponente);
            return PartialView("_InformeCampo", vLista);
        }

        [HttpGet]
        public IActionResult CrearInformeCampo(int vIdComponente)
        {
            Comp_Info_CampoDTO vRegistro = new Comp_Info_CampoDTO { Fecha_Informe = DateTime.Now, Id_Componente = vIdComponente };
            return PartialView("_ModalInformeCampo", vRegistro);
        }

        [HttpPost]
        public async Task<JsonResult> GrabarInformeCampo(Comp_Info_CampoDTO vInfo_Campo)
        {
            vInfo_Campo.Flg_Estado = Constantes.Activo;
            vInfo_Campo.Fec_Ingreso = vInfo_Campo.Fec_Modifica = DateTime.Now;
            vInfo_Campo.Usu_Ingreso = vInfo_Campo.Usu_Modifica = "ORODRIGUEZ";
            vInfo_Campo.Ip_Ingreso = vInfo_Campo.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vInfo_Campo = await Services<Comp_Info_CampoDTO>.Grabar("InformeCampo/Save", vInfo_Campo);
                return Json(new ComponentResultModel { Operation = vInfo_Campo.Id_Comp_Info_Campo > 0 ? Constantes.Ok : Constantes.Error });
            }
            else
            {
                return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
            }
        }
        #endregion

        #region Resultados
        [HttpGet]
        public async Task<IActionResult> ListarResultado(int vIdComponente)
        {
            List<Comp_ResultadoResumenDTO> vLista = await Services<Comp_ResultadoResumenDTO>.Listar("Resultado/List?vIdComponente=" + vIdComponente);
            return PartialView("_Resultado", vLista);
        }

        [HttpGet]
        public IActionResult CrearResultado(int vIdComponente)
        {
            Comp_ResultadoDTO vRegistro = new Comp_ResultadoDTO { Id_Componente = vIdComponente };
            return PartialView("_ModalResultado", vRegistro);
        }

        [HttpPost]
        public async Task<JsonResult> GrabarResultado(Comp_ResultadoDTO vResultado)
        {
            vResultado.Flg_Estado = Constantes.Activo;
            vResultado.Fec_Ingreso = vResultado.Fec_Modifica = DateTime.Now;
            vResultado.Usu_Ingreso = vResultado.Usu_Modifica = "ORODRIGUEZ";
            vResultado.Ip_Ingreso = vResultado.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vResultado = await Services<Comp_ResultadoDTO>.Grabar("Resultado/Save", vResultado);
                return Json(new ComponentResultModel { Operation = vResultado.Id_Comp_Resultado > 0 ? Constantes.Ok : Constantes.Error });
            }
            else
            {
                return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
            }
        }
        #endregion

        #region Estado de Gestión
        [HttpGet]
        public async Task<IActionResult> ListarEstadoGestion(int vIdComponente)
        {
            List<Comp_Est_GestionDTO> vLista = await Services<Comp_Est_GestionDTO>.Listar("EstadoGestion/List?vIdComponente=" + vIdComponente);
            return PartialView("_EstadoGestion", vLista);
        }

        [HttpGet]
        public async Task<IActionResult> CrearEstadoGestion(int vIdComponente)
        {
            List<Estado_GestionDTO> vLista = await Services<Estado_GestionDTO>.Listar("TipoEstadoGestion/List");
            ViewBag.CboEstadoGestion = vLista.ConvertAll(x =>
            {
                return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Estado_Gestion.ToString() };
            });

            Comp_Est_GestionDTO vRegistro = new Comp_Est_GestionDTO { Fecha = DateTime.Now, Id_Componente = vIdComponente };

            return PartialView("_ModalEstadoGestion", vRegistro);
        }

        [HttpPost]
        public async Task<JsonResult> GrabarEstadoGestion(Comp_Est_GestionDTO vEst_Gestion)
        {
            vEst_Gestion.Flg_Estado = Constantes.Activo;
            vEst_Gestion.Fec_Ingreso = vEst_Gestion.Fec_Modifica = DateTime.Now;
            vEst_Gestion.Usu_Ingreso = vEst_Gestion.Usu_Modifica = "ORODRIGUEZ";
            vEst_Gestion.Ip_Ingreso = vEst_Gestion.Ip_Modifica = DnsFullNet.GetIp();
            if (ModelState.IsValid)
            {
                vEst_Gestion = await Services<Comp_Est_GestionDTO>.Grabar("EstadoGestion/Save", vEst_Gestion);
                return Json(new ComponentResultModel { Operation = vEst_Gestion.Id_Comp_Est_Gestion > 0 ? Constantes.Ok : Constantes.Error });
            }
            else
            {
                return Json(new ComponentResultModel() { Type = TipoErr.MODEL });
            }
        }
        #endregion



        public async Task<RegistrarPamDTO> GetComponent(int vId, TipoPam vType)
        {
            RegistrarPamDTO vRecord = await Services<RegistrarPamDTO>.Obtener("Componente/GetFull?vId=" + vId);
            if (vRecord != null || vRecord.Componente != null)
            {
                if ((int)vType == vRecord.Componente.Id_Tipo_Pam)
                {
                    ViewBag.CboTipo = vRecord.CboTipo.ConvertAll(x =>
                    {
                        return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Tipo_Pam.ToString() };
                    });

                    ViewBag.CboSubTipo = vRecord.CboSubTipo.Where(x => x.Id_Tipo_Pam == vRecord.Componente.Id_Tipo_Pam).ToList().ConvertAll(x =>
                    {
                        return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Sub_Tipo_Pam.ToString() };
                    });

                    ViewBag.CboParticula = vRecord.CboParticula.ConvertAll(x =>
                    {
                        return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Tamano_Particula.ToString() };
                    });

                    ViewBag.CboHumedad = vRecord.CboHumedad.ConvertAll(x =>
                    {
                        return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Humedad.ToString() };
                    });

                    ViewBag.CboConcesion = vRecord.CboConcesion.ConvertAll(x =>
                    {
                        return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Tipo_Concesion.ToString() };
                    });

                    ViewBag.CboCobertura = vRecord.CboCobertura.ConvertAll(x =>
                    {
                        return new SelectListItem() { Text = x.Descripcion, Value = x.Id_Cobertura.ToString() };
                    });


                    ViewBag.CboDatum = Enum.GetValues(typeof(Datum)).Cast<Datum>().ToList().ConvertAll(x =>
                    {
                        return new SelectListItem() { Text = x.ToString(), Value = ((int)x).ToString() };
                    });
                    ViewBag.CboZona = Enum.GetValues(typeof(Zona)).Cast<Zona>().ToList().ConvertAll(x =>
                    {
                        return new SelectListItem() { Text = x.ToString(), Value = ((int)x).ToString() };
                    });
                    ViewBag.CboCuencaPrincipal = Enum.GetValues(typeof(CuencaPrincipal)).Cast<CuencaPrincipal>().ToList().ConvertAll(x =>
                    {
                        return new SelectListItem() { Text = x.ToString(), Value = ((int)x).ToString() };
                    });
                    ViewBag.CboCuencaSecundario = Enum.GetValues(typeof(CuencaSecundario)).Cast<CuencaSecundario>().ToList().ConvertAll(x =>
                    {
                        return new SelectListItem() { Text = x.ToString(), Value = ((int)x).ToString() };
                    });

                    ViewBag.CboRegion = vRecord.CboUbigeo.Select(x => new { x.Id_Region, x.Region }).Distinct().ToList().ConvertAll(x =>
                    {
                        return new SelectListItem() { Text = x.Region, Value = x.Id_Region.ToString() };
                    });

                    ViewBag.CboProvincia = vRecord.CboUbigeo.Where(x => x.Id_Region == vRecord.Componente.Id_Region).Select(x => new { x.Id_Provincia, x.Provincia }).Distinct().ToList().ConvertAll(x =>
                    {
                        return new SelectListItem() { Text = x.Provincia, Value = x.Id_Provincia.ToString() };
                    });
                    ViewBag.CboDistrito = vRecord.CboUbigeo.Where(x => x.Id_Provincia == vRecord.Componente.Id_Provincia).Select(x => new { x.Id_Distrito, x.Distrito }).Distinct().ToList().ConvertAll(x =>
                    {
                        return new SelectListItem() { Text = x.Distrito, Value = x.Id_Distrito.ToString() };
                    });

                    return vRecord;
                }
                return null;
            }
            return null;
        }

    }
}
