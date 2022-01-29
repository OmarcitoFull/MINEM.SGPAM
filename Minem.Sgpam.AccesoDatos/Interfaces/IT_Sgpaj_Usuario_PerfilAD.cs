using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAJ_USUARIO_PERFIL
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpaj_Usuario_PerfilAD
    {
        IEnumerable<T_Sgpaj_Usuario_Perfil> ListarT_Sgpaj_Usuario_Perfil();
        T_Sgpaj_Usuario_Perfil RecuperarT_Sgpaj_Usuario_PerfilPorCodigo(int vId_Usuario_Perfil);
        T_Sgpaj_Usuario_Perfil InsertarT_Sgpaj_Usuario_Perfil(T_Sgpaj_Usuario_Perfil vT_Sgpaj_Usuario_Perfil);
        T_Sgpaj_Usuario_Perfil ActualizarT_Sgpaj_Usuario_Perfil(T_Sgpaj_Usuario_Perfil vT_Sgpaj_Usuario_Perfil);
        int AnularT_Sgpaj_Usuario_PerfilPorCodigo(int vId_Usuario_Perfil);
        IEnumerable<T_Sgpaj_Usuario_Perfil> ListarPaginadoT_Sgpaj_Usuario_Perfil(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}