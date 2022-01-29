using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Eum_Info_Descargo 
    { 
        public T_Sgpad_Eum_Info_Descargo()
        {

        }

        public T_Sgpad_Eum_Info_Descargo(IDataReader vRdr)
        {
            			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))  			{				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);  			}			this.ID_EUM = Convert.ToInt32(vRdr["ID_EUM"]);  
			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))  			{				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);  			}			this.TITULAR = Convert.ToString(vRdr["TITULAR"]);  
			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))  			{				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))  			{				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);  			}			this.DECLARACION = Convert.ToString(vRdr["DECLARACION"]);  
			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))  			{				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["EXTENCION"]))  			{				this.EXTENCION = Convert.ToString(vRdr["EXTENCION"]);  			}			this.ID_EUM_INFO_DESCARGO = Convert.ToInt32(vRdr["ID_EUM_INFO_DESCARGO"]);  
			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))  			{				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["TAMANO"]))  			{				this.TAMANO = Convert.ToInt32(vRdr["TAMANO"]);  			}			this.FECHA_DESCARGO = Convert.ToDateTime(vRdr["FECHA_DESCARGO"]);  
			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  
			if (!Convert.IsDBNull(vRdr["RUTA_DOCUMENTO"]))  			{				this.RUTA_DOCUMENTO = Convert.ToString(vRdr["RUTA_DOCUMENTO"]);  			}			if (!Convert.IsDBNull(vRdr["ASUNTO"]))  			{				this.ASUNTO = Convert.ToString(vRdr["ASUNTO"]);  			}			if (!Convert.IsDBNull(vRdr["NOMBRE_DOCUMENTO"]))  			{				this.NOMBRE_DOCUMENTO = Convert.ToString(vRdr["NOMBRE_DOCUMENTO"]);  			}
        }
    }
}