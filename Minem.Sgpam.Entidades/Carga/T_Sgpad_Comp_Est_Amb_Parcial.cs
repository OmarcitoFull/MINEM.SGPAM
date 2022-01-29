using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Est_Amb 
    { 
        public T_Sgpad_Comp_Est_Amb()
        {

        }

        public T_Sgpad_Comp_Est_Amb(IDataReader vRdr)
        {
            

			this.DES_NOM_TITULAR = Convert.ToString(vRdr["DES_NOM_TITULAR"]);  

			this.DES_UND_AMBIENTAL = Convert.ToString(vRdr["DES_UND_AMBIENTAL"]);  

			this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);  



        }
    }
}