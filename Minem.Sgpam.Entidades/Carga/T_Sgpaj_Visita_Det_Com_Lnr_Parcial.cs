using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpaj_Visita_Det_Com_Lnr 
    { 
        public T_Sgpaj_Visita_Det_Com_Lnr()
        {

        }

        public T_Sgpaj_Visita_Det_Com_Lnr(IDataReader vRdr)
        {
            			if (!Convert.IsDBNull(vRdr["ID_COMPONENTE"]))  			{				this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);  			}			if (!Convert.IsDBNull(vRdr["ID_LNR"]))  			{				this.ID_LNR = Convert.ToInt32(vRdr["ID_LNR"]);  			}			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  
			this.ID_VISITA_DET_COM_LNR = Convert.ToInt32(vRdr["ID_VISITA_DET_COM_LNR"]);  
			if (!Convert.IsDBNull(vRdr["PUNTAJE"]))  			{				this.PUNTAJE = Convert.ToInt32(vRdr["PUNTAJE"]);  			}			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))  			{				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))  			{				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);  			}			this.ID_VISITA_DET = Convert.ToInt32(vRdr["ID_VISITA_DET"]);  
			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))  			{				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))  			{				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))  			{				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))  			{				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);  			}
        }
    }
}