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
			this.UBIGEO = Convert.ToString(vRdr["UBIGEO"]);
			this.FECHA_SALIDA = Convert.ToDateTime(vRdr["FECHA_SALIDA"]);
			if (!Convert.IsDBNull(vRdr["FECHA_REGRESO"]))
			{				this.FECHA_REGRESO = Convert.ToDateTime(vRdr["FECHA_REGRESO"]);
			}

			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))
			{				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);
			}			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))
			{				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);
			}			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))  			{				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))
			{				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);
			}			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))
			{				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);
			}			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))
			{				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);
			}			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);


			//for (int i = 0; i < vRdr.FieldCount; i++)
			//{
			//	if (vRdr.GetName(i).Equals("DEPARTAMENTO", StringComparison.InvariantCultureIgnoreCase))
			//		if (!Convert.IsDBNull(vRdr["DEPARTAMENTO"]))
			//			this.REGION = Convert.ToString(vRdr["DEPARTAMENTO"]);

			//	if (vRdr.GetName(i).Equals("PROVINCIA", StringComparison.InvariantCultureIgnoreCase))
			//		if (!Convert.IsDBNull(vRdr["PROVINCIA"]))
			//			this.PROVINCIA = Convert.ToString(vRdr["PROVINCIA"]);

			//	if (vRdr.GetName(i).Equals("DISTRITO", StringComparison.InvariantCultureIgnoreCase))
			//		if (!Convert.IsDBNull(vRdr["DISTRITO"]))
			//			this.DISTRITO = Convert.ToString(vRdr["DISTRITO"]);
			//}

		}
	}
}