using Minem.Sgpam.Entidades.Base;
using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class V_Sgpad_Comp_Riesgo_Sal_Amb: T_Sgpad_Comp_Riesgo_Sal_Amb 
    {
        public V_Sgpad_Comp_Riesgo_Sal_Amb()
        {

        }

		public V_Sgpad_Comp_Riesgo_Sal_Amb(IDataReader vRdr)
		{

			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))
			{
				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);
			}
			this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);
			this.ID_EVIDENCIA_INUNDACION = Convert.ToInt32(vRdr["ID_EVIDENCIA_INUNDACION"]);

			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))
			{
				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);
			}

			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))
			{
				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);
			}
			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);
			this.ID_POTENCIAL_ARD = Convert.ToInt32(vRdr["ID_POTENCIAL_ARD"]);
			this.ID_EVIDENCIA_EROSION = Convert.ToInt32(vRdr["ID_EVIDENCIA_EROSION"]);

			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))
			{
				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);
			}
			this.ID_EVIDENCIA_SUS_TOXICA = Convert.ToInt32(vRdr["ID_EVIDENCIA_SUS_TOXICA"]);

			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))
			{
				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);
			}

			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))
			{
				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);
			}
			this.ID_COMP_RIESGO_SAL_AMB = Convert.ToInt32(vRdr["ID_COMP_RIESGO_SAL_AMB"]);

			if (!Convert.IsDBNull(vRdr["EVIDENCIA_EROSION"]))
			{
				this.EVIDENCIA_EROSION = Convert.ToString(vRdr["EVIDENCIA_EROSION"]);
			}
			if (!Convert.IsDBNull(vRdr["EVIDENCIA_INUNDACION"]))
			{
				this.EVIDENCIA_INUNDACION = Convert.ToString(vRdr["EVIDENCIA_INUNDACION"]);
			}
			if (!Convert.IsDBNull(vRdr["POTENCIAL_ARD"]))
			{
				this.POTENCIAL_ARD = Convert.ToString(vRdr["POTENCIAL_ARD"]);
			}
			if (!Convert.IsDBNull(vRdr["EVIDENCIA_SUS_TOXICA"]))
			{
				this.EVIDENCIA_SUS_TOXICA = Convert.ToString(vRdr["EVIDENCIA_SUS_TOXICA"]);
			}
		}

        public string EVIDENCIA_EROSION { get; set; }
		public string EVIDENCIA_INUNDACION { get; set; }
		public string POTENCIAL_ARD { get; set; }
		public string EVIDENCIA_SUS_TOXICA { get; set; }
	}
}