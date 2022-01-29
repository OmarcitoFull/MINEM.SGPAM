using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpal_Sub_Tipo_Lnr 
    { 
        public T_Sgpal_Sub_Tipo_Lnr()
        {

        }

        public T_Sgpal_Sub_Tipo_Lnr(IDataReader vRdr)
        {
            


			this.ID_SUB_TIPO_LNR = Convert.ToInt32(vRdr["ID_SUB_TIPO_LNR"]);  

        }
    }
}