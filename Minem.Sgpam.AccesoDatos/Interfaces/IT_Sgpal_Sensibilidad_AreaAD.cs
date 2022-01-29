using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_SENSIBILIDAD_AREA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Sensibilidad_AreaAD
    {
        IEnumerable<T_Sgpal_Sensibilidad_Area> ListarT_Sgpal_Sensibilidad_Area();
        T_Sgpal_Sensibilidad_Area RecuperarT_Sgpal_Sensibilidad_AreaPorCodigo(int vId_Sensibilidad_Area);
        T_Sgpal_Sensibilidad_Area InsertarT_Sgpal_Sensibilidad_Area(T_Sgpal_Sensibilidad_Area vT_Sgpal_Sensibilidad_Area);
        T_Sgpal_Sensibilidad_Area ActualizarT_Sgpal_Sensibilidad_Area(T_Sgpal_Sensibilidad_Area vT_Sgpal_Sensibilidad_Area);
        int AnularT_Sgpal_Sensibilidad_AreaPorCodigo(int vId_Sensibilidad_Area);
        IEnumerable<T_Sgpal_Sensibilidad_Area> ListarPaginadoT_Sgpal_Sensibilidad_Area(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}