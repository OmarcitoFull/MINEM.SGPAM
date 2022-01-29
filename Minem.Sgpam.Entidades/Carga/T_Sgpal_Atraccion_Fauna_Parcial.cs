using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpal_Atraccion_Fauna 
    { 
        public T_Sgpal_Atraccion_Fauna()
        {

        }

        public T_Sgpal_Atraccion_Fauna(IDataReader vRdr)
        {
            
			this.ID_ATRACCION_FAUNA = Convert.ToInt32(vRdr["ID_ATRACCION_FAUNA"]);  


        }
    }
}