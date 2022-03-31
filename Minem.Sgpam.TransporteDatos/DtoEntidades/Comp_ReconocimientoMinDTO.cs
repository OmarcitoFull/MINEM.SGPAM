using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
	/// <summary>
	/// Objetivo:	Objeto de negocio para el cliente
	/// Creado Por:	Omar Rodriguez Muñoz    
	/// Fecha Creación:	28/10/2021
	/// </summary>
	public partial class Comp_ReconocimientoMinDTO : BaseOTD
	{
		#region Propiedades
		public int Id { get; set; }
		public int Tipo { get; set; }
		public int? Base { get; set; }
		public decimal? Altura { get; set; }
		public decimal? Profundidad { get; set; }
		public int? Largo { get; set; }
		public int? Ancho { get; set; }
		public decimal? Area { get; set; }
		public decimal? Volumen { get; set; }
		public int? Cantidad { get; set; }
		#endregion
	}
}