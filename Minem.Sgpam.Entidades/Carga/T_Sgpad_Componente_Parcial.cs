using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Componente 
    { 
        public T_Sgpad_Componente()
        {

        }

        public T_Sgpad_Componente(IDataReader vRdr)
        {
            			this.ID_DATUM = Convert.ToString(vRdr["ID_DATUM"]);  


			this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);

			if (!Convert.IsDBNull(vRdr["ID_CUENCA"]))
			{
				this.ID_CUENCA = Convert.ToInt32(vRdr["ID_CUENCA"]);
			}

			{
				this.ID_ZONA = Convert.ToInt32(vRdr["ID_ZONA"]);
			}
			{
				this.ID_SUB_TIPO_PAM = Convert.ToInt32(vRdr["ID_SUB_TIPO_PAM"]);
			}

			if (!Convert.IsDBNull(vRdr["ESTE"]))
			{
				this.ESTE = Convert.ToInt32(vRdr["ESTE"]);
			}

			if (!Convert.IsDBNull(vRdr["ID_CUENCA_HIDRO"]))
			{
				this.ID_CUENCA_HIDRO = Convert.ToInt32(vRdr["ID_CUENCA_HIDRO"]);
			}
			this.ID_TIPO_PAM = Convert.ToInt32(vRdr["ID_TIPO_PAM"]);  


			if (!Convert.IsDBNull(vRdr["NORTE"]))
			{
				this.NORTE = Convert.ToInt32(vRdr["NORTE"]);
			}

			this.DESCRIPCION = Convert.ToString(vRdr["DESCRIPCION"]);
			
			if (!Convert.IsDBNull(vRdr["RIESGO"]))
			{
			}
		}
    }
}