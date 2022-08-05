using Minem.Sgpam.TransporteDatos.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class VisitaDTO : BaseOTD
    {
		#region Propiedades
		public int Id_Visita { get; set; }
		[Required]
		public string Ubigeo { get; set; }
		[Required]
		public DateTime Fecha_Salida { get; set; }
		public DateTime? Fecha_Regreso { get; set; }
		public string Usu_Ingreso { get; set; }
		public DateTime? Fec_Ingreso { get; set; }
		public string Ip_Ingreso { get; set; }
		public string Usu_Modifica { get; set; }
		public DateTime? Fec_Modifica { get; set; }
		public string Ip_Modifica { get; set; }
		public string Flg_Estado { get; set; }  
		public string Id_Region { get; set; }
		public string Id_Provincia { get; set; }
		public string Id_Distrito { get; set; }

		#endregion
	}
}