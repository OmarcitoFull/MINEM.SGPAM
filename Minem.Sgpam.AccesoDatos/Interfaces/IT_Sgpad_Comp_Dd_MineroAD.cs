using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_COMP_DD_MINERO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Comp_Dd_MineroAD
    {
        IEnumerable<T_Sgpad_Comp_Dd_Minero> ListarT_Sgpad_Comp_Dd_Minero();
        T_Sgpad_Comp_Dd_Minero RecuperarT_Sgpad_Comp_Dd_MineroPorCodigo(int vId_Comp_Dm);
        T_Sgpad_Comp_Dd_Minero InsertarT_Sgpad_Comp_Dd_Minero(T_Sgpad_Comp_Dd_Minero vT_Sgpad_Comp_Dd_Minero);
        T_Sgpad_Comp_Dd_Minero ActualizarT_Sgpad_Comp_Dd_Minero(T_Sgpad_Comp_Dd_Minero vT_Sgpad_Comp_Dd_Minero);
        int AnularT_Sgpad_Comp_Dd_MineroPorCodigo(int vId_Comp_Dm);
        IEnumerable<T_Sgpad_Comp_Dd_Minero> ListarPaginadoT_Sgpad_Comp_Dd_Minero(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}