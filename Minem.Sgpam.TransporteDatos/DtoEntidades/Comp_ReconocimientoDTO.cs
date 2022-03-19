using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
	/// <summary>
	/// Objetivo:	Objeto de negocio para el cliente
	/// Creado Por:	Omar Rodriguez Muñoz    
	/// Fecha Creación:	28/10/2021
	/// </summary>
	public partial class Comp_ReconocimientoDTO : BaseOTD
	{
		#region Propiedades
		public decimal? Altura { get; set; }
		public int Id_Tipo_Reconocimiento { get; set; }
		public int? Base { get; set; }
		public int Id_Comp_Reconocimiento { get; set; }
		public int? Ancho { get; set; }
		public string Usu_Ingreso { get; set; }
		public int? Id_Tipo_Mineria { get; set; }
		public int Id_Componente { get; set; }
		public decimal? Volumen { get; set; }
		public int? Largo { get; set; }
		public int? Cantidad { get; set; }
		public string Ip_Modifica { get; set; }
		public string Flg_Estado { get; set; }
		public DateTime? Fec_Modifica { get; set; }
		public string Ip_Ingreso { get; set; }
		public decimal? Profundidad { get; set; }
		public string Usu_Modifica { get; set; }
		public DateTime? Fec_Ingreso { get; set; }
		public decimal? Area { get; set; }

		public string Descripcion { get; set; }
		public int? Id_Tipo_Pam { get; set; }
		#endregion
	}
}