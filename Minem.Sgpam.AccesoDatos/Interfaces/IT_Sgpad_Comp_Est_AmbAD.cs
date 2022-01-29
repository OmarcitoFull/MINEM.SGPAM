using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_COMP_EST_AMB
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Comp_Est_AmbAD
    {
        IEnumerable<T_Sgpad_Comp_Est_Amb> ListarT_Sgpad_Comp_Est_Amb(int vIdComponente);
        T_Sgpad_Comp_Est_Amb RecuperarT_Sgpad_Comp_Est_AmbPorCodigo(int vId_Comp_Est_Amb);
        T_Sgpad_Comp_Est_Amb InsertarT_Sgpad_Comp_Est_Amb(T_Sgpad_Comp_Est_Amb vT_Sgpad_Comp_Est_Amb);
        T_Sgpad_Comp_Est_Amb ActualizarT_Sgpad_Comp_Est_Amb(T_Sgpad_Comp_Est_Amb vT_Sgpad_Comp_Est_Amb);
        int AnularT_Sgpad_Comp_Est_AmbPorCodigo(int vId_Comp_Est_Amb);
        IEnumerable<T_Sgpad_Comp_Est_Amb> ListarPaginadoT_Sgpad_Comp_Est_Amb(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}