using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_PRESENCIA_ADVERTENCIA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Presencia_AdvertenciaAD
    {
        IEnumerable<T_Sgpal_Presencia_Advertencia> ListarT_Sgpal_Presencia_Advertencia();
        T_Sgpal_Presencia_Advertencia RecuperarT_Sgpal_Presencia_AdvertenciaPorCodigo(int vId_Presencia_Advertencia);
        T_Sgpal_Presencia_Advertencia InsertarT_Sgpal_Presencia_Advertencia(T_Sgpal_Presencia_Advertencia vT_Sgpal_Presencia_Advertencia);
        T_Sgpal_Presencia_Advertencia ActualizarT_Sgpal_Presencia_Advertencia(T_Sgpal_Presencia_Advertencia vT_Sgpal_Presencia_Advertencia);
        int AnularT_Sgpal_Presencia_AdvertenciaPorCodigo(int vId_Presencia_Advertencia);
        IEnumerable<T_Sgpal_Presencia_Advertencia> ListarPaginadoT_Sgpal_Presencia_Advertencia(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}