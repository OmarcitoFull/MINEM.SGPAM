using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_SITUACION_PAM
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Situacion_PamAD
    {
        IEnumerable<T_Sgpal_Situacion_Pam> ListarT_Sgpal_Situacion_Pam();
        T_Sgpal_Situacion_Pam RecuperarT_Sgpal_Situacion_PamPorCodigo(int vId_Situacion_Pam);
        T_Sgpal_Situacion_Pam InsertarT_Sgpal_Situacion_Pam(T_Sgpal_Situacion_Pam vT_Sgpal_Situacion_Pam);
        T_Sgpal_Situacion_Pam ActualizarT_Sgpal_Situacion_Pam(T_Sgpal_Situacion_Pam vT_Sgpal_Situacion_Pam);
        int AnularT_Sgpal_Situacion_PamPorCodigo(int vId_Situacion_Pam);
        IEnumerable<T_Sgpal_Situacion_Pam> ListarPaginadoT_Sgpal_Situacion_Pam(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}