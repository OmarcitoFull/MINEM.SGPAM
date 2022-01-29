using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_CUENCA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_CuencaAD
    {
        IEnumerable<T_Sgpal_Cuenca> ListarT_Sgpal_Cuenca();
        T_Sgpal_Cuenca RecuperarT_Sgpal_CuencaPorCodigo(int vId_Cuenca);
        T_Sgpal_Cuenca InsertarT_Sgpal_Cuenca(T_Sgpal_Cuenca vT_Sgpal_Cuenca);
        T_Sgpal_Cuenca ActualizarT_Sgpal_Cuenca(T_Sgpal_Cuenca vT_Sgpal_Cuenca);
        int AnularT_Sgpal_CuencaPorCodigo(int vId_Cuenca);
        IEnumerable<T_Sgpal_Cuenca> ListarPaginadoT_Sgpal_Cuenca(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}