using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpal_Pot_Colapso 
    { 
        public T_Sgpal_Pot_Colapso()
        {

        }

        public T_Sgpal_Pot_Colapso(IDataReader vRdr)
        {
            			this.DESCRIPCION = Convert.ToString(vRdr["DESCRIPCION"]);  
			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  


        }
    }
}