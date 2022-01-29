using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Info_Grafica 
    { 
        public T_Sgpad_Comp_Info_Grafica()
        {

        }

        public T_Sgpad_Comp_Info_Grafica(IDataReader vRdr)
        {
            
			this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);  
			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  



        }
    }
}