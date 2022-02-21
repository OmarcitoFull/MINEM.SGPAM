using Minem.Sgpam.TransporteDatos.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
	/// <summary>
	/// Objetivo:	Objeto de negocio para el cliente
	/// Creado Por:	Omar Rodriguez Muñoz    
	/// Fecha Creación:	28/10/2021
	/// </summary>
	public partial class Eum_OperacionDTO : BaseOTD
    {
		#region Propiedades
		public int Id_Eum_Operacion { get; set; }
		public string Usu_Modifica { get; set; }
		public string Ip_Modifica { get; set; }
		public int Id_Tipo_Operacion { get; set; }
		public int Id_Eum { get; set; }
		public string Usu_Ingreso { get; set; }
		public DateTime? Fec_Ingreso { get; set; }
		public DateTime? Fec_Modifica { get; set; }
		public string Flg_Estado { get; set; }
		public string Ip_Ingreso { get; set; }


		public List<Tipo_OperacionDTO> CboTipoOperacion { get; set; }
		public string TipoOperacion { get; set; }

		#endregion    
	}
}
