using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Mateo Salvador Paucar    
    /// Fecha Creación:	14/02/2022
    /// </summary>
    public partial class T_Sgpal_Cargo : BEPaginacion
    {
		#region Propiedades
		public int ID_CARGO { get; set; }
		public string DESCRIPCION { get; set; }
		public string USU_INGRESO { get; set; }
		public DateTime? FEC_INGRESO { get; set; }
		public string IP_INGRESO { get; set; }
		public string USU_MODIFICA { get; set; }
		public DateTime? FEC_MODIFICA { get; set; }
		public string IP_MODIFICA { get; set; }
		public string FLG_ESTADO { get; set; }

		#endregion
	}
}
