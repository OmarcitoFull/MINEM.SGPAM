using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.LogicaNegocio.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula los reportes e informes
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	02/06/2022
    /// </summary>
    public interface IV_SeguridadLN
    {
        SessionUserDto ObtenerUsuarioRoles(int vAplicacion, string vUsuario);
        List<RoleOptionsDto> ObtenerRolOpciones(int vAplicacion, int vRol);
    }
}
