using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_CONFLICTO_SOCIAL
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Conflicto_SocialAD
    {
        IEnumerable<T_Sgpal_Conflicto_Social> ListarT_Sgpal_Conflicto_Social();
        T_Sgpal_Conflicto_Social RecuperarT_Sgpal_Conflicto_SocialPorCodigo(int vId_Conflicto_Social);
        T_Sgpal_Conflicto_Social InsertarT_Sgpal_Conflicto_Social(T_Sgpal_Conflicto_Social vT_Sgpal_Conflicto_Social);
        T_Sgpal_Conflicto_Social ActualizarT_Sgpal_Conflicto_Social(T_Sgpal_Conflicto_Social vT_Sgpal_Conflicto_Social);
        int AnularT_Sgpal_Conflicto_SocialPorCodigo(int vId_Conflicto_Social);
        IEnumerable<T_Sgpal_Conflicto_Social> ListarPaginadoT_Sgpal_Conflicto_Social(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}