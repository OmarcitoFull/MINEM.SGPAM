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
			this.ID_COMP_EST_AMB = Convert.ToInt32(vRdr["ID_COMP_EST_AMB"]);
			this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);
			this.TIPO_ESTUDIO = Convert.ToString(vRdr["TIPO_ESTUDIO"]);
			this.DES_NOM_TITULAR = Convert.ToString(vRdr["DES_NOM_TITULAR"]);
			this.DES_UND_AMBIENTAL = Convert.ToString(vRdr["DES_UND_AMBIENTAL"]);
			this.DES_NOM_PROYECTO = Convert.ToString(vRdr["DES_NOM_PROYECTO"]);
			if (!Convert.IsDBNull(vRdr["RES_APROBACION"]))
			{				this.RES_APROBACION = Convert.ToString(vRdr["RES_APROBACION"]);
			}
			if (!Convert.IsDBNull(vRdr["FEC_RESOLUCION"]))
			{				this.FEC_RESOLUCION = Convert.ToDateTime(vRdr["FEC_RESOLUCION"]);
			}			this.NRO_EXPEDIENTE = Convert.ToString(vRdr["NRO_EXPEDIENTE"]);
			if (!Convert.IsDBNull(vRdr["FEC_EXPEDIENTE"]))
			{				this.FEC_EXPEDIENTE = Convert.ToDateTime(vRdr["FEC_EXPEDIENTE"]);
			}			this.DES_SITUACION = Convert.ToString(vRdr["DES_SITUACION"]);
			if (!Convert.IsDBNull(vRdr["NOMBRE_DOCUMENTO"]))
			{				this.NOMBRE_DOCUMENTO = Convert.ToString(vRdr["NOMBRE_DOCUMENTO"]);
			}
			if (!Convert.IsDBNull(vRdr["RUTA_DOCUMENTO"]))
			{				this.RUTA_DOCUMENTO = Convert.ToString(vRdr["RUTA_DOCUMENTO"]);
			}
			if (!Convert.IsDBNull(vRdr["EXTENCION"]))
			{				this.EXTENCION = Convert.ToString(vRdr["EXTENCION"]);
			}
			if (!Convert.IsDBNull(vRdr["TAMANO"]))
			{				this.TAMANO = Convert.ToInt32(vRdr["TAMANO"]);
			}			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);
			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))
			{				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);
			}
			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))
			{				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);
			}
			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))
			{				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);
			}
			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))
			{				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);
			}
			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))
			{				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);
			}			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))
			{				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);
			}

			if (!Convert.IsDBNull(vRdr["ID_LASERFICHE"]))
			{				this.ID_LASERFICHE= Convert.ToInt64(vRdr["ID_LASERFICHE"]);
			}
		}
	}
}