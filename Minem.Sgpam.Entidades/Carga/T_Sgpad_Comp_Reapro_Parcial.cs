using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Reapro 
    { 
        public T_Sgpad_Comp_Reapro()
        {

        }

        public T_Sgpad_Comp_Reapro(IDataReader vRdr)
        {
            			if (!Convert.IsDBNull(vRdr["NOMBRE_PROYECTO"]))  			{				this.NOMBRE_PROYECTO = Convert.ToString(vRdr["NOMBRE_PROYECTO"]);  			}			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))  			{				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["FECHA_EXPEDIENTE"]))  			{				this.FECHA_EXPEDIENTE = Convert.ToDateTime(vRdr["FECHA_EXPEDIENTE"]);  			}			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  
			if (!Convert.IsDBNull(vRdr["FECHA_RESOLUCION"]))  			{				this.FECHA_RESOLUCION = Convert.ToDateTime(vRdr["FECHA_RESOLUCION"]);  			}			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))  			{				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["NRO_EXPEDIENTE"]))  			{				this.NRO_EXPEDIENTE = Convert.ToString(vRdr["NRO_EXPEDIENTE"]);  			}			this.ID_COMP_REAPRO = Convert.ToInt32(vRdr["ID_COMP_REAPRO"]);  
			this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);  
			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))  			{				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))  			{				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))  			{				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))  			{				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["RESOLUCION_REAPRO"]))  			{				this.RESOLUCION_REAPRO = Convert.ToString(vRdr["RESOLUCION_REAPRO"]);  			}
			if (!Convert.IsDBNull(vRdr["TITULAR"]))
			{				this.TITULAR = Convert.ToString(vRdr["TITULAR"]);
			}
		}
    }
}