using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_COMP_RIESGO_SAL_AMB
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Comp_Riesgo_Sal_AmbAD
    {
        IEnumerable<V_Sgpad_Comp_Riesgo_Sal_Amb> ListarT_Sgpad_Comp_Riesgo_Sal_Amb(int vIdComponente);
        T_Sgpad_Comp_Riesgo_Sal_Amb RecuperarT_Sgpad_Comp_Riesgo_Sal_AmbPorCodigo(int vId_Comp_Riesgo_Sal_Amb);
        T_Sgpad_Comp_Riesgo_Sal_Amb InsertarT_Sgpad_Comp_Riesgo_Sal_Amb(T_Sgpad_Comp_Riesgo_Sal_Amb vT_Sgpad_Comp_Riesgo_Sal_Amb);
        T_Sgpad_Comp_Riesgo_Sal_Amb ActualizarT_Sgpad_Comp_Riesgo_Sal_Amb(T_Sgpad_Comp_Riesgo_Sal_Amb vT_Sgpad_Comp_Riesgo_Sal_Amb);
        int AnularT_Sgpad_Comp_Riesgo_Sal_AmbPorCodigo(int vId_Comp_Riesgo_Sal_Amb);
        IEnumerable<T_Sgpad_Comp_Riesgo_Sal_Amb> ListarPaginadoT_Sgpad_Comp_Riesgo_Sal_Amb(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}