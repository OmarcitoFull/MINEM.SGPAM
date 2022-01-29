using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_TIPO_PAM
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Tipo_PamAD
    {
        IEnumerable<T_Sgpal_Tipo_Pam> ListarT_Sgpal_Tipo_Pam();
        T_Sgpal_Tipo_Pam RecuperarT_Sgpal_Tipo_PamPorCodigo(int vId_Tipo_Pam);
        T_Sgpal_Tipo_Pam InsertarT_Sgpal_Tipo_Pam(T_Sgpal_Tipo_Pam vT_Sgpal_Tipo_Pam);
        T_Sgpal_Tipo_Pam ActualizarT_Sgpal_Tipo_Pam(T_Sgpal_Tipo_Pam vT_Sgpal_Tipo_Pam);
        int AnularT_Sgpal_Tipo_PamPorCodigo(int vId_Tipo_Pam);
        IEnumerable<T_Sgpal_Tipo_Pam> ListarPaginadoT_Sgpal_Tipo_Pam(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}