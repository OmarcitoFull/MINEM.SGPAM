using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_PRESENCIA_ASBESTOS
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Presencia_AsbestosAD
    {
        IEnumerable<T_Sgpal_Presencia_Asbestos> ListarT_Sgpal_Presencia_Asbestos();
        T_Sgpal_Presencia_Asbestos RecuperarT_Sgpal_Presencia_AsbestosPorCodigo(int vId_Presencia_Asbestos);
        T_Sgpal_Presencia_Asbestos InsertarT_Sgpal_Presencia_Asbestos(T_Sgpal_Presencia_Asbestos vT_Sgpal_Presencia_Asbestos);
        T_Sgpal_Presencia_Asbestos ActualizarT_Sgpal_Presencia_Asbestos(T_Sgpal_Presencia_Asbestos vT_Sgpal_Presencia_Asbestos);
        int AnularT_Sgpal_Presencia_AsbestosPorCodigo(int vId_Presencia_Asbestos);
        IEnumerable<T_Sgpal_Presencia_Asbestos> ListarPaginadoT_Sgpal_Presencia_Asbestos(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}