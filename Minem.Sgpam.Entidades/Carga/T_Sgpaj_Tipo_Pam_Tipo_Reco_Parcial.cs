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
			if (!Convert.IsDBNull(vRdr["ID_TIPO_MINERIA"]))  			{				this.ID_TIPO_MINERIA = Convert.ToInt32(vRdr["ID_TIPO_MINERIA"]);  			}			this.ID_TIPO_RECONOCIMIENTO = Convert.ToInt32(vRdr["ID_TIPO_RECONOCIMIENTO"]);  
			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  
			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))  			{				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))  			{				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))  			{				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))  			{				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))  			{				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);  			}			this.ID_TIPO_PAM = Convert.ToInt32(vRdr["ID_TIPO_PAM"]);  
			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))  			{				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);  			}
        }
    }
}