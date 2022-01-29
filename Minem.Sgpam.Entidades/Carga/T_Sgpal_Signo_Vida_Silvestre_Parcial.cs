using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpal_Signo_Vida_Silvestre 
    { 
        public T_Sgpal_Signo_Vida_Silvestre()
        {

        }

        public T_Sgpal_Signo_Vida_Silvestre(IDataReader vRdr)
        {
            			this.ID_SIGNO_VIDA_SILVESTRE = Convert.ToInt32(vRdr["ID_SIGNO_VIDA_SILVESTRE"]);  

			this.DESCRIPCION = Convert.ToString(vRdr["DESCRIPCION"]);  

        }
    }
}