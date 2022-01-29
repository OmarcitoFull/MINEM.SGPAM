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
    public partial class V_Sgpad_Componente : BEPaginacion
    {
		public V_Sgpad_Componente()
		{

		}

		public V_Sgpad_Componente(IDataReader vRdr)
		{
			this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);

			if (!Convert.IsDBNull(vRdr["NOMBRE"]))
			{
				this.NOMBRE = Convert.ToString(vRdr["NOMBRE"]);
			}

			if (!Convert.IsDBNull(vRdr["TIPO"]))
			{
				this.TIPO = Convert.ToString(vRdr["TIPO"]);
			}

			if (!Convert.IsDBNull(vRdr["SUBTIPO"]))
			{
				this.SUBTIPO = Convert.ToString(vRdr["SUBTIPO"]);
			}

			if (!Convert.IsDBNull(vRdr["ESTE"]))
			{
				this.ESTE = Convert.ToInt32(vRdr["ESTE"]);
			}

			if (!Convert.IsDBNull(vRdr["NORTE"]))
			{
				this.NORTE = Convert.ToInt32(vRdr["NORTE"]);
			}

			if (!Convert.IsDBNull(vRdr["ZONA"]))
			{
				this.ZONA = Convert.ToString(vRdr["ZONA"]);
			}

			if (!Convert.IsDBNull(vRdr["DATUM"]))
			{
				this.DATUM = Convert.ToString(vRdr["DATUM"]);
			}

			if (!Convert.IsDBNull(vRdr["RESPONSABLE"]))
			{
				this.RESPONSABLE = Convert.ToString(vRdr["RESPONSABLE"]);
			}

			if (!Convert.IsDBNull(vRdr["RIESGO"]))
			{
				this.RIESGO = Convert.ToString(vRdr["RIESGO"]);
			}

			if (!Convert.IsDBNull(vRdr["PUNTAJE"]))
			{
				this.PUNTAJE = Convert.ToInt32(vRdr["PUNTAJE"]);
			}

			if (!Convert.IsDBNull(vRdr["IMAGEN"]))
			{
				this.IMAGEN = Convert.ToString(vRdr["IMAGEN"]);
			}
			
			if (!Convert.IsDBNull(vRdr["FLG_ESTADO"]))
			{
				this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);
			}
		}


		#region Propiedades
		public int ID_COMPONENTE { get; set; }
		public string NOMBRE { get; set; }
		public string TIPO { get; set; }
		public string SUBTIPO { get; set; }
		public int ESTE { get; set; }
		public int NORTE { get; set; }
		public string ZONA { get; set; }
		public string DATUM { get; set; }
		public string RESPONSABLE { get; set; }
		public string RIESGO { get; set; }
		public int? PUNTAJE { get; set; }
		public string IMAGEN { get; set; }
		public string FLG_ESTADO { get; set; }
		#endregion
	}
}