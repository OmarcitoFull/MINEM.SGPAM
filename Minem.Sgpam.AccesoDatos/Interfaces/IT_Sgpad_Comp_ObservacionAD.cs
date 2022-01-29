using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_COMP_OBSERVACION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Comp_ObservacionAD
    {
        IEnumerable<T_Sgpad_Comp_Observacion> ListarT_Sgpad_Comp_Observacion(int vIdComponente);
        T_Sgpad_Comp_Observacion RecuperarT_Sgpad_Comp_ObservacionPorCodigo(int vId_Comp_Observacion);
        T_Sgpad_Comp_Observacion InsertarT_Sgpad_Comp_Observacion(T_Sgpad_Comp_Observacion vT_Sgpad_Comp_Observacion);
        T_Sgpad_Comp_Observacion ActualizarT_Sgpad_Comp_Observacion(T_Sgpad_Comp_Observacion vT_Sgpad_Comp_Observacion);
        int AnularT_Sgpad_Comp_ObservacionPorCodigo(int vId_Comp_Observacion);
        IEnumerable<T_Sgpad_Comp_Observacion> ListarPaginadoT_Sgpad_Comp_Observacion(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}