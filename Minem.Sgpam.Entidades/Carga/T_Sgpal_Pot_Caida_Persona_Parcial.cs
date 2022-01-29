using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpal_Pot_Caida_Persona 
    { 
        public T_Sgpal_Pot_Caida_Persona()
        {

        }

        public T_Sgpal_Pot_Caida_Persona(IDataReader vRdr)
        {
            			if (!Convert.IsDBNull(vRdr["PESO_ORM"]))  			{				this.PESO_ORM = Convert.ToInt32(vRdr["PESO_ORM"]);  			}			if (!Convert.IsDBNull(vRdr["PESO_I"]))  			{				this.PESO_I = Convert.ToInt32(vRdr["PESO_I"]);  			}			if (!Convert.IsDBNull(vRdr["PESO_PQ"]))  			{				this.PESO_PQ = Convert.ToInt32(vRdr["PESO_PQ"]);  			}			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))  			{				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))  			{				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);  			}			this.ID_POT_CAIDA_PERSONA = Convert.ToInt32(vRdr["ID_POT_CAIDA_PERSONA"]);  
			this.DESCRIPCION = Convert.ToString(vRdr["DESCRIPCION"]);  
			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))  			{				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))  			{				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);  			}			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  
			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))  			{				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))  			{				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["PESO_LB"]))  			{				this.PESO_LB = Convert.ToInt32(vRdr["PESO_LB"]);  			}			if (!Convert.IsDBNull(vRdr["PESO_RM"]))  			{				this.PESO_RM = Convert.ToInt32(vRdr["PESO_RM"]);  			}
        }
    }
}