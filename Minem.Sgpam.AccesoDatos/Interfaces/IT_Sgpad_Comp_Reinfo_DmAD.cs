using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_COMP_REINFO_DM
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Comp_Reinfo_DmAD
    {
        IEnumerable<T_Sgpad_Comp_Reinfo_Dm> ListarT_Sgpad_Comp_Reinfo_Dm();
        T_Sgpad_Comp_Reinfo_Dm RecuperarT_Sgpad_Comp_Reinfo_DmPorCodigo(int vId_Comp_Reinfo_Dm);
        T_Sgpad_Comp_Reinfo_Dm InsertarT_Sgpad_Comp_Reinfo_Dm(T_Sgpad_Comp_Reinfo_Dm vT_Sgpad_Comp_Reinfo_Dm);
        T_Sgpad_Comp_Reinfo_Dm ActualizarT_Sgpad_Comp_Reinfo_Dm(T_Sgpad_Comp_Reinfo_Dm vT_Sgpad_Comp_Reinfo_Dm);
        int AnularT_Sgpad_Comp_Reinfo_DmPorCodigo(int vId_Comp_Reinfo_Dm);
        IEnumerable<T_Sgpad_Comp_Reinfo_Dm> ListarPaginadoT_Sgpad_Comp_Reinfo_Dm(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}