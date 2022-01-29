using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpaj_Tipo_Pam_Tipo_Reco 
    { 
        public T_Sgpaj_Tipo_Pam_Tipo_Reco()
        {

        }

        public T_Sgpaj_Tipo_Pam_Tipo_Reco(IDataReader vRdr)
        {
            			this.ID_TIPO_PAM_TIPO_RECO = Convert.ToInt32(vRdr["ID_TIPO_PAM_TIPO_RECO"]);  

			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  


        }
    }
}