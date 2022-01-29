using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpaj_Visita_Det_Com_Lnr 
    { 
        public T_Sgpaj_Visita_Det_Com_Lnr()
        {

        }

        public T_Sgpaj_Visita_Det_Com_Lnr(IDataReader vRdr)
        {
            
			this.ID_VISITA_DET_COM_LNR = Convert.ToInt32(vRdr["ID_VISITA_DET_COM_LNR"]);  


        }
    }
}