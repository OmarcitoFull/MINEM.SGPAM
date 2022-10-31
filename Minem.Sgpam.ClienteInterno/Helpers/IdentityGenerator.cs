using Microsoft.AspNetCore.Authentication.Cookies;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;

namespace Minem.Sgpam.ClienteInterno.Helpers
{
    /// <summary>
    /// Objetivo:	Clase estatica que implementa la sesión
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	03/10/2022
    /// </summary>
    public static class IdentityGenerator
    {
        public static ClaimsPrincipal Execute(SessionUserDto vUsuario)
        {
            var vIdentity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
            vIdentity.AddClaim(new Claim(ClaimTypes.NameIdentifier, vUsuario.UserId.ToString()));
            vIdentity.AddClaim(new Claim("UserName", vUsuario.UserName));
            vIdentity.AddClaim(new Claim("SessionName", vUsuario.SessionName));
            vIdentity.AddClaim(new Claim("Roles", JsonConvert.SerializeObject(vUsuario.Roles)));

            var vPrincipal = new ClaimsPrincipal(vIdentity);
            return vPrincipal;
        }
    }

    public class GlobalAppSession
    {
        public static string GetCurrentSesion(IPrincipal vPrincipal)
        {
            var vPropiedad = ((ClaimsIdentity)vPrincipal.Identity).FindFirst("SessionName");
            return vPropiedad == null ? "" : vPropiedad.Value;
        }

        public static List<RoleOptionsDto> GetListOptions(IPrincipal vPrincipal)
        {
            var vPropiedad = ((ClaimsIdentity)vPrincipal.Identity).FindFirst("Roles");
            if (vPropiedad != null)
            {
                var vListOptions = (JsonConvert.DeserializeObject<List<UserRolesUserDto>>(vPropiedad.Value));
                if (vListOptions.Count > 0) return vListOptions[0].Options;
            }
            return new List<RoleOptionsDto>();
        }
    }
}
