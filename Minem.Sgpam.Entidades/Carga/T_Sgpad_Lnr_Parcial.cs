using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Lnr 
    { 
        public T_Sgpad_Lnr()
        {

        }

        public T_Sgpad_Lnr(IDataReader vRdr)
        {
            			this.ID_ZONA = Convert.ToInt32(vRdr["ID_ZONA"]);  





			this.ID_TIPO_LNR = Convert.ToInt32(vRdr["ID_TIPO_LNR"]);  



			this.FEC_REGISTRO = Convert.ToDateTime(vRdr["FEC_REGISTRO"]);  


        }
    }
}