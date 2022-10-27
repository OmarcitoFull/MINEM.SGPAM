using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_GENL_UBIGEO_INEI
    /// Creado Por:	Mateo Salvador Paucar
    /// Fecha Creación:	31/03/2022
    /// </summary>
    public interface IV_SeguridadAD
    {
        IEnumerable<V_UsuarioRoles> ListarUsuarioRoles(int vAplicacion, string vUsuario);
        IEnumerable<V_RolOpciones> ListarRolOpciones(int vAplicacion, int vRol);
    }
}
