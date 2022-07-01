using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class Eum_Info_DescargoDTO : BaseOTD
    {
		#region Propiedades
		public int Id_Eum_Info_Descargo { get; set; }
		public int Id_Eum { get; set; }
		public DateTime Fecha_Descargo { get; set; }
		public string Titular { get; set; }
		public string Declaracion { get; set; }
		public string Asunto { get; set; }
		public string Nombre_Documento { get; set; }
		public string Ruta_Documento { get; set; }
		public string Extencion { get; set; }
		public int? Tamano { get; set; }
		public long? Id_LaserFiche { get; set; }
		public string Usu_Ingreso { get; set; }
		public DateTime? Fec_Ingreso { get; set; }
		public string Ip_Ingreso { get; set; }
		public string Usu_Modifica { get; set; }
		public DateTime? Fec_Modifica { get; set; }
		public string Ip_Modifica { get; set; }
		public string Flg_Estado { get; set; }

		#endregion
	}
}