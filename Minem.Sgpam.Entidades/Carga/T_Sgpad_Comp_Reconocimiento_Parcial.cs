using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
	/// <summary>
	/// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
	/// Creado Por:	Omar Rodriguez Muñoz    
	/// Fecha Creación:	26/10/2021
	/// </summary>
	public partial class T_Sgpad_Comp_Reconocimiento
	{
		public T_Sgpad_Comp_Reconocimiento()
		{

		}

		public T_Sgpad_Comp_Reconocimiento(IDataReader vRdr)
		{

			if (!Convert.IsDBNull(vRdr["ALTURA"]))
			{				this.ALTURA = Convert.ToDecimal(vRdr["ALTURA"]);
			}			this.ID_TIPO_RECONOCIMIENTO = Convert.ToInt32(vRdr["ID_TIPO_RECONOCIMIENTO"]);

			if (!Convert.IsDBNull(vRdr["BASE"]))
			{				this.BASE = Convert.ToInt32(vRdr["BASE"]);
			}			this.ID_COMP_RECONOCIMIENTO = Convert.ToInt32(vRdr["ID_COMP_RECONOCIMIENTO"]);

			if (!Convert.IsDBNull(vRdr["ANCHO"]))
			{				this.ANCHO = Convert.ToInt32(vRdr["ANCHO"]);
			}			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))
			{				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);
			}			if (!Convert.IsDBNull(vRdr["ID_TIPO_MINERIA"]))
			{				this.ID_TIPO_MINERIA = Convert.ToInt32(vRdr["ID_TIPO_MINERIA"]);
			}			this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);

			if (!Convert.IsDBNull(vRdr["VOLUMEN"]))
			{				this.VOLUMEN = Convert.ToDecimal(vRdr["VOLUMEN"]);
			}			if (!Convert.IsDBNull(vRdr["LARGO"]))
			{				this.LARGO = Convert.ToInt32(vRdr["LARGO"]);
			}			if (!Convert.IsDBNull(vRdr["CANTIDAD"]))
			{				this.CANTIDAD = Convert.ToInt32(vRdr["CANTIDAD"]);
			}			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))
			{				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);
			}			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);

			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))
			{				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);
			}			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))
			{				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);
			}			if (!Convert.IsDBNull(vRdr["PROFUNDIDAD"]))
			{				this.PROFUNDIDAD = Convert.ToDecimal(vRdr["PROFUNDIDAD"]);
			}			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))
			{				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);
			}			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))
			{				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);
			}			if (!Convert.IsDBNull(vRdr["AREA"]))
			{				this.AREA = Convert.ToDecimal(vRdr["AREA"]);
			}

		}
	}
}