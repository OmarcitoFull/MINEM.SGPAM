using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpal_Tipo_Resolucion 
    { 
        public T_Sgpal_Tipo_Resolucion()
        {

        }

        public T_Sgpal_Tipo_Resolucion(IDataReader vRdr)
        {
            
			this.DESCRIPCION = Convert.ToString(vRdr["DESCRIPCION"]);  


        }
    }
}