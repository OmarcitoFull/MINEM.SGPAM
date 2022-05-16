using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_COMP_DM_SITUACION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Comp_Dm_SituacionAD
    {
        IEnumerable<T_Sgpad_Comp_Dm_Situacion> ListarT_Sgpad_Comp_Dm_Situacion();
        T_Sgpad_Comp_Dm_Situacion RecuperarT_Sgpad_Comp_Dm_SituacionPorCodigo(int vId_Comp_Dm_Situacion);
        T_Sgpad_Comp_Dm_Situacion InsertarT_Sgpad_Comp_Dm_Situacion(T_Sgpad_Comp_Dm_Situacion vT_Sgpad_Comp_Dm_Situacion);
        T_Sgpad_Comp_Dm_Situacion ActualizarT_Sgpad_Comp_Dm_Situacion(T_Sgpad_Comp_Dm_Situacion vT_Sgpad_Comp_Dm_Situacion);
        int AnularT_Sgpad_Comp_Dm_SituacionPorCodigo(int vId_Comp_Dm_Situacion);
        IEnumerable<T_Sgpad_Comp_Dm_Situacion> ListarPaginadoT_Sgpad_Comp_Dm_Situacion(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<V_Sgpad_Comp_Dm_Situacion> ListarPorIdEumT_Sgpad_Comp_Dm_Situacion(int vId_Eum);
    }
}