using Minem.Sgpam.TransporteDatos.Base;
using System;
using System.Collections.Generic;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
	/// <summary>
	/// Objetivo:	Objeto de negocio para el cliente
	/// Creado Por:	Omar Rodriguez Muñoz    
	/// Fecha Creación:	28/10/2021
	/// </summary>
	public partial class ComponenteDTO : BaseOTD
	{
		#region Propiedades
		public string Id_Datum { get; set; }
		public string Usu_Ingreso { get; set; }
		public int? Id_Humedad { get; set; }
		public int Id_Eum { get; set; }
		public DateTime? Fec_Modifica { get; set; }
		public int? Id_Tamano_Particula { get; set; }
		public string Nombre { get; set; }
		public string Otro_Descripcion { get; set; }
		public int? Id_Tipo_Mineria { get; set; }
		public string Flg_Estado { get; set; }
		public int Id_Componente { get; set; }
		public int? Id_Cuenca { get; set; }
		public int? Puntaje_Normalizado { get; set; }
		public string Caracteristica { get; set; }
		public string Ip_Ingreso { get; set; }
		public DateTime? Fec_Ingreso { get; set; }
		public string Ubicacion { get; set; }
		public int? Puntaje { get; set; }
		public string Usu_Modifica { get; set; }
		public int? Id_Situacion_Pam { get; set; }
		public string Ip_Modifica { get; set; }
		public int? Id_Zona { get; set; }
		public int? Id_Tipo_Concesion { get; set; }
		public int? Id_Sub_Tipo_Pam { get; set; }
		public int? Este { get; set; }
		public int? Id_Cuenca_Hidro { get; set; }
		public int? Id_Cuenca_Secundaria { get; set; }
		public string Ubigeo { get; set; }
		public int Id_Tipo_Pam { get; set; }
		public int? Id_Cobertura { get; set; }
		public int? Norte { get; set; }
		public string Descripcion { get; set; }
		public string Riesgo { get; set; }

		public string Id_Region { get; set; }
		public string Id_Provincia { get; set; }
		public string Id_Distrito { get; set; }

		public List<Comp_ReconocimientoMinDTO> ListaReconocimientoMin { get; set; }
		#endregion
	}
}