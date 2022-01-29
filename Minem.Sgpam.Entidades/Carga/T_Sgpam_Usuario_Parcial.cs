using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpam_Usuario 
    { 
        public T_Sgpam_Usuario()
        {

        }

        public T_Sgpam_Usuario(IDataReader vRdr)
        {
            			this.ID_USUARIO = Convert.ToInt32(vRdr["ID_USUARIO"]);  
			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  


        }
    }
}