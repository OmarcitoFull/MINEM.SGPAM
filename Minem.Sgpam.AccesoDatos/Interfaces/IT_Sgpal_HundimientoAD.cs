using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_HUNDIMIENTO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_HundimientoAD
    {
        IEnumerable<T_Sgpal_Hundimiento> ListarT_Sgpal_Hundimiento();
        T_Sgpal_Hundimiento RecuperarT_Sgpal_HundimientoPorCodigo(int vId_Hundimiento);
        T_Sgpal_Hundimiento InsertarT_Sgpal_Hundimiento(T_Sgpal_Hundimiento vT_Sgpal_Hundimiento);
        T_Sgpal_Hundimiento ActualizarT_Sgpal_Hundimiento(T_Sgpal_Hundimiento vT_Sgpal_Hundimiento);
        int AnularT_Sgpal_HundimientoPorCodigo(int vId_Hundimiento);
        IEnumerable<T_Sgpal_Hundimiento> ListarPaginadoT_Sgpal_Hundimiento(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}