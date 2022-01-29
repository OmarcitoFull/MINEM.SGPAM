using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_EUM_UBICACION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Eum_UbicacionAD
    {
        IEnumerable<T_Sgpad_Eum_Ubicacion> ListarT_Sgpad_Eum_Ubicacion();
        T_Sgpad_Eum_Ubicacion RecuperarT_Sgpad_Eum_UbicacionPorCodigo(int vId_Eum_Ubicacion);
        T_Sgpad_Eum_Ubicacion InsertarT_Sgpad_Eum_Ubicacion(T_Sgpad_Eum_Ubicacion vT_Sgpad_Eum_Ubicacion);
        T_Sgpad_Eum_Ubicacion ActualizarT_Sgpad_Eum_Ubicacion(T_Sgpad_Eum_Ubicacion vT_Sgpad_Eum_Ubicacion);
        int AnularT_Sgpad_Eum_UbicacionPorCodigo(int vId_Eum_Ubicacion);
        IEnumerable<T_Sgpad_Eum_Ubicacion> ListarPaginadoT_Sgpad_Eum_Ubicacion(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}