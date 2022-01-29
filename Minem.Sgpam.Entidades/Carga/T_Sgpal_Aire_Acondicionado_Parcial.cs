using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpal_Aire_Acondicionado 
    { 
        public T_Sgpal_Aire_Acondicionado()
        {

        }

        public T_Sgpal_Aire_Acondicionado(IDataReader vRdr)
        {
            
			this.ID_AIRE_ACONDICIONADO = Convert.ToInt32(vRdr["ID_AIRE_ACONDICIONADO"]);  
			this.DESCRIPCION = Convert.ToString(vRdr["DESCRIPCION"]);  

        }
    }
}