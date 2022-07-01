using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Minem.Sgpam.SoporteLaserFiche.Constantes;
using Minem.Sgpam.SoporteLaserFiche.Utilitarios;

namespace Minem.Sgpam.WebApiLF.Controllers
{
    public class ServicioLFController : BaseController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "Servicio LF", "Por: ORodriguez " };
        }

        public string CrearCarpeta(string vNombre)
        {
            try
            {
                var vPath = FullLaserFiche.CrearCarpeta(CarpetaBase, vNombre, Usuario, Contrasenia, Servidor, Repositorio);
                return string.IsNullOrEmpty(vPath) ? Constantes.Err : Constantes.Success;
            }
            catch (Exception ex)
            {
                return Constantes.Err;
            }
        }

        public string SubirArchivo(string vCarpeta, string vRutaArchivo, string vNombreArchivo)
        {
            try
            {
                var vKey = FullLaserFiche.SubirArchivo(CarpetaBase, vCarpeta, vRutaArchivo, vNombreArchivo, Usuario, Contrasenia, Servidor, Repositorio);
                return vKey > 0 ? vKey.ToString(): Constantes.Err;
            }
            catch (Exception ex)
            {
                return Constantes.Err;
            }
        }

        public string EliminarArchivo(int vId)
        {
            try
            {
                var vFlat = FullLaserFiche.EliminarArchivo(vId, Usuario, Contrasenia, Servidor, Repositorio);
                return vFlat ? Constantes.Success: Constantes.Err;
            }
            catch (Exception ex)
            {
                return Constantes.Err;
            }
        }

        public HttpResponseMessage DescargarArchivo(int vKey, string vFileName)
        {
            var vMemoryStream = FullLaserFiche.ExportarArchivo(vKey, Usuario, Contrasenia, Servidor, Repositorio);
            byte[] vBytesInStream = vMemoryStream.ToArray();
            vMemoryStream.Close();

            var vResult = new HttpResponseMessage(HttpStatusCode.OK) { Content = new ByteArrayContent(vBytesInStream) };
            vResult.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment") { FileName = vFileName };
            vResult.Content.Headers.ContentType = new MediaTypeHeaderValue(FullLaserFiche.ObtenerTipoArchivo(Path.GetExtension(vFileName).ToLowerInvariant()));
            return vResult;
        }

    }
}