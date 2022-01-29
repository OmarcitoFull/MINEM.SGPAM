using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Dd_Minero 
    { 
        public T_Sgpad_Comp_Dd_Minero()
        {

        }

        public T_Sgpad_Comp_Dd_Minero(IDataReader vRdr)
        {
            			this.CODIGO_DM = Convert.ToString(vRdr["CODIGO_DM"]);  
			this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);  
			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))  			{				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["ID_ESTADO"]))  			{				this.ID_ESTADO = Convert.ToInt32(vRdr["ID_ESTADO"]);  			}			if (!Convert.IsDBNull(vRdr["ID_SUSTANCIA"]))  			{				this.ID_SUSTANCIA = Convert.ToInt32(vRdr["ID_SUSTANCIA"]);  			}			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))  			{				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);  			}			this.DESCRIPCION_DM = Convert.ToString(vRdr["DESCRIPCION_DM"]);  
			if (!Convert.IsDBNull(vRdr["ID_SITUACION"]))  			{				this.ID_SITUACION = Convert.ToInt32(vRdr["ID_SITUACION"]);  			}			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  
			this.ID_COMP_DM = Convert.ToInt32(vRdr["ID_COMP_DM"]);  
			if (!Convert.IsDBNull(vRdr["ID_TIPO_DM"]))  			{				this.ID_TIPO_DM = Convert.ToInt32(vRdr["ID_TIPO_DM"]);  			}			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))  			{				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);  			}			this.UEA = Convert.ToString(vRdr["UEA"]);  
			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))  			{				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))  			{				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))  			{				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);  			}
        }
    }
}