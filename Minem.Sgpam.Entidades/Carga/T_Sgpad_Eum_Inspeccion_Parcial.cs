using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Eum_Inspeccion 
    { 
        public T_Sgpad_Eum_Inspeccion()
        {

        }

        public T_Sgpad_Eum_Inspeccion(IDataReader vRdr)
        {
            this.ID_INSPECTOR = Convert.ToInt32(vRdr["ID_INSPECTOR"]);  
			this.ID_EUM_INSPECCION = Convert.ToInt32(vRdr["ID_EUM_INSPECCION"]);  

			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))  
			{
				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);  
			}

			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))  
			{
				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);  
			}

			if (!Convert.IsDBNull(vRdr["ID_TIPO_CLIMA"]))  
			{
				this.ID_TIPO_CLIMA = Convert.ToInt32(vRdr["ID_TIPO_CLIMA"]);  
			}

			this.DESCRIPCION_CLIMA = Convert.ToString(vRdr["DESCRIPCION_CLIMA"]); 
			this.ID_EUM = Convert.ToInt32(vRdr["ID_EUM"]);  

			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))  
			{
				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);  
			}

			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))  
			{
				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);  
			}
			this.FECHA_INSPECCION = Convert.ToDateTime(vRdr["FECHA_INSPECCION"]);  

			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))  
			{
				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);  
			}
			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  

			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))  
			{
				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);  
			}
			this.NOMBRE_INSPECTOR = Convert.ToString(vRdr["NOMBRE_INSPECTOR"]);
		}
    }
}