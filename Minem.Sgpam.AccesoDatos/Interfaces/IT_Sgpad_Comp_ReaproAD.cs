using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_COMP_REAPRO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Comp_ReaproAD
    {
        IEnumerable<T_Sgpad_Comp_Reapro> ListarT_Sgpad_Comp_Reapro(int vIdComponente);
        T_Sgpad_Comp_Reapro RecuperarT_Sgpad_Comp_ReaproPorCodigo(int vId_Comp_Reapro);
        T_Sgpad_Comp_Reapro InsertarT_Sgpad_Comp_Reapro(T_Sgpad_Comp_Reapro vT_Sgpad_Comp_Reapro);
        T_Sgpad_Comp_Reapro ActualizarT_Sgpad_Comp_Reapro(T_Sgpad_Comp_Reapro vT_Sgpad_Comp_Reapro);
        int AnularT_Sgpad_Comp_ReaproPorCodigo(int vId_Comp_Reapro);
        IEnumerable<T_Sgpad_Comp_Reapro> ListarPaginadoT_Sgpad_Comp_Reapro(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}