using Minem.Sgpam.Entidades.Base;
using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    public partial class V_Sgpad_ComponenteUbicacion : BEPaginacion
    {
        public V_Sgpad_ComponenteUbicacion()
        {

        }

        public V_Sgpad_ComponenteUbicacion(IDataReader vRdr)
        {
            this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);

            if (!Convert.IsDBNull(vRdr["NOMBRE"]))
            {
                this.NOMBRE = Convert.ToString(vRdr["NOMBRE"]);
            }

			if (!Convert.IsDBNull(vRdr["FLG_ESTADO"]))
			{
				this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);
			}

			if (!Convert.IsDBNull(vRdr["UBIGEO"]))
			{
				this.UBIGEO = Convert.ToString(vRdr["UBIGEO"]);
			}
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
			if (!Convert.IsDBNull(vRdr["ID_CUENCA_HIDRO"]))
			{
				this.ID_CUENCA_HIDRO = Convert.ToInt32(vRdr["ID_CUENCA_HIDRO"]);
			}
			if (!Convert.IsDBNull(vRdr["ID_CUENCA"]))
			{
				this.ID_CUENCA = Convert.ToInt32(vRdr["ID_CUENCA"]);
			}
			if (!Convert.IsDBNull(vRdr["UNI_HIDROGRAFICA"]))
			{
				this.UNI_HIDROGRAFICA = Convert.ToString(vRdr["UNI_HIDROGRAFICA"]);
			}
			if (!Convert.IsDBNull(vRdr["CUENCA_PRINCIPAL"]))
			{
				this.CUENCA_PRINCIPAL = Convert.ToString(vRdr["CUENCA_PRINCIPAL"]);
			}


		}

		#region Propiedades
		public int ID_COMPONENTE { get; set; }
		public string NOMBRE { get; set; }
		public string FLG_ESTADO { get; set; }
		public string UBIGEO { get; set; }
		public string DEPARTAMENTO { get; set; }
		public string PROVINCIA { get; set; }
		public string DISTRITO { get; set; }
		public int ID_CUENCA_HIDRO { get; set; }
		public int ID_CUENCA { get; set; }
		public string UNI_HIDROGRAFICA { get; set; }
		public string CUENCA_PRINCIPAL { get; set; }
		#endregion

	}
}
