using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Observacion 
    { 
        public T_Sgpad_Comp_Observacion()
        {

        }

        public T_Sgpad_Comp_Observacion(IDataReader vRdr)
        {
            			this.FECHA = Convert.ToDateTime(vRdr["FECHA"]);  

			this.DESCRIPCION_COMP = Convert.ToString(vRdr["DESCRIPCION_COMP"]);  



        }
    }
}