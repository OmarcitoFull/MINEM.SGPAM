using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Eum_Operacion 
    { 
        public T_Sgpad_Eum_Operacion()
        {

        }

        public T_Sgpad_Eum_Operacion(IDataReader vRdr)
        {
			this.ID_EUM_OPERACION = Convert.ToInt32(vRdr["ID_EUM_OPERACION"]);  

			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))  
			{
				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);  
			}

			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))  
			{
				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);  
			}

			if (!Convert.IsDBNull(vRdr["ID_TIPO_OPERACION"]))  
			{
				this.ID_TIPO_OPERACION = Convert.ToInt32(vRdr["ID_TIPO_OPERACION"]);  
			}
			this.ID_EUM = Convert.ToInt32(vRdr["ID_EUM"]);  

			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))  
			{
				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);  
			}

			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))  
			{
				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);  
			}

			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))  
			{
				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);  
			}
			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  

			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))  
			{
				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);  
			}

			if (!Convert.IsDBNull(vRdr["TIPO_OPERACION"]))
			{
				this.TIPO_OPERACION = Convert.ToString(vRdr["TIPO_OPERACION"]);
			}

		}
	}
}