using Minem.Sgpam.SoporteLaserFiche.Constantes;
using Minem.Sgpam.WebApiLF.WCFSeguridad;
using System;
using System.Web;
using System.Web.Http;

namespace Minem.Sgpam.WebApiLF.Controllers
{
    public class FullExternalController : ApiController
    {
        [HttpGet]
        public string GetUser(string Usuario)
        {
            try
            {
                WCFSistemasServiceClient vProxy = new WCFSistemasServiceClient("BasicHttpBinding_IWCFSistemasService");
                HttpBrowserCapabilities bc = HttpContext.Current.Request.Browser;

                Sistema vRootSystem = new Sistema()
                {
                    ID_Sistema = "6010", //Environment.GetEnvironmentVariable(Constantes.KeyApp),
                    ID_Codigo_generado_plone = Usuario,
                    IP_Remoto = "172.20.11.136", //HttpContext.Current.Request.UserHostAddress, // DnsFullNet.GetIp(), //Request.UserHostAddress
                    Nombre_explorador = bc.Browser + "-" + bc.Version,   
                    Nombre_pagina_web = HttpContext.Current.Request.Path
                };

                AddSistemaResult vResult = vProxy.AddSistema(vRootSystem);
                var vSessionName = vResult.Usuario.ToString().Trim();
                return (!string.IsNullOrEmpty(vSessionName)) ? vSessionName : "";
            }
            catch (Exception ex)
            {
                return Constantes.Err;
            }
        }
    }
}