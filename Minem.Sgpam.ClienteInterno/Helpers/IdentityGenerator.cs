using Microsoft.AspNetCore.Authentication.Cookies;
using Minem.Sgpam.ClienteInterno.Models;
using Newtonsoft.Json;
using System.Security.Claims;

namespace Minem.Sgpam.ClienteInterno.Helpers
{
    public static class IdentityGenerator
    {
        public static ClaimsPrincipal Execute(SessionUserModel vUsuario)
        {
            var vIdentity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
            vIdentity.AddClaim(new Claim(ClaimTypes.NameIdentifier, vUsuario.UserId.ToString()));
            vIdentity.AddClaim(new Claim("NombreCompleto", vUsuario.UserName));
            vIdentity.AddClaim(new Claim("NombreAbreviado", vUsuario.SessionName));
            vIdentity.AddClaim(new Claim("Roles", JsonConvert.SerializeObject(vUsuario.Roles)));

            var vPrincipal = new ClaimsPrincipal(vIdentity);
            return vPrincipal;
        }
    }
}
