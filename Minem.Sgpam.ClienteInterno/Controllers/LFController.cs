using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.InfraEstructura;
using Minem.Sgpam.ClienteInterno.Helpers;
using System.Net.Http;
using Microsoft.AspNetCore.Authorization;

namespace Minem.Sgpam.ClienteInterno.Controllers
{
    [Authorize]
    public class LFController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Pagina Web LF";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CrearCarpeta(string vNombre)
        {
            try
            {
                string vResult = await ServicesLF.ObtenerProceso("CrearCarpeta?vNombre=" + vNombre);
                return Json(vResult);
            }
            catch (Exception ex)
            {
                return Json(Constantes.Error);
            }
        }

        [HttpPost]
        public async Task<IActionResult> SubirArchivo(string vCarpeta, string vRuta)
        {
            try
            {
                string vResult = await ServicesLF.ObtenerProceso("SubirArchivo?vCarpeta=" + vCarpeta + "&vRutaArchivo=" + vRuta + "&vNombreArchivo=Exp-" + DateTime.Now.ToString());
                return Json(vResult);
            }
            catch (Exception ex)
            {
                return Json(Constantes.Error);
            }
        }

        [HttpPost]
        public async Task<IActionResult> EliminarArchivo(int vKey)
        {
            try
            {
                string vResult = await ServicesLF.ObtenerProceso("EliminarArchivo?vId=" + vKey);
                return Json(vResult);
            }
            catch (Exception ex)
            {
                return Json(Constantes.Error);
            }
        }

        [HttpGet]
        public async Task<IActionResult> DescargarArchivo(int vKey)
        {
            try
            {
                Byte[] vFileContent = await ServicesLF.ObtenerFlujo("DescargarArchivo?vKey=" + vKey + "&vFileName=MiCarrito.jpg&vTypeFile=" + Constantes.ContentTypeJPG);
                if (vFileContent != null)
                {
                    return File(vFileContent, Constantes.ContentTypeJPG, "Resolucion_2022.jpg");
                }
                return Json(Constantes.Error);
            }
            catch (Exception ex)
            {
                return Json(Constantes.Error);
            }
        }


    }
}
