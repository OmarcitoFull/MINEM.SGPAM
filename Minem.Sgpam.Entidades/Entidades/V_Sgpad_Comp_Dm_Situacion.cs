using Minem.Sgpam.Entidades.Base;
using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    public partial class V_Sgpad_Comp_Dm_Situacion : BEPaginacion
	{
		public V_Sgpad_Comp_Dm_Situacion()
        {

        }

		public V_Sgpad_Comp_Dm_Situacion(IDataReader vRdr)
		{
			this.ID_COMP_DM_SITUACION = Convert.ToInt32(vRdr["ID_COMP_DM_SITUACION"]);
			this.ID_COMP_DM = Convert.ToInt32(vRdr["ID_COMP_DM"]);

			this.ANIO = Convert.ToInt32(vRdr["ANIO"]);

			if (!Convert.IsDBNull(vRdr["ID_CLIENTE"]))
			{
				this.ID_CLIENTE = Convert.ToString(vRdr["ID_CLIENTE"]);
			}

			if (!Convert.IsDBNull(vRdr["NOMBRE_CLIENTE"]))
			{
				this.NOMBRE_CLIENTE = Convert.ToString(vRdr["NOMBRE_CLIENTE"]);
			}

			if (!Convert.IsDBNull(vRdr["ID_SITUACION"]))
			{
				this.ID_SITUACION = Convert.ToString(vRdr["ID_SITUACION"]);
			}

			if (!Convert.IsDBNull(vRdr["SITUACION_UP"]))
			{
				this.SITUACION_UP = Convert.ToString(vRdr["SITUACION_UP"]);
			}

			if (!Convert.IsDBNull(vRdr["ID_TIPO_CONCENTRADO"]))
			{
				this.ID_TIPO_CONCENTRADO = Convert.ToInt32(vRdr["ID_TIPO_CONCENTRADO"]);
			}

			if (!Convert.IsDBNull(vRdr["TIPO_CONCENTRADO"]))
			{
				this.TIPO_CONCENTRADO = Convert.ToString(vRdr["TIPO_CONCENTRADO"]);
			}

			if (!Convert.IsDBNull(vRdr["CANTIDAD"]))
			{
				this.CANTIDAD = Convert.ToInt32(vRdr["CANTIDAD"]);
			}

			if (!Convert.IsDBNull(vRdr["NOMBRE_DM"]))
			{
				this.NOMBRE_DM = Convert.ToString(vRdr["NOMBRE_DM"]);
			}

			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);
		}


		#region Propiedades
		public int ID_COMP_DM_SITUACION { get; set; }
		public int ID_COMP_DM { get; set; }
		public int ANIO { get; set; }
		public string ID_SITUACION { get; set; }
		public int ID_TIPO_CONCENTRADO { get; set; }
		public int CANTIDAD { get; set; }
		public string ID_CLIENTE { get; set; }
		public string NOMBRE_CLIENTE { get; set; }
		public string NOMBRE_DM { get; set; }
		public string TIPO_CONCENTRADO { get; set; }
		public string SITUACION_UP { get; set; }
		public string FLG_ESTADO { get; set; }
		#endregion


	}
}
