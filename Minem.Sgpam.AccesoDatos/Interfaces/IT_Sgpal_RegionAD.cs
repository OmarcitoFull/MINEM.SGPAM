using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_REGION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_RegionAD
    {
        IEnumerable<T_Sgpal_Region> ListarT_Sgpal_Region();
        T_Sgpal_Region RecuperarT_Sgpal_RegionPorCodigo(int vId_Region);
        T_Sgpal_Region InsertarT_Sgpal_Region(T_Sgpal_Region vT_Sgpal_Region);
        T_Sgpal_Region ActualizarT_Sgpal_Region(T_Sgpal_Region vT_Sgpal_Region);
        int AnularT_Sgpal_RegionPorCodigo(int vId_Region);
        IEnumerable<T_Sgpal_Region> ListarPaginadoT_Sgpal_Region(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}