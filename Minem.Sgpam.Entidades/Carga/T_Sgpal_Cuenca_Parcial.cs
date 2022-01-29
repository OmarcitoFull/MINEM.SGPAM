using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpal_Cuenca 
    { 
        public T_Sgpal_Cuenca()
        {

        }

        public T_Sgpal_Cuenca(IDataReader vRdr)
        {
            			this.ID_CUENCA = Convert.ToInt32(vRdr["ID_CUENCA"]);  

			this.DESCRIPCION = Convert.ToString(vRdr["DESCRIPCION"]);  

        }
    }
}