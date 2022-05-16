using Minem.Sgpam.Entidades.Base;
using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    public partial class V_Genl_Ubigeo_Inei : BEPaginacion
    {
        public V_Genl_Ubigeo_Inei()
        {

        }

		public V_Genl_Ubigeo_Inei(IDataReader vRdr)
		{
			this.ID_UBIGEO_INEI = Convert.ToString(vRdr["ID_UBIGEO_INEI"]);

			if (!Convert.IsDBNull(vRdr["DEPARTAMENTO"]))
			{
				this.DEPARTAMENTO = Convert.ToString(vRdr["DEPARTAMENTO"]);
			}

			if (!Convert.IsDBNull(vRdr["PROVINCIA"]))
			{
				this.PROVINCIA = Convert.ToString(vRdr["PROVINCIA"]);
			}

			if (!Convert.IsDBNull(vRdr["DISTRITO"]))
			{
				this.DISTRITO = Convert.ToString(vRdr["DISTRITO"]);
			}

			if (!Convert.IsDBNull(vRdr["ID_DEPARTAMENTO"]))
			{
				this.ID_DEPARTAMENTO = Convert.ToString(vRdr["ID_DEPARTAMENTO"]);
			}

			if (!Convert.IsDBNull(vRdr["ID_PROVINCIA"]))
			{
				this.ID_PROVINCIA = Convert.ToString(vRdr["ID_PROVINCIA"]);
			}

			if (!Convert.IsDBNull(vRdr["ID_DISTRITO"]))
			{
				this.ID_DISTRITO = Convert.ToString(vRdr["ID_DISTRITO"]);
			}

			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);
		}


		#region Propiedades
		public string ID_UBIGEO_INEI { get; set; }
		public string ID_DEPARTAMENTO { get; set; }
		public string DEPARTAMENTO { get; set; }
		public string ID_PROVINCIA { get; set; }
		public string PROVINCIA { get; set; }
		public string ID_DISTRITO { get; set; }
		public string DISTRITO { get; set; }
		public string FLG_ESTADO { get; set; }
		#endregion


	}
}
