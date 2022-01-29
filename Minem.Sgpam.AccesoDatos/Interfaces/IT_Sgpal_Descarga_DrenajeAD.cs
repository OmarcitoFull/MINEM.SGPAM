using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_DESCARGA_DRENAJE
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Descarga_DrenajeAD
    {
        IEnumerable<T_Sgpal_Descarga_Drenaje> ListarT_Sgpal_Descarga_Drenaje();
        T_Sgpal_Descarga_Drenaje RecuperarT_Sgpal_Descarga_DrenajePorCodigo(int vId_Descarga_Drenaje);
        T_Sgpal_Descarga_Drenaje InsertarT_Sgpal_Descarga_Drenaje(T_Sgpal_Descarga_Drenaje vT_Sgpal_Descarga_Drenaje);
        T_Sgpal_Descarga_Drenaje ActualizarT_Sgpal_Descarga_Drenaje(T_Sgpal_Descarga_Drenaje vT_Sgpal_Descarga_Drenaje);
        int AnularT_Sgpal_Descarga_DrenajePorCodigo(int vId_Descarga_Drenaje);
        IEnumerable<T_Sgpal_Descarga_Drenaje> ListarPaginadoT_Sgpal_Descarga_Drenaje(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}