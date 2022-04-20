using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Hosting;
using Minem.Sgpam.InfraEstructura;

namespace Minem.Sgpam.ClienteInterno.Controllers
{
    public class LFController : Controller
    {
        static string ApiPam = "http://localhost:63140/LF/ServicioLF/";

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
                string vRecord = "";
                using (var vApi = new HttpClient())
                {
                    StringContent vContent = new StringContent("", Encoding.UTF8, "application/json");
                    using (var vJson = await vApi.PostAsync(ApiPam + "CrearCarpeta?vNombre=" + vNombre, vContent))
                    {
                        if (vJson.IsSuccessStatusCode)
                            vRecord = vJson.Content.ReadAsStringAsync().Result;
                    }
                }

                return Json(vRecord);
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
                string vRecord = "";
                using (var vApi = new HttpClient())
                {
                    StringContent vContent = new StringContent("", Encoding.UTF8, "application/json");
                    using (var vJson = await vApi.PostAsync(ApiPam + "SubirArchivo?vCarpeta=" + vCarpeta + "&vRutaArchivo=" + vRuta + "&vNombreArchivo=Exp-" + DateTime.Now.ToString(), vContent))
                    {
                        if (vJson.IsSuccessStatusCode)
                            vRecord = vJson.Content.ReadAsStringAsync().Result;
                    }
                }

                return Json(vRecord);
            }
            catch (Exception ex)
            {
                return Json(Constantes.Error);
            }
        }

        [HttpPost]
        public async Task<IActionResult> EliminarArchivo()
        {
            try
            {
                string vRecord = "";
                using (var vApi = new HttpClient())
                {
                    StringContent vContent = new StringContent("", Encoding.UTF8, "application/json");
                    using (var vJson = await vApi.PostAsync(ApiPam + "EliminarArchivo?vId=5408319", vContent))
                    {
                        if (vJson.IsSuccessStatusCode)
                            vRecord = vJson.Content.ReadAsStringAsync().Result;
                    }
                }

                return Json(vRecord);
            }
            catch (Exception ex)
            {
                return Json(Constantes.Error);
            }
        }

        [HttpGet]
        public async Task<IActionResult> DescargarArchivo()
        {
            try
            {
                using (var vApi = new HttpClient())
                {
                    StringContent vContent = new StringContent("", Encoding.UTF8, "application/json");
                    using (var vJson = await vApi.PostAsync(ApiPam + "DescargarArchivo?vKey=5408310", vContent))
                    {
                        if (vJson.IsSuccessStatusCode)
                        {
                            var vResult = await vJson.Content.ReadAsStringAsync();
                            if (vResult != "[]" && vResult != "" && vResult != null)
                            {
                                var vStream = vJson.Content.ReadAsStreamAsync().Result;
                                MemoryStream vMemoryStream = new MemoryStream();
                                vStream.CopyTo(vMemoryStream);
                                return File(vMemoryStream.ToArray(), "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "Resolucion_2022.docx");
                            }
                        }
                    }
                }
                return Json(Constantes.Error);
            }
            catch (Exception ex)
            {
                return Json(Constantes.Error);
            }
        }


        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"}
            };
        }

    }
}
