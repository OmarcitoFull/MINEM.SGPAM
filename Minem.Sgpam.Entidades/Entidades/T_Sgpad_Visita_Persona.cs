using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Mateo Salvador Paucar  
    /// Fecha Creación:	14/04/2022
    /// </summary>
    public partial class T_Sgpad_Visita_Persona : BEPaginacion
    {
		#region Propiedades
		public int ID_VISITA_PERSONA { get; set; }
		public int ID_VISITA { get; set; }
		public int ID_CARGO { get; set; }
		public string DNI { get; set; }
		public string NOMBRE_COMPLETO { get; set; }
		public string CORREO { get; set; }
		public string CONTACTO { get; set; }
		public string USU_INGRESO { get; set; }
		public DateTime? FEC_INGRESO { get; set; }
		public string IP_INGRESO { get; set; }
		public string USU_MODIFICA { get; set; }
		public DateTime? FEC_MODIFICA { get; set; }
		public string IP_MODIFICA { get; set; }
		public string FLG_ESTADO { get; set; }

		public string CARGO { get; set; }
		#endregion
	}
}
