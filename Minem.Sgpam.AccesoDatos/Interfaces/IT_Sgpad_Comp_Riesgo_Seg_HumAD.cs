using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_COMP_RIESGO_SEG_HUM
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Comp_Riesgo_Seg_HumAD
    {
        IEnumerable<V_Sgpad_Comp_Riesgo_Seg_Hum> ListarT_Sgpad_Comp_Riesgo_Seg_Hum(int vIdComponente);
        T_Sgpad_Comp_Riesgo_Seg_Hum RecuperarT_Sgpad_Comp_Riesgo_Seg_HumPorCodigo(int vId_Comp_Riesgo_Seg_Hum);
        T_Sgpad_Comp_Riesgo_Seg_Hum InsertarT_Sgpad_Comp_Riesgo_Seg_Hum(T_Sgpad_Comp_Riesgo_Seg_Hum vT_Sgpad_Comp_Riesgo_Seg_Hum);
        T_Sgpad_Comp_Riesgo_Seg_Hum ActualizarT_Sgpad_Comp_Riesgo_Seg_Hum(T_Sgpad_Comp_Riesgo_Seg_Hum vT_Sgpad_Comp_Riesgo_Seg_Hum);
        int AnularT_Sgpad_Comp_Riesgo_Seg_HumPorCodigo(int vId_Comp_Riesgo_Seg_Hum);
        IEnumerable<T_Sgpad_Comp_Riesgo_Seg_Hum> ListarPaginadoT_Sgpad_Comp_Riesgo_Seg_Hum(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}