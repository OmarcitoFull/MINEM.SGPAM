using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
	/// <summary>
	/// Objetivo:	Entidad que mapea una tabla de base de datos
	/// Creado Por:	Omar Rodriguez Muñoz    
	/// Fecha Creación:	25/10/2021
	/// </summary>
	public partial class T_Sgpad_Comp_Enc_Rem : BEPaginacion
	{
		#region Propiedades
		public string NRO_REMEDIACION { get; set; }
		public string RESOLUCION_EXC_ENC { get; set; }
		public int ANIO_RESOLUCION { get; set; }
		public int ID_TIPO_ENCARGO { get; set; }
		public int ID_TIPO_RESOLUCION { get; set; }
		public int ID_COMP_ENC_REM { get; set; }
		public DateTime? FEC_MODIFICA { get; set; }
		public int ID_COMPONENTE { get; set; }
		public string IP_INGRESO { get; set; }
		public DateTime? FEC_INGRESO { get; set; }
		public string FLG_ESTADO { get; set; }
		public string RESPONSABLE_REMEDIACION { get; set; }
		public string USU_MODIFICA { get; set; }
		public string USU_INGRESO { get; set; }
		public string IP_MODIFICA { get; set; }


		public string RESOLUCION_ENGARGO { get; set; }
		#endregion
	}
}