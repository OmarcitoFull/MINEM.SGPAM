using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_TIPO_CONCESION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Tipo_ConcesionAD
    {
        IEnumerable<T_Sgpal_Tipo_Concesion> ListarT_Sgpal_Tipo_Concesion();
        T_Sgpal_Tipo_Concesion RecuperarT_Sgpal_Tipo_ConcesionPorCodigo(int vId_Tipo_Concesion);
        T_Sgpal_Tipo_Concesion InsertarT_Sgpal_Tipo_Concesion(T_Sgpal_Tipo_Concesion vT_Sgpal_Tipo_Concesion);
        T_Sgpal_Tipo_Concesion ActualizarT_Sgpal_Tipo_Concesion(T_Sgpal_Tipo_Concesion vT_Sgpal_Tipo_Concesion);
        int AnularT_Sgpal_Tipo_ConcesionPorCodigo(int vId_Tipo_Concesion);
        IEnumerable<T_Sgpal_Tipo_Concesion> ListarPaginadoT_Sgpal_Tipo_Concesion(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}