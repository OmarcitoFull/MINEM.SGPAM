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
    public partial class ExpedienteDTO : BaseOTD
    {
		#region Propiedades
		public int Id_Expediente { get; set; }
		[Required]
		public string Nro_Expediente { get; set; }  
		public string Zona { get; set; }
		public string Declarante { get; set; }

		public string Usu_Ingreso { get; set; }
		public DateTime? Fec_Ingreso { get; set; }
		public string Ip_Ingreso { get; set; }
		public string Usu_Modifica { get; set; }
		public DateTime? Fec_Modifica { get; set; }
		public string Ip_Modifica { get; set; }
		public string Flg_Estado { get; set; }


		public int anio { get; set; }
		public int Total_Lnr { get; set; }
		public string Nro_Informe { get; set; }

		#endregion
	}
}