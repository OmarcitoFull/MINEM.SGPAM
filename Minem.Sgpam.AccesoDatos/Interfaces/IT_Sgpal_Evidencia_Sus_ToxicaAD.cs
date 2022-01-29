using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_EVIDENCIA_SUS_TOXICA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Evidencia_Sus_ToxicaAD
    {
        IEnumerable<T_Sgpal_Evidencia_Sus_Toxica> ListarT_Sgpal_Evidencia_Sus_Toxica();
        T_Sgpal_Evidencia_Sus_Toxica RecuperarT_Sgpal_Evidencia_Sus_ToxicaPorCodigo(int vId_Evidencia_Sus_Toxica);
        T_Sgpal_Evidencia_Sus_Toxica InsertarT_Sgpal_Evidencia_Sus_Toxica(T_Sgpal_Evidencia_Sus_Toxica vT_Sgpal_Evidencia_Sus_Toxica);
        T_Sgpal_Evidencia_Sus_Toxica ActualizarT_Sgpal_Evidencia_Sus_Toxica(T_Sgpal_Evidencia_Sus_Toxica vT_Sgpal_Evidencia_Sus_Toxica);
        int AnularT_Sgpal_Evidencia_Sus_ToxicaPorCodigo(int vId_Evidencia_Sus_Toxica);
        IEnumerable<T_Sgpal_Evidencia_Sus_Toxica> ListarPaginadoT_Sgpal_Evidencia_Sus_Toxica(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}