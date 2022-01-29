using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_POT_COLAPSO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Pot_ColapsoAD
    {
        IEnumerable<T_Sgpal_Pot_Colapso> ListarT_Sgpal_Pot_Colapso();
        T_Sgpal_Pot_Colapso RecuperarT_Sgpal_Pot_ColapsoPorCodigo(int vId_Pot_Colapso);
        T_Sgpal_Pot_Colapso InsertarT_Sgpal_Pot_Colapso(T_Sgpal_Pot_Colapso vT_Sgpal_Pot_Colapso);
        T_Sgpal_Pot_Colapso ActualizarT_Sgpal_Pot_Colapso(T_Sgpal_Pot_Colapso vT_Sgpal_Pot_Colapso);
        int AnularT_Sgpal_Pot_ColapsoPorCodigo(int vId_Pot_Colapso);
        IEnumerable<T_Sgpal_Pot_Colapso> ListarPaginadoT_Sgpal_Pot_Colapso(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}