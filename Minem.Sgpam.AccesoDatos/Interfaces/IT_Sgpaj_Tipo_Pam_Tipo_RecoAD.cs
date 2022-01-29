using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAJ_TIPO_PAM_TIPO_RECO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpaj_Tipo_Pam_Tipo_RecoAD
    {
        IEnumerable<T_Sgpaj_Tipo_Pam_Tipo_Reco> ListarT_Sgpaj_Tipo_Pam_Tipo_Reco();
        T_Sgpaj_Tipo_Pam_Tipo_Reco RecuperarT_Sgpaj_Tipo_Pam_Tipo_RecoPorCodigo(int vId_Tipo_Pam_Tipo_Reco);
        T_Sgpaj_Tipo_Pam_Tipo_Reco InsertarT_Sgpaj_Tipo_Pam_Tipo_Reco(T_Sgpaj_Tipo_Pam_Tipo_Reco vT_Sgpaj_Tipo_Pam_Tipo_Reco);
        T_Sgpaj_Tipo_Pam_Tipo_Reco ActualizarT_Sgpaj_Tipo_Pam_Tipo_Reco(T_Sgpaj_Tipo_Pam_Tipo_Reco vT_Sgpaj_Tipo_Pam_Tipo_Reco);
        int AnularT_Sgpaj_Tipo_Pam_Tipo_RecoPorCodigo(int vId_Tipo_Pam_Tipo_Reco);
        IEnumerable<T_Sgpaj_Tipo_Pam_Tipo_Reco> ListarPaginadoT_Sgpaj_Tipo_Pam_Tipo_Reco(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}