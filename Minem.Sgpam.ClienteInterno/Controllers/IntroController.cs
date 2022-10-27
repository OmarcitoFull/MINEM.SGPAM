using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Minem.Sgpam.ClienteInterno.Helpers;
using Minem.Sgpam.InfraEstructura;
using Minem.Sgpam.InfraEstructura.Utilitarios;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WCFSeguridad;

namespace Minem.Sgpam.ClienteInterno.Controllers
{
    public class IntroController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index(string Usuario = "22543420454344704748208510363511850513566516256517182518096519550520976523661523744526668524480525908528006529187530932532395533696534983536784538979")
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                WCFSistemasServiceClient vProxy = new WCFSistemasServiceClient(new WCFSistemasServiceClient.EndpointConfiguration());
                Sistema vRootSystem = new Sistema()
                {
                    ID_Sistema = Environment.GetEnvironmentVariable(Constantes.KeyApp),
                    ID_Codigo_generado_plone = Usuario,
                    IP_Remoto = DnsFullNet.GetIp(),
                    Nombre_explorador = Request.Headers["User-Agent"].ToString(),
                    Nombre_pagina_web = Request.Path
                };

                try
                {
                    AddSistemaResult vResult = vProxy.AddSistema(vRootSystem);
                    var vSessionName = vResult.Usuario.ToString().Trim();

                    if (!string.IsNullOrEmpty(vSessionName))
                    {
                        var vRecord = await Services<SessionUserDto>.Obtener("FullSecurity/GeUserRoles?vAplicacion=" + vRootSystem.ID_Sistema + "&vUsuario=" + "ORODRIGUEZ");

                        if (vRecord.Roles.Any())
                        {
                            if (vRecord.Roles.Count == 1)
                            {
                                var vTmpRol = vRecord.Roles.FirstOrDefault();
                                var vOptions = await Services<RoleOptionsDto>.Listar("FullSecurity/ListOptionsRole?vAplicacion=" + vRootSystem.ID_Sistema + "&vRol=" + vTmpRol.RoleId);
                                vTmpRol.Options = vOptions;
                                vRecord.Roles.FirstOrDefault().Options = vTmpRol.Options;

                                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, IdentityGenerator.Execute(vRecord), new AuthenticationProperties
                                {
                                    ExpiresUtc = DateTime.Now.AddHours(8),
                                    IsPersistent = true
                                });
                                return RedirectToAction("Index", "Home");
                            }
                            else
                            {
                                ViewBag.CboRoles = vRecord.Roles.ConvertAll(x => { return new SelectListItem() { Text = x.RoleName, Value = x.RoleId.ToString() }; });
                                return View(model: Usuario);
                            }
                        }
                    }
                    return Redirect(Environment.GetEnvironmentVariable(Constantes.IntranetWeb));
                }
                catch (Exception ex)
                {
                    return Redirect(Environment.GetEnvironmentVariable(Constantes.IntranetWeb));
                }
            }
        }

        [HttpGet]
        public async Task<IActionResult> Rol(string Usuario = "22543420454344704748208510363511850513566516256517182518096519550520976523661523744526668524480525908528006529187530932532395533696534983536784538979", int Rol = 0)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                WCFSistemasServiceClient vProxy = new WCFSistemasServiceClient(new WCFSistemasServiceClient.EndpointConfiguration());
                Sistema vRootSystem = new Sistema()
                {
                    ID_Sistema = Environment.GetEnvironmentVariable(Constantes.KeyApp),
                    ID_Codigo_generado_plone = Usuario,
                    IP_Remoto = DnsFullNet.GetIp(),
                    Nombre_explorador = Request.Headers["User-Agent"].ToString(),
                    Nombre_pagina_web = Request.Path
                };

                try
                {
                    AddSistemaResult vResult = vProxy.AddSistema(vRootSystem);
                    var vSessionName = vResult.Usuario.ToString().Trim();

                    if (!string.IsNullOrEmpty(vSessionName))
                    {
                        var vRecord = await Services<SessionUserDto>.Obtener("FullSecurity/GeUserRoles?vAplicacion=" + vRootSystem.ID_Sistema + "&vUsuario=" + "ORODRIGUEZ");

                        if (vRecord.Roles.Any())
                        {
                            vRecord.Roles = vRecord.Roles.Where(x => x.RoleId == Rol).ToList();

                            if (vRecord.Roles.Any())
                            {
                                var vTmpRol = vRecord.Roles.FirstOrDefault();
                                var vOptions = await Services<RoleOptionsDto>.Listar("FullSecurity/ListOptionsRole?vAplicacion=" + vRootSystem.ID_Sistema + "&vRol=" + vTmpRol.RoleId);
                                vTmpRol.Options = vOptions;
                                vRecord.Roles.FirstOrDefault().Options = vTmpRol.Options;

                                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, IdentityGenerator.Execute(vRecord), new AuthenticationProperties
                                {
                                    ExpiresUtc = DateTime.Now.AddHours(8),
                                    IsPersistent = true
                                });
                                return RedirectToAction("Index", "Home");
                            }
                        }
                    }
                    return Redirect(Environment.GetEnvironmentVariable(Constantes.IntranetWeb));
                }
                catch (Exception ex)
                {
                    return Redirect(Environment.GetEnvironmentVariable(Constantes.IntranetWeb));
                }
            }
        }

        [HttpGet]
        public async Task<IActionResult> SignOff()
        {
            await HttpContext.SignOutAsync();
            return Redirect(Environment.GetEnvironmentVariable(Constantes.IntranetWeb));
        }

        [HttpGet]
        public ActionResult Error()
        {
            return View("Error");
        }
    }
}
