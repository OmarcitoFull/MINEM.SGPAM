using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Riesgo_Sal_Amb 
    { 
        public T_Sgpad_Comp_Riesgo_Sal_Amb()
        {

        }

        public T_Sgpad_Comp_Riesgo_Sal_Amb(IDataReader vRdr)
        {
            
			this.ID_EVIDENCIA_INUNDACION = Convert.ToInt32(vRdr["ID_EVIDENCIA_INUNDACION"]);  

			this.ID_POTENCIAL_ARD = Convert.ToInt32(vRdr["ID_POTENCIAL_ARD"]);  
			this.ID_EVIDENCIA_EROSION = Convert.ToInt32(vRdr["ID_EVIDENCIA_EROSION"]);  



        }
    }
}