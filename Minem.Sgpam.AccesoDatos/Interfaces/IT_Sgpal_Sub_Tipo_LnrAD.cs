using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_SUB_TIPO_LNR
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Sub_Tipo_LnrAD
    {
        IEnumerable<T_Sgpal_Sub_Tipo_Lnr> ListarT_Sgpal_Sub_Tipo_Lnr();
        T_Sgpal_Sub_Tipo_Lnr RecuperarT_Sgpal_Sub_Tipo_LnrPorCodigo(int vId_Sub_Tipo_Lnr);
        T_Sgpal_Sub_Tipo_Lnr InsertarT_Sgpal_Sub_Tipo_Lnr(T_Sgpal_Sub_Tipo_Lnr vT_Sgpal_Sub_Tipo_Lnr);
        T_Sgpal_Sub_Tipo_Lnr ActualizarT_Sgpal_Sub_Tipo_Lnr(T_Sgpal_Sub_Tipo_Lnr vT_Sgpal_Sub_Tipo_Lnr);
        int AnularT_Sgpal_Sub_Tipo_LnrPorCodigo(int vId_Sub_Tipo_Lnr);
        IEnumerable<T_Sgpal_Sub_Tipo_Lnr> ListarPaginadoT_Sgpal_Sub_Tipo_Lnr(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}