using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Dd_Minero 
    { 
        public T_Sgpad_Comp_Dd_Minero()
        {

        }

        public T_Sgpad_Comp_Dd_Minero(IDataReader vRdr)
        {
            			this.CODIGO_DM = Convert.ToString(vRdr["CODIGO_DM"]);  
			this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);  


			this.ID_COMP_DM = Convert.ToInt32(vRdr["ID_COMP_DM"]);  


        }
    }
}