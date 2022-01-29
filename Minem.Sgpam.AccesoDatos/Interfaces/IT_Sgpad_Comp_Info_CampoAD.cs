using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_COMP_INFO_CAMPO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Comp_Info_CampoAD
    {
        IEnumerable<T_Sgpad_Comp_Info_Campo> ListarT_Sgpad_Comp_Info_Campo(int vIdComponente);
        T_Sgpad_Comp_Info_Campo RecuperarT_Sgpad_Comp_Info_CampoPorCodigo(int vId_Comp_Info_Campo);
        T_Sgpad_Comp_Info_Campo InsertarT_Sgpad_Comp_Info_Campo(T_Sgpad_Comp_Info_Campo vT_Sgpad_Comp_Info_Campo);
        T_Sgpad_Comp_Info_Campo ActualizarT_Sgpad_Comp_Info_Campo(T_Sgpad_Comp_Info_Campo vT_Sgpad_Comp_Info_Campo);
        int AnularT_Sgpad_Comp_Info_CampoPorCodigo(int vId_Comp_Info_Campo);
        IEnumerable<T_Sgpad_Comp_Info_Campo> ListarPaginadoT_Sgpad_Comp_Info_Campo(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}