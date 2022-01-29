using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpah_Eum_Mod 
    { 
        public T_Sgpah_Eum_Mod()
        {

        }

        public T_Sgpah_Eum_Mod(IDataReader vRdr)
        {
            this.ID_EUM = Convert.ToInt32(vRdr["ID_EUM"]);  

			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))  
			{
				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);  
			}

			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))  
			{
				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);  
			}

			if (!Convert.IsDBNull(vRdr["CARGO"]))  
			{
				this.CARGO = Convert.ToString(vRdr["CARGO"]);  
			}
			this.ID_EUM_MOD = Convert.ToInt32(vRdr["ID_EUM_MOD"]);  
			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  

			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))  
			{
				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);  
			}


		}
    }
}