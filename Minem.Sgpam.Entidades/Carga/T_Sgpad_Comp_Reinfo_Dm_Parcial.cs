using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Reinfo_Dm 
    { 
        public T_Sgpad_Comp_Reinfo_Dm()
        {

        }

        public T_Sgpad_Comp_Reinfo_Dm(IDataReader vRdr)
        {
            			this.ID_COMP_REINFO_DM = Convert.ToInt32(vRdr["ID_COMP_REINFO_DM"]);  



        }
    }
}