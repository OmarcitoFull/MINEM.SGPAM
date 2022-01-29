using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_COMP_EST_GESTION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Comp_Est_GestionAD
    {
        IEnumerable<V_Sgpad_Comp_Est_Gestion> ListarT_Sgpad_Comp_Est_Gestion(int vIdComponente);
        T_Sgpad_Comp_Est_Gestion RecuperarT_Sgpad_Comp_Est_GestionPorCodigo(int vId_Comp_Est_Gestion);
        T_Sgpad_Comp_Est_Gestion InsertarT_Sgpad_Comp_Est_Gestion(T_Sgpad_Comp_Est_Gestion vT_Sgpad_Comp_Est_Gestion);
        T_Sgpad_Comp_Est_Gestion ActualizarT_Sgpad_Comp_Est_Gestion(T_Sgpad_Comp_Est_Gestion vT_Sgpad_Comp_Est_Gestion);
        int AnularT_Sgpad_Comp_Est_GestionPorCodigo(int vId_Comp_Est_Gestion);
        IEnumerable<T_Sgpad_Comp_Est_Gestion> ListarPaginadoT_Sgpad_Comp_Est_Gestion(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}