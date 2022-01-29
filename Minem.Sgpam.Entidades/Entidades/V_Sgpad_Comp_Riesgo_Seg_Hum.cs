using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class V_Sgpad_Comp_Riesgo_Seg_Hum : T_Sgpad_Comp_Riesgo_Seg_Hum
    {
        public V_Sgpad_Comp_Riesgo_Seg_Hum()
        {

        }

		public V_Sgpad_Comp_Riesgo_Seg_Hum(IDataReader vRdr)
		{
			this.ID_COMP_RIESGO_SEG_HUM = Convert.ToInt32(vRdr["ID_COMP_RIESGO_SEG_HUM"]);

			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))
			{
				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);
			}
			this.ID_PRESENCIA_ADVERTENCIA = Convert.ToInt32(vRdr["ID_PRESENCIA_ADVERTENCIA"]);
			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);
			this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);

			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))
			{
				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);
			}

			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))
			{
				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);
			}

			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))
			{
				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);
			}
			this.ID_HUNDIMIENTO = Convert.ToInt32(vRdr["ID_HUNDIMIENTO"]);

			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))
			{
				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);
			}
			this.ID_POT_COLAPSO = Convert.ToInt32(vRdr["ID_POT_COLAPSO"]);
			this.ID_POT_CAIDA_PERSONA = Convert.ToInt32(vRdr["ID_POT_CAIDA_PERSONA"]);
			this.ID_CONDICION_CIERRE = Convert.ToInt32(vRdr["ID_CONDICION_CIERRE"]);
			this.ID_PRESENCIA_ELEMENTO = Convert.ToInt32(vRdr["ID_PRESENCIA_ELEMENTO"]);

			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))
			{
				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);
			}
			this.ID_ACCESIBILIDAD = Convert.ToInt32(vRdr["ID_ACCESIBILIDAD"]);

			if (!Convert.IsDBNull(vRdr["ACCESIBILIDAD"]))
			{
				this.ACCESIBILIDAD = Convert.ToString(vRdr["ACCESIBILIDAD"]);
			}
			if (!Convert.IsDBNull(vRdr["POT_COLAPSO"]))
			{
				this.POT_COLAPSO = Convert.ToString(vRdr["POT_COLAPSO"]);
			}
			if (!Convert.IsDBNull(vRdr["CONDICION_CIERRE"]))
			{
				this.CONDICION_CIERRE = Convert.ToString(vRdr["CONDICION_CIERRE"]);
			}
			if (!Convert.IsDBNull(vRdr["PRESENCIA_ELEMENTO"]))
			{
				this.PRESENCIA_ELEMENTO = Convert.ToString(vRdr["PRESENCIA_ELEMENTO"]);
			}
			if (!Convert.IsDBNull(vRdr["HUNDIMIENTO"]))
			{
				this.HUNDIMIENTO = Convert.ToString(vRdr["HUNDIMIENTO"]);
			}
			if (!Convert.IsDBNull(vRdr["POT_CAIDA_PERSONA"]))
			{
				this.POT_CAIDA_PERSONA = Convert.ToString(vRdr["POT_CAIDA_PERSONA"]);
			}
			if (!Convert.IsDBNull(vRdr["PRESENCIA_ADVERTENCIA"]))
			{
				this.PRESENCIA_ADVERTENCIA = Convert.ToString(vRdr["PRESENCIA_ADVERTENCIA"]);
			}
		}

		public string ACCESIBILIDAD { get; set; }
		public string POT_COLAPSO { get; set; }
		public string CONDICION_CIERRE { get; set; }
		public string PRESENCIA_ELEMENTO { get; set; }
		public string HUNDIMIENTO { get; set; }
		public string POT_CAIDA_PERSONA { get; set; }
		public string PRESENCIA_ADVERTENCIA { get; set; }
	}
}