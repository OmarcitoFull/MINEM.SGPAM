using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAH_EUM_MOD
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpah_Eum_ModAD
    {
        IEnumerable<T_Sgpah_Eum_Mod> ListarT_Sgpah_Eum_Mod();
        T_Sgpah_Eum_Mod RecuperarT_Sgpah_Eum_ModPorCodigo(int vId_Eum_Mod);
        T_Sgpah_Eum_Mod InsertarT_Sgpah_Eum_Mod(T_Sgpah_Eum_Mod vT_Sgpah_Eum_Mod);
        T_Sgpah_Eum_Mod ActualizarT_Sgpah_Eum_Mod(T_Sgpah_Eum_Mod vT_Sgpah_Eum_Mod);
        int AnularT_Sgpah_Eum_ModPorCodigo(int vId_Eum_Mod);
        IEnumerable<T_Sgpah_Eum_Mod> ListarPaginadoT_Sgpah_Eum_Mod(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<T_Sgpah_Eum_Mod> ListarPorIdEumT_Sgpah_Eum_Mod(int vId_Eum);
    }
}