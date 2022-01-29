using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAJ_VISITA_DET_COM_LNR
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpaj_Visita_Det_Com_LnrAD
    {
        IEnumerable<T_Sgpaj_Visita_Det_Com_Lnr> ListarT_Sgpaj_Visita_Det_Com_Lnr();
        T_Sgpaj_Visita_Det_Com_Lnr RecuperarT_Sgpaj_Visita_Det_Com_LnrPorCodigo(int vId_Visita_Det_Com_Lnr);
        T_Sgpaj_Visita_Det_Com_Lnr InsertarT_Sgpaj_Visita_Det_Com_Lnr(T_Sgpaj_Visita_Det_Com_Lnr vT_Sgpaj_Visita_Det_Com_Lnr);
        T_Sgpaj_Visita_Det_Com_Lnr ActualizarT_Sgpaj_Visita_Det_Com_Lnr(T_Sgpaj_Visita_Det_Com_Lnr vT_Sgpaj_Visita_Det_Com_Lnr);
        int AnularT_Sgpaj_Visita_Det_Com_LnrPorCodigo(int vId_Visita_Det_Com_Lnr);
        IEnumerable<T_Sgpaj_Visita_Det_Com_Lnr> ListarPaginadoT_Sgpaj_Visita_Det_Com_Lnr(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}