using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpah_Componente_Mod 
    { 
        public T_Sgpah_Componente_Mod()
        {

        }

        public T_Sgpah_Componente_Mod(IDataReader vRdr)
        {
            
			this.ID_COMPONENTE_MOD = Convert.ToInt32(vRdr["ID_COMPONENTE_MOD"]);  
			this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);  

        }
    }
}