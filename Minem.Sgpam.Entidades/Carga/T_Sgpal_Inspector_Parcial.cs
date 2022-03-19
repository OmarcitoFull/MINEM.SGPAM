using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpal_Inspector 
    { 
        public T_Sgpal_Inspector()
        {

        }

        public T_Sgpal_Inspector(IDataReader vRdr)
        {
            
			this.APE_PATERNO = Convert.ToString(vRdr["APELLIDO_PATERNO"]);
			this.NOMBRE = Convert.ToString(vRdr["NOMBRE_AUDITOR"]);
			this.ID_INSPECTOR = Convert.ToInt32(vRdr["ID_AUDITOR"]);  


        }
    }
}