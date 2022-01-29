using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Lnr_Info_Grafica 
    { 
        public T_Sgpad_Lnr_Info_Grafica()
        {

        }

        public T_Sgpad_Lnr_Info_Grafica(IDataReader vRdr)
        {
            			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))  			{				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);  			}			this.RUTA_IMAGEN = Convert.ToString(vRdr["RUTA_IMAGEN"]);  
			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  
			this.ID_LNR = Convert.ToInt32(vRdr["ID_LNR"]);  
			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))  			{				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);  			}			this.NOMBRE_IMAGEN = Convert.ToString(vRdr["NOMBRE_IMAGEN"]);  
			this.ID_LNR_INFO_GRAFICA = Convert.ToInt32(vRdr["ID_LNR_INFO_GRAFICA"]);  
			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))  			{				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))  			{				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))  			{				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))  			{				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["TAMANO"]))  			{				this.TAMANO = Convert.ToInt32(vRdr["TAMANO"]);  			}			if (!Convert.IsDBNull(vRdr["EXTENCION"]))  			{				this.EXTENCION = Convert.ToString(vRdr["EXTENCION"]);  			}
        }
    }
}