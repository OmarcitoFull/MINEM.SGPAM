using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class V_Sgpad_Comp_Riesgo_Fau_Con : T_Sgpad_Comp_Riesgo_Fau_Con
    {
		public V_Sgpad_Comp_Riesgo_Fau_Con()
        {

        }

		public V_Sgpad_Comp_Riesgo_Fau_Con(IDataReader vRdr)
		{

			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))
			{
				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);
			}
			this.ID_SENSIBILIDAD_AREA = Convert.ToInt32(vRdr["ID_SENSIBILIDAD_AREA"]);
			this.ID_COMP_RIESGO_FAU_CON = Convert.ToInt32(vRdr["ID_COMP_RIESGO_FAU_CON"]);
			this.ID_ACCESO_FAUNA = Convert.ToInt32(vRdr["ID_ACCESO_FAUNA"]);

			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))
			{
				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);
			}

			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))
			{
				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);
			}
			this.ID_VEGETACION_INVASIVA = Convert.ToInt32(vRdr["ID_VEGETACION_INVASIVA"]);
			this.ID_ATRACCION_FAUNA = Convert.ToInt32(vRdr["ID_ATRACCION_FAUNA"]);

			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))
			{
				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);
			}

			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))
			{
				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);
			}
			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);
			this.ID_CERCA_AREA_PROTEGIDA = Convert.ToInt32(vRdr["ID_CERCA_AREA_PROTEGIDA"]);
			this.ID_AGUA_CONTAMINADA = Convert.ToInt32(vRdr["ID_AGUA_CONTAMINADA"]);

			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))
			{
				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);
			}
			this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);

			if (!Convert.IsDBNull(vRdr["ACCESO_FAUNA"]))
			{
				this.ACCESO_FAUNA = Convert.ToString(vRdr["ACCESO_FAUNA"]);
			}
			if (!Convert.IsDBNull(vRdr["ATRACCION_FAUNA"]))
			{
				this.ATRACCION_FAUNA = Convert.ToString(vRdr["ATRACCION_FAUNA"]);
			}
			if (!Convert.IsDBNull(vRdr["VEGETACION_INVASIVA"]))
			{
				this.VEGETACION_INVASIVA = Convert.ToString(vRdr["VEGETACION_INVASIVA"]);
			}
			if (!Convert.IsDBNull(vRdr["CERCA_AREA_PROTEGIDA"]))
			{
				this.CERCA_AREA_PROTEGIDA = Convert.ToString(vRdr["CERCA_AREA_PROTEGIDA"]);
			}
			if (!Convert.IsDBNull(vRdr["SENSIBILIDAD_AREA"]))
			{
				this.SENSIBILIDAD_AREA = Convert.ToString(vRdr["SENSIBILIDAD_AREA"]);
			}
			if (!Convert.IsDBNull(vRdr["AGUA_CONTAMINADA"]))
			{
				this.AGUA_CONTAMINADA = Convert.ToString(vRdr["AGUA_CONTAMINADA"]);
			}
		}

        public string ACCESO_FAUNA { get; set; }
		public string ATRACCION_FAUNA { get; set; }
		public string VEGETACION_INVASIVA { get; set; }
		public string CERCA_AREA_PROTEGIDA { get; set; }
		public string SENSIBILIDAD_AREA { get; set; }
		public string AGUA_CONTAMINADA { get; set; }
	}
}