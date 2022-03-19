using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Mateo Salvador Paucar    
    /// Fecha Creación:	07/02/2022
    /// </summary>
    public partial class T_Sgpad_Eum_Operacion : BEPaginacion
    {
		#region Propiedades
		public int ID_EUM_OPERACION { get; set; }
		public int ID_EUM { get; set; }
		public int ID_TIPO_OPERACION { get; set; }
		public string USU_INGRESO { get; set; }
		public DateTime? FEC_INGRESO { get; set; }
		public string IP_INGRESO { get; set; }
		public string USU_MODIFICA { get; set; }
		public DateTime? FEC_MODIFICA { get; set; }
		public string IP_MODIFICA { get; set; }
		public string FLG_ESTADO { get; set; }

		public string TIPO_OPERACION { get; set; }

		#endregion

	}
}
