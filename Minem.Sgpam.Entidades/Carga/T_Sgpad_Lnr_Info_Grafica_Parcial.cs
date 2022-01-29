using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Lnr_Info_Grafica 
    { 
        public T_Sgpad_Lnr_Info_Grafica()
        {

        }

        public T_Sgpad_Lnr_Info_Grafica(IDataReader vRdr)
        {
            
			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  
			this.ID_LNR = Convert.ToInt32(vRdr["ID_LNR"]);  

			this.ID_LNR_INFO_GRAFICA = Convert.ToInt32(vRdr["ID_LNR_INFO_GRAFICA"]);  

        }
    }
}