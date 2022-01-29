using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_CONDICION_CIERRE
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Condicion_CierreAD
    {
        IEnumerable<T_Sgpal_Condicion_Cierre> ListarT_Sgpal_Condicion_Cierre();
        T_Sgpal_Condicion_Cierre RecuperarT_Sgpal_Condicion_CierrePorCodigo(int vId_Condicion_Cierre);
        T_Sgpal_Condicion_Cierre InsertarT_Sgpal_Condicion_Cierre(T_Sgpal_Condicion_Cierre vT_Sgpal_Condicion_Cierre);
        T_Sgpal_Condicion_Cierre ActualizarT_Sgpal_Condicion_Cierre(T_Sgpal_Condicion_Cierre vT_Sgpal_Condicion_Cierre);
        int AnularT_Sgpal_Condicion_CierrePorCodigo(int vId_Condicion_Cierre);
        IEnumerable<T_Sgpal_Condicion_Cierre> ListarPaginadoT_Sgpal_Condicion_Cierre(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}