using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Minem.Sgpam.ClienteInterno.Helpers
{
    /// <summary>
    /// Objetivo:	Clase que implementa la comunicación con los servicios
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	30/03/2022
    /// </summary>
    public class ServicesLF
    {
        static string ApiPam = "http://localhost:63140/LF/ServicioLF/";

        public static async Task<string> ObtenerProceso(string vRouter)
        {
            string vResult = "";
            using (var vApi = new HttpClient())
            {
                using (var vJson = await vApi.PostAsync(ApiPam + vRouter, new StringContent("", Encoding.UTF8, "application/json")))
                {
                    if (vJson.IsSuccessStatusCode) vResult = vJson.Content.ReadAsStringAsync().Result;
                }
            }
            return vResult;
        }

        public static async Task<Byte[]> ObtenerFlujo(string vRouter)
        {
            using (var vApi = new HttpClient())
            {
                using (var vJson = await vApi.PostAsync(ApiPam + vRouter, new StringContent("", Encoding.UTF8, "application/json")))
                {
                    if (vJson.IsSuccessStatusCode)
                    {
                        var vResult = await vJson.Content.ReadAsStringAsync();
                        if (vResult != "[]" && vResult != "" && vResult != null)
                        {
                            var vStream = vJson.Content.ReadAsStreamAsync().Result;
                            MemoryStream vMemoryStream = new MemoryStream();
                            vStream.CopyTo(vMemoryStream);
                            return vMemoryStream.ToArray();
                        }
                    }
                }
            }
            return null;
        }


    }
}
