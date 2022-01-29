using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_EVIDENCIA_EROSION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Evidencia_ErosionAD
    {
        IEnumerable<T_Sgpal_Evidencia_Erosion> ListarT_Sgpal_Evidencia_Erosion();
        T_Sgpal_Evidencia_Erosion RecuperarT_Sgpal_Evidencia_ErosionPorCodigo(int vId_Evidencia_Erosion);
        T_Sgpal_Evidencia_Erosion InsertarT_Sgpal_Evidencia_Erosion(T_Sgpal_Evidencia_Erosion vT_Sgpal_Evidencia_Erosion);
        T_Sgpal_Evidencia_Erosion ActualizarT_Sgpal_Evidencia_Erosion(T_Sgpal_Evidencia_Erosion vT_Sgpal_Evidencia_Erosion);
        int AnularT_Sgpal_Evidencia_ErosionPorCodigo(int vId_Evidencia_Erosion);
        IEnumerable<T_Sgpal_Evidencia_Erosion> ListarPaginadoT_Sgpal_Evidencia_Erosion(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}