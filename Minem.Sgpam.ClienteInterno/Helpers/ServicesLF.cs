using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Minem.Sgpam.InfraEstructura;

namespace Minem.Sgpam.ClienteInterno.Helpers
{
    /// <summary>
    /// Objetivo:	Clase que implementa la comunicación con los servicios
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	01/11/2021
    /// </summary>
    public class ServicesLF<T>
    {
        static string ApiPam = "http://localhost:57882/lf/FullLF/";
        
        public static async Task<List<T>> Listar(string vRouter)
        {
            List<T> vList = new();
            using (var vApi = new HttpClient())
            {
                using (var vJson = await vApi.GetAsync(ApiPam + vRouter))
                {
                    var vResult = await vJson.Content.ReadAsStringAsync();
                    if (vResult != "[]" && vResult != "" && vResult != null)
                    {
                        vList = JsonConvert.DeserializeObject<List<T>>(vResult);
                    }
                }
            }
            return vList;
        }

        public static async Task<T> Obtener(string vRouter)
        {
            using (var vApi = new HttpClient())
            {
                using (var vJson = await vApi.GetAsync(ApiPam + vRouter))
                {
                    var vResult = await vJson.Content.ReadAsStringAsync();
                    if (vResult != "[]" && vResult != "" && vResult != null)
                    {
                        return JsonConvert.DeserializeObject<T>(vResult);
                    }
                }
            }
            return default;
        }

        public static async Task<T> Grabar(string vRouter, T vRecord)
        {
            using (var vApi = new HttpClient())
            {
                StringContent vContent = new StringContent(JsonConvert.SerializeObject(vRecord), Encoding.UTF8, "application/json");
                using (var vJson = await vApi.PostAsync(ApiPam + vRouter, vContent))
                {
                    if (vJson.IsSuccessStatusCode)
                        vRecord = JsonConvert.DeserializeObject<T>(vJson.Content.ReadAsStringAsync().Result);
                }
            }
            return vRecord;
        }

        public static async Task<bool> Eliminar(string vRouter, T vRecord)
        {
            bool vResult = false;
            using (var vApi = new HttpClient())
            {
                StringContent vContent = new StringContent(JsonConvert.SerializeObject(vRecord), Encoding.UTF8, "application/json");
                using (var vJson = await vApi.PostAsync(ApiPam + vRouter, vContent))
                {
                    if (vJson.IsSuccessStatusCode)
                        vResult = JsonConvert.DeserializeObject<bool>(vJson.Content.ReadAsStringAsync().Result);
                }
            }
            return vResult;
        }
    }
}
