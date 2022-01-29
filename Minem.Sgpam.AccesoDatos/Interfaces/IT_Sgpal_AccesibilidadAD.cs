using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_ACCESIBILIDAD
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_AccesibilidadAD
    {
        IEnumerable<T_Sgpal_Accesibilidad> ListarT_Sgpal_Accesibilidad();
        T_Sgpal_Accesibilidad RecuperarT_Sgpal_AccesibilidadPorCodigo(int vId_Accesibilidad);
        T_Sgpal_Accesibilidad InsertarT_Sgpal_Accesibilidad(T_Sgpal_Accesibilidad vT_Sgpal_Accesibilidad);
        T_Sgpal_Accesibilidad ActualizarT_Sgpal_Accesibilidad(T_Sgpal_Accesibilidad vT_Sgpal_Accesibilidad);
        int AnularT_Sgpal_AccesibilidadPorCodigo(int vId_Accesibilidad);
        IEnumerable<T_Sgpal_Accesibilidad> ListarPaginadoT_Sgpal_Accesibilidad(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}