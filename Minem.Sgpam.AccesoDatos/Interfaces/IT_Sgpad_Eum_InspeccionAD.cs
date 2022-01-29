using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_EUM_INSPECCION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Eum_InspeccionAD
    {
        IEnumerable<T_Sgpad_Eum_Inspeccion> ListarT_Sgpad_Eum_Inspeccion();
        T_Sgpad_Eum_Inspeccion RecuperarT_Sgpad_Eum_InspeccionPorCodigo(int vId_Eum_Inspeccion);
        T_Sgpad_Eum_Inspeccion InsertarT_Sgpad_Eum_Inspeccion(T_Sgpad_Eum_Inspeccion vT_Sgpad_Eum_Inspeccion);
        T_Sgpad_Eum_Inspeccion ActualizarT_Sgpad_Eum_Inspeccion(T_Sgpad_Eum_Inspeccion vT_Sgpad_Eum_Inspeccion);
        int AnularT_Sgpad_Eum_InspeccionPorCodigo(int vId_Eum_Inspeccion);
        IEnumerable<T_Sgpad_Eum_Inspeccion> ListarPaginadoT_Sgpad_Eum_Inspeccion(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<T_Sgpad_Eum_Inspeccion> ListarPorIdEumT_Sgpad_Eum_Inspeccion(int vId_Eum);
    }
}