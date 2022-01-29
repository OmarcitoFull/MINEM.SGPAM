using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_COMP_RIESGO_FAU_CON
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Comp_Riesgo_Fau_ConAD
    {
        IEnumerable<V_Sgpad_Comp_Riesgo_Fau_Con> ListarT_Sgpad_Comp_Riesgo_Fau_Con(int vIdComponente);
        T_Sgpad_Comp_Riesgo_Fau_Con RecuperarT_Sgpad_Comp_Riesgo_Fau_ConPorCodigo(int vId_Comp_Riesgo_Fau_Con);
        T_Sgpad_Comp_Riesgo_Fau_Con InsertarT_Sgpad_Comp_Riesgo_Fau_Con(T_Sgpad_Comp_Riesgo_Fau_Con vT_Sgpad_Comp_Riesgo_Fau_Con);
        T_Sgpad_Comp_Riesgo_Fau_Con ActualizarT_Sgpad_Comp_Riesgo_Fau_Con(T_Sgpad_Comp_Riesgo_Fau_Con vT_Sgpad_Comp_Riesgo_Fau_Con);
        int AnularT_Sgpad_Comp_Riesgo_Fau_ConPorCodigo(int vId_Comp_Riesgo_Fau_Con);
        IEnumerable<T_Sgpad_Comp_Riesgo_Fau_Con> ListarPaginadoT_Sgpad_Comp_Riesgo_Fau_Con(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}