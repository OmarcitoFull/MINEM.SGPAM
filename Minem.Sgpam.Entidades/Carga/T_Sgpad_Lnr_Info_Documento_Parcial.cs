using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Lnr_Info_Documento 
    { 
        public T_Sgpad_Lnr_Info_Documento()
        {

        }

        public T_Sgpad_Lnr_Info_Documento(IDataReader vRdr)
        {
            

			this.ID_LNR_INFO_DOCUMENTO = Convert.ToInt32(vRdr["ID_LNR_INFO_DOCUMENTO"]);  

			this.NOMBRE_DOCUMENTO = Convert.ToString(vRdr["NOMBRE_DOCUMENTO"]);  

        }
    }
}