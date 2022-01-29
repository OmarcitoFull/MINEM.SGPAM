using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpal_Tipo_Concesion 
    { 
        public T_Sgpal_Tipo_Concesion()
        {

        }

        public T_Sgpal_Tipo_Concesion(IDataReader vRdr)
        {
            			this.ID_TIPO_CONCESION = Convert.ToInt32(vRdr["ID_TIPO_CONCESION"]);  

			this.DESCRIPCION = Convert.ToString(vRdr["DESCRIPCION"]);  

        }
    }
}