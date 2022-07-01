using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Dm_Titular 
    { 
        public T_Sgpad_Comp_Dm_Titular()
        {

        }

        public T_Sgpad_Comp_Dm_Titular(IDataReader vRdr)
        {

			if (!Convert.IsDBNull(vRdr["ESTADO"]))  
			{
				this.ESTADO = Convert.ToString(vRdr["ESTADO"]);  
			}

			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))  			{				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);  			}			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  
			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))  			{				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);  			}			this.ID_COMP_DM_TITULAR = Convert.ToInt32(vRdr["ID_COMP_DM_TITULAR"]);  
			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))  			{				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);  			}			this.ID_COMP_DM = Convert.ToInt32(vRdr["ID_COMP_DM"]);  
			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))  			{				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);  			}			this.ID_EMPRESA = Convert.ToInt32(vRdr["ID_EMPRESA"]);  
			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))  			{				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["FECHA_INICIO"]))
			{
				this.FECHA_INICIO = Convert.ToDateTime(vRdr["FECHA_INICIO"]);
			}			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))  			{				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["FECHA_FIN"]))  			{				this.FECHA_FIN = Convert.ToDateTime(vRdr["FECHA_FIN"]);  			}
			if (!Convert.IsDBNull(vRdr["NOMBRE_EMPRESA"]))
			{				this.NOMBRE = Convert.ToString(vRdr["NOMBRE_EMPRESA"]);
			}

			if (!Convert.IsDBNull(vRdr["NOMBRE_DM"]))
			{				this.NOMBRE_DM = Convert.ToString(vRdr["NOMBRE_DM"]);
			}
		}
	}
}