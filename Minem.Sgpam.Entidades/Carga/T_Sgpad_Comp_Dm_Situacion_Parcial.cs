using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Dm_Situacion 
    { 
        public T_Sgpad_Comp_Dm_Situacion()
        {

        }

        public T_Sgpad_Comp_Dm_Situacion(IDataReader vRdr)
        {
            			this.ID_COMP_DM = Convert.ToInt32(vRdr["ID_COMP_DM"]);  
			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))  			{				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);  			}			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  
			this.ANIO = Convert.ToInt32(vRdr["ANIO"]);  
			if (!Convert.IsDBNull(vRdr["ID_TIPO_CONCENTRADO"]))  			{				this.ID_TIPO_CONCENTRADO = Convert.ToInt32(vRdr["ID_TIPO_CONCENTRADO"]);  			}			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))  			{				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);  			}			this.ID_COMP_DM_SITUACION = Convert.ToInt32(vRdr["ID_COMP_DM_SITUACION"]);  
			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))  			{				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))  			{				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["CANTIDAD"]))  			{				this.CANTIDAD = Convert.ToInt32(vRdr["CANTIDAD"]);  			}			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))  			{				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))  			{				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["ID_SITUACION"]))  			{				this.ID_SITUACION = Convert.ToInt32(vRdr["ID_SITUACION"]);  			}
        }
    }
}