using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Riesgo_Fau_Con 
    { 
        public T_Sgpad_Comp_Riesgo_Fau_Con()
        {

        }

        public T_Sgpad_Comp_Riesgo_Fau_Con(IDataReader vRdr)
        {
            
			this.ID_COMP_RIESGO_FAU_CON = Convert.ToInt32(vRdr["ID_COMP_RIESGO_FAU_CON"]);  
			this.ID_ACCESO_FAUNA = Convert.ToInt32(vRdr["ID_ACCESO_FAUNA"]);  

			this.ID_ATRACCION_FAUNA = Convert.ToInt32(vRdr["ID_ATRACCION_FAUNA"]);  

			this.ID_CERCA_AREA_PROTEGIDA = Convert.ToInt32(vRdr["ID_CERCA_AREA_PROTEGIDA"]);  
			this.ID_AGUA_CONTAMINADA = Convert.ToInt32(vRdr["ID_AGUA_CONTAMINADA"]);  


        }
    }
}