using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Riesgo_Seg_Hum 
    { 
        public T_Sgpad_Comp_Riesgo_Seg_Hum()
        {

        }

        public T_Sgpad_Comp_Riesgo_Seg_Hum(IDataReader vRdr)
        {
            			this.ID_COMP_RIESGO_SEG_HUM = Convert.ToInt32(vRdr["ID_COMP_RIESGO_SEG_HUM"]);  
			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))  			{				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);  			}			this.ID_PRESENCIA_ADVERTENCIA = Convert.ToInt32(vRdr["ID_PRESENCIA_ADVERTENCIA"]);  
			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  
			this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);  
			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))  			{				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))  			{				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))  			{				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);  			}			this.ID_HUNDIMIENTO = Convert.ToInt32(vRdr["ID_HUNDIMIENTO"]);  
			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))  			{				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);  			}			this.ID_POT_COLAPSO = Convert.ToInt32(vRdr["ID_POT_COLAPSO"]);  
			this.ID_POT_CAIDA_PERSONA = Convert.ToInt32(vRdr["ID_POT_CAIDA_PERSONA"]);  
			this.ID_CONDICION_CIERRE = Convert.ToInt32(vRdr["ID_CONDICION_CIERRE"]);  
			this.ID_PRESENCIA_ELEMENTO = Convert.ToInt32(vRdr["ID_PRESENCIA_ELEMENTO"]);  
			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))  			{				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);  			}			this.ID_ACCESIBILIDAD = Convert.ToInt32(vRdr["ID_ACCESIBILIDAD"]);  

        }
    }
}