using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_TIPO_RESOLUCION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Tipo_ResolucionAD
    {
        IEnumerable<T_Sgpal_Tipo_Resolucion> ListarT_Sgpal_Tipo_Resolucion();
        T_Sgpal_Tipo_Resolucion RecuperarT_Sgpal_Tipo_ResolucionPorCodigo(int vId_Tipo_Resolucion);
        T_Sgpal_Tipo_Resolucion InsertarT_Sgpal_Tipo_Resolucion(T_Sgpal_Tipo_Resolucion vT_Sgpal_Tipo_Resolucion);
        T_Sgpal_Tipo_Resolucion ActualizarT_Sgpal_Tipo_Resolucion(T_Sgpal_Tipo_Resolucion vT_Sgpal_Tipo_Resolucion);
        int AnularT_Sgpal_Tipo_ResolucionPorCodigo(int vId_Tipo_Resolucion);
        IEnumerable<T_Sgpal_Tipo_Resolucion> ListarPaginadoT_Sgpal_Tipo_Resolucion(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}