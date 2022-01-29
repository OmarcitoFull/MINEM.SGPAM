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




        }
    }
}