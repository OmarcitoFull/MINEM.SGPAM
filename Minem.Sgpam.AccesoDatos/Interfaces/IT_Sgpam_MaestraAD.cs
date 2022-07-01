using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAM_MAESTRA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpam_MaestraAD
    {
        IEnumerable<T_Sgpam_Maestra> ListarT_Sgpam_Maestra();
        T_Sgpam_Maestra RecuperarT_Sgpam_MaestraPorCodigo(int vId_Eum);
        T_Sgpam_Maestra InsertarT_Sgpam_Maestra(T_Sgpam_Maestra vT_Sgpam_Maestra);
        T_Sgpam_Maestra ActualizarT_Sgpam_Maestra(T_Sgpam_Maestra vT_Sgpam_Maestra);
        int AnularT_Sgpam_MaestraPorCodigo(T_Sgpam_Maestra vT_Sgpam_Maestra);
        IEnumerable<T_Sgpam_Maestra> ListarPaginadoT_Sgpam_Maestra(string vFiltro, string vUbigeo, int vNumPag, int vCantRegxPag);
    }
}