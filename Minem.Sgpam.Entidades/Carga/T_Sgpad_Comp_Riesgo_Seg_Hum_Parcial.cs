using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Riesgo_Seg_Hum 
    { 
        public T_Sgpad_Comp_Riesgo_Seg_Hum()
        {

        }

        public T_Sgpad_Comp_Riesgo_Seg_Hum(IDataReader vRdr)
        {
            			this.ID_COMP_RIESGO_SEG_HUM = Convert.ToInt32(vRdr["ID_COMP_RIESGO_SEG_HUM"]);  

			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  
			this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);  


			this.ID_POT_CAIDA_PERSONA = Convert.ToInt32(vRdr["ID_POT_CAIDA_PERSONA"]);  
			this.ID_CONDICION_CIERRE = Convert.ToInt32(vRdr["ID_CONDICION_CIERRE"]);  
			this.ID_PRESENCIA_ELEMENTO = Convert.ToInt32(vRdr["ID_PRESENCIA_ELEMENTO"]);  


        }
    }
}