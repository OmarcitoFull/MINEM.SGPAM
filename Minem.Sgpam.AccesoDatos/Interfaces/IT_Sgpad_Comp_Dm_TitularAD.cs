using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_COMP_DM_TITULAR
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Comp_Dm_TitularAD
    {
        IEnumerable<T_Sgpad_Comp_Dm_Titular> ListarT_Sgpad_Comp_Dm_Titular();
        T_Sgpad_Comp_Dm_Titular RecuperarT_Sgpad_Comp_Dm_TitularPorCodigo(int vId_Comp_Dm_Titular);
        T_Sgpad_Comp_Dm_Titular InsertarT_Sgpad_Comp_Dm_Titular(T_Sgpad_Comp_Dm_Titular vT_Sgpad_Comp_Dm_Titular);
        T_Sgpad_Comp_Dm_Titular ActualizarT_Sgpad_Comp_Dm_Titular(T_Sgpad_Comp_Dm_Titular vT_Sgpad_Comp_Dm_Titular);
        int AnularT_Sgpad_Comp_Dm_TitularPorCodigo(int vId_Comp_Dm_Titular);
        IEnumerable<T_Sgpad_Comp_Dm_Titular> ListarPaginadoT_Sgpad_Comp_Dm_Titular(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<T_Sgpad_Comp_Dm_Titular> ListarPorIdEumT_Sgpad_Comp_Dm_Titular(int vId_Eum);
    }
}