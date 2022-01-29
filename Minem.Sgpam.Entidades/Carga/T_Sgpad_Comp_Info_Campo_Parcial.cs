using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Info_Campo 
    { 
        public T_Sgpad_Comp_Info_Campo()
        {

        }

        public T_Sgpad_Comp_Info_Campo(IDataReader vRdr)
        {
            			this.FECHA_INFORME = Convert.ToDateTime(vRdr["FECHA_INFORME"]);  

			this.ID_COMP_INFO_CAMPO = Convert.ToInt32(vRdr["ID_COMP_INFO_CAMPO"]);  
			this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);  


        }
    }
}