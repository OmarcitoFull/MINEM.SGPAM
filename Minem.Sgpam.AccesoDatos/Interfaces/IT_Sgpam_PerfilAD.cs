using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAM_PERFIL
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpam_PerfilAD
    {
        IEnumerable<T_Sgpam_Perfil> ListarT_Sgpam_Perfil();
        T_Sgpam_Perfil RecuperarT_Sgpam_PerfilPorCodigo(int vId_Perfil);
        T_Sgpam_Perfil InsertarT_Sgpam_Perfil(T_Sgpam_Perfil vT_Sgpam_Perfil);
        T_Sgpam_Perfil ActualizarT_Sgpam_Perfil(T_Sgpam_Perfil vT_Sgpam_Perfil);
        int AnularT_Sgpam_PerfilPorCodigo(int vId_Perfil);
        IEnumerable<T_Sgpam_Perfil> ListarPaginadoT_Sgpam_Perfil(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}