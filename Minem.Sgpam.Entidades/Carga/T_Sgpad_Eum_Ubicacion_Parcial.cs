using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Eum_Ubicacion 
    { 
        public T_Sgpad_Eum_Ubicacion()
        {

        }

        public T_Sgpad_Eum_Ubicacion(IDataReader vRdr)
        {
            			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))  			{				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["PARAJE"]))  			{				this.PARAJE = Convert.ToString(vRdr["PARAJE"]);  			}			this.ID_CUENCA_PRINCIPAL = Convert.ToInt32(vRdr["ID_CUENCA_PRINCIPAL"]);  
			if (!Convert.IsDBNull(vRdr["ID_CUENCA_SECUNDARIA"]))  			{				this.ID_CUENCA_SECUNDARIA = Convert.ToInt32(vRdr["ID_CUENCA_SECUNDARIA"]);  			}			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))  			{				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);  			}			this.ID_EUM_UBICACION = Convert.ToInt32(vRdr["ID_EUM_UBICACION"]);  
			if (!Convert.IsDBNull(vRdr["REFERENCIA"]))  			{				this.REFERENCIA = Convert.ToString(vRdr["REFERENCIA"]);  			}			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))  			{				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))  			{				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))  			{				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);  			}			this.ID_EUM = Convert.ToInt32(vRdr["ID_EUM"]);  
			this.UBIGEO = Convert.ToString(vRdr["UBIGEO"]);  
			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))  			{				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);  			}			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  

        }
    }
}