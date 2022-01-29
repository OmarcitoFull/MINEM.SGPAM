using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpam_Visita 
    { 
        public T_Sgpam_Visita()
        {

        }

        public T_Sgpam_Visita(IDataReader vRdr)
        {
            

			this.ID_VISITA = Convert.ToInt32(vRdr["ID_VISITA"]);  


        }
    }
}