using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_TEMPORALIDAD
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_TemporalidadAD
    {
        IEnumerable<T_Sgpal_Temporalidad> ListarT_Sgpal_Temporalidad();
        T_Sgpal_Temporalidad RecuperarT_Sgpal_TemporalidadPorCodigo(int vId_Temporalidad);
        T_Sgpal_Temporalidad InsertarT_Sgpal_Temporalidad(T_Sgpal_Temporalidad vT_Sgpal_Temporalidad);
        T_Sgpal_Temporalidad ActualizarT_Sgpal_Temporalidad(T_Sgpal_Temporalidad vT_Sgpal_Temporalidad);
        int AnularT_Sgpal_TemporalidadPorCodigo(int vId_Temporalidad);
        IEnumerable<T_Sgpal_Temporalidad> ListarPaginadoT_Sgpal_Temporalidad(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}