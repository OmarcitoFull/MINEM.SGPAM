using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpal_Evidencia_Inundacion 
    { 
        public T_Sgpal_Evidencia_Inundacion()
        {

        }

        public T_Sgpal_Evidencia_Inundacion(IDataReader vRdr)
        {
            			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))  			{				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["PESO_LB"]))  			{				this.PESO_LB = Convert.ToInt32(vRdr["PESO_LB"]);  			}			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  
			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))  			{				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);  			}			this.DESCRIPCION = Convert.ToString(vRdr["DESCRIPCION"]);  
			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))  			{				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["PESO_RM"]))  			{				this.PESO_RM = Convert.ToInt32(vRdr["PESO_RM"]);  			}			if (!Convert.IsDBNull(vRdr["PESO_I"]))  			{				this.PESO_I = Convert.ToInt32(vRdr["PESO_I"]);  			}			if (!Convert.IsDBNull(vRdr["PESO_PQ"]))  			{				this.PESO_PQ = Convert.ToInt32(vRdr["PESO_PQ"]);  			}			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))  			{				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);  			}			this.ID_EVIDENCIA_INUNDACION = Convert.ToInt32(vRdr["ID_EVIDENCIA_INUNDACION"]);  
			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))  			{				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))  			{				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["PESO_ORM"]))  			{				this.PESO_ORM = Convert.ToInt32(vRdr["PESO_ORM"]);  			}
        }
    }
}