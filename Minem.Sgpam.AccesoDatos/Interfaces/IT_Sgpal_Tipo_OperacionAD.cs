using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_TIPO_OPERACION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Tipo_OperacionAD
    {
        IEnumerable<T_Sgpal_Tipo_Operacion> ListarT_Sgpal_Tipo_Operacion();
        T_Sgpal_Tipo_Operacion RecuperarT_Sgpal_Tipo_OperacionPorCodigo(int vId_Tipo_Operacion);
        T_Sgpal_Tipo_Operacion InsertarT_Sgpal_Tipo_Operacion(T_Sgpal_Tipo_Operacion vT_Sgpal_Tipo_Operacion);
        T_Sgpal_Tipo_Operacion ActualizarT_Sgpal_Tipo_Operacion(T_Sgpal_Tipo_Operacion vT_Sgpal_Tipo_Operacion);
        int AnularT_Sgpal_Tipo_OperacionPorCodigo(T_Sgpal_Tipo_Operacion vT_Sgpal_Tipo_Operacion);
        IEnumerable<T_Sgpal_Tipo_Operacion> ListarPaginadoT_Sgpal_Tipo_Operacion(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}