using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_Inspector
    /// Creado Por:	Mateo Salvador Paucar
    /// Fecha Creación:	20/02/2022
    /// </summary>
    public interface IT_Sgpal_InspectorAD
    {
        IEnumerable<T_Sgpal_Inspector> ListarT_Sgpal_Inspector();
        T_Sgpal_Inspector RecuperarT_Sgpal_InspectorPorCodigo(int vId_Inspector);
        T_Sgpal_Inspector InsertarT_Sgpal_Inspector(T_Sgpal_Inspector vT_Sgpal_Inspector);
        T_Sgpal_Inspector ActualizarT_Sgpal_Inspector(T_Sgpal_Inspector vT_Sgpal_Inspector);
        int AnularT_Sgpal_InspectorPorCodigo(int vId_Inspector);
        IEnumerable<T_Sgpal_Inspector> ListarPaginadoT_Sgpal_Inspector(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}
