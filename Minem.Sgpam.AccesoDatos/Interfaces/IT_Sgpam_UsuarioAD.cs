using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAM_USUARIO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpam_UsuarioAD
    {
        IEnumerable<T_Sgpam_Usuario> ListarT_Sgpam_Usuario();
        T_Sgpam_Usuario RecuperarT_Sgpam_UsuarioPorCodigo(int vId_Usuario);
        T_Sgpam_Usuario InsertarT_Sgpam_Usuario(T_Sgpam_Usuario vT_Sgpam_Usuario);
        T_Sgpam_Usuario ActualizarT_Sgpam_Usuario(T_Sgpam_Usuario vT_Sgpam_Usuario);
        int AnularT_Sgpam_UsuarioPorCodigo(int vId_Usuario);
        IEnumerable<T_Sgpam_Usuario> ListarPaginadoT_Sgpam_Usuario(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}