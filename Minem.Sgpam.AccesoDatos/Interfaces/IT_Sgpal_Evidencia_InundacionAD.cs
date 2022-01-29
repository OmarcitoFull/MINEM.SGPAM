using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_EVIDENCIA_INUNDACION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Evidencia_InundacionAD
    {
        IEnumerable<T_Sgpal_Evidencia_Inundacion> ListarT_Sgpal_Evidencia_Inundacion();
        T_Sgpal_Evidencia_Inundacion RecuperarT_Sgpal_Evidencia_InundacionPorCodigo(int vId_Evidencia_Inundacion);
        T_Sgpal_Evidencia_Inundacion InsertarT_Sgpal_Evidencia_Inundacion(T_Sgpal_Evidencia_Inundacion vT_Sgpal_Evidencia_Inundacion);
        T_Sgpal_Evidencia_Inundacion ActualizarT_Sgpal_Evidencia_Inundacion(T_Sgpal_Evidencia_Inundacion vT_Sgpal_Evidencia_Inundacion);
        int AnularT_Sgpal_Evidencia_InundacionPorCodigo(int vId_Evidencia_Inundacion);
        IEnumerable<T_Sgpal_Evidencia_Inundacion> ListarPaginadoT_Sgpal_Evidencia_Inundacion(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}