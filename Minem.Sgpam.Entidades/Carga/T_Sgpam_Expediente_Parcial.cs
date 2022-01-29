using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpam_Expediente 
    { 
        public T_Sgpam_Expediente()
        {

        }

        public T_Sgpam_Expediente(IDataReader vRdr)
        {
            

			this.NRO_EXPEDIENTE = Convert.ToString(vRdr["NRO_EXPEDIENTE"]);  

        }
    }
}