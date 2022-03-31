using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
	/// <summary>
	/// Objetivo:	Entidad que mapea una tabla de base de datos
	/// Creado Por:	Omar Rodriguez Muñoz    
	/// Fecha Creación:	25/10/2021
	/// </summary>
	public partial class T_Sgpad_Componente : BEPaginacion
	{
		#region Propiedades
		public string ID_DATUM { get; set; }
		public string USU_INGRESO { get; set; }
		public int? ID_HUMEDAD { get; set; }
		public int ID_EUM { get; set; }
		public DateTime? FEC_MODIFICA { get; set; }
		public int? ID_TAMANO_PARTICULA { get; set; }
		public string NOMBRE { get; set; }
		public string OTRO_DESCRIPCION { get; set; }
		public int? ID_TIPO_MINERIA { get; set; }
		public string FLG_ESTADO { get; set; }
		public int ID_COMPONENTE { get; set; }
		public int? ID_CUENCA { get; set; }
		public int? PUNTAJE_NORMALIZADO { get; set; }
		public string CARACTERISTICA { get; set; }
		public string IP_INGRESO { get; set; }
		public DateTime? FEC_INGRESO { get; set; }
		public string UBICACION { get; set; }
		public int? PUNTAJE { get; set; }
		public string USU_MODIFICA { get; set; }
		public int? ID_SITUACION_PAM { get; set; }
		public string IP_MODIFICA { get; set; }
		public int? ID_ZONA { get; set; }
		public int? ID_TIPO_CONCESION { get; set; }
		public int? ID_SUB_TIPO_PAM { get; set; }
		public decimal? ESTE { get; set; }
		public int? ID_CUENCA_HIDRO { get; set; }
		public int? ID_CUENCA_SECUNDARIA { get; set; }
		public string UBIGEO { get; set; }
		public int ID_TIPO_PAM { get; set; }
		public int? ID_COBERTURA { get; set; }
		public decimal? NORTE { get; set; }
		public string DESCRIPCION { get; set; }
		public string RIESGO { get; set; }
		#endregion
	}
}