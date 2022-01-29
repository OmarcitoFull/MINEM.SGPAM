using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Observacion 
    { 
        public T_Sgpad_Comp_Observacion()
        {

        }

        public T_Sgpad_Comp_Observacion(IDataReader vRdr)
        {
            			this.FECHA = Convert.ToDateTime(vRdr["FECHA"]);  
			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))  			{				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))  			{				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))  			{				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["SUELOS_DISTURBADOS"]))  			{				this.SUELOS_DISTURBADOS = Convert.ToString(vRdr["SUELOS_DISTURBADOS"]);  			}			this.ID_COMP_OBSERVACION = Convert.ToInt32(vRdr["ID_COMP_OBSERVACION"]);  
			this.DESCRIPCION_COMP = Convert.ToString(vRdr["DESCRIPCION_COMP"]);  
			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))  			{				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))  			{				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["OBRAS_REHABILITACION"]))  			{				this.OBRAS_REHABILITACION = Convert.ToString(vRdr["OBRAS_REHABILITACION"]);  			}			this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);  
			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))  			{				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);  			}			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  

        }
    }
}