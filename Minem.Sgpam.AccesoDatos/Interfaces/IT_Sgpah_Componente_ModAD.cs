using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAH_COMPONENTE_MOD
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpah_Componente_ModAD
    {
        IEnumerable<T_Sgpah_Componente_Mod> ListarT_Sgpah_Componente_Mod(int vIdComponente);
        T_Sgpah_Componente_Mod RecuperarT_Sgpah_Componente_ModPorCodigo(int vId_Componente_Mod);
        T_Sgpah_Componente_Mod InsertarT_Sgpah_Componente_Mod(T_Sgpah_Componente_Mod vT_Sgpah_Componente_Mod);
        T_Sgpah_Componente_Mod ActualizarT_Sgpah_Componente_Mod(T_Sgpah_Componente_Mod vT_Sgpah_Componente_Mod);
        int AnularT_Sgpah_Componente_ModPorCodigo(int vId_Componente_Mod);
        IEnumerable<T_Sgpah_Componente_Mod> ListarPaginadoT_Sgpah_Componente_Mod(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}