using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_CONTENCION_RESIDUO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Contencion_ResiduoAD
    {
        IEnumerable<T_Sgpal_Contencion_Residuo> ListarT_Sgpal_Contencion_Residuo();
        T_Sgpal_Contencion_Residuo RecuperarT_Sgpal_Contencion_ResiduoPorCodigo(int vId_Contencion_Residuo);
        T_Sgpal_Contencion_Residuo InsertarT_Sgpal_Contencion_Residuo(T_Sgpal_Contencion_Residuo vT_Sgpal_Contencion_Residuo);
        T_Sgpal_Contencion_Residuo ActualizarT_Sgpal_Contencion_Residuo(T_Sgpal_Contencion_Residuo vT_Sgpal_Contencion_Residuo);
        int AnularT_Sgpal_Contencion_ResiduoPorCodigo(int vId_Contencion_Residuo);
        IEnumerable<T_Sgpal_Contencion_Residuo> ListarPaginadoT_Sgpal_Contencion_Residuo(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}