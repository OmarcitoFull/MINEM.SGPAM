using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpaj_Usuario_Perfil 
    { 
        public T_Sgpaj_Usuario_Perfil()
        {

        }

        public T_Sgpaj_Usuario_Perfil(IDataReader vRdr)
        {
            
			this.ID_PERFIL = Convert.ToInt32(vRdr["ID_PERFIL"]);  
			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  


        }
    }
}