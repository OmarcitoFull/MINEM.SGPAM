using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minem.Sgpam.WebApi.Controllers
{
    /// <summary>
    /// Objetivo:	Controlador que implementa los servicios
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	31/10/2021
    /// </summary>
    public class FullSecurityController : BaseController
    {
        public readonly IV_SeguridadLN SeguridadLN;

        public FullSecurityController(IV_SeguridadLN vIV_SeguridadLN)
        {
            SeguridadLN = vIV_SeguridadLN;
        }

        [HttpGet("GeUserRoles")]
        public SessionUserDto GeUserRoles(int vAplicacion, string vUsuario)
        {
            return SeguridadLN.ObtenerUsuarioRoles(vAplicacion, vUsuario);
        }

        [HttpGet("ListOptionsRole")]
        public List<RoleOptionsDto> ListOptionsRole(int vAplicacion, int vRol)
        {
            return SeguridadLN.ObtenerRolOpciones(vAplicacion, vRol);
        }
    }
}
