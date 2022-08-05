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
    public partial class MaestraDTO : BaseOTD
    {
		#region Propiedades
		public int Id_Eum { get; set; }
		[Required]
		[StringLength(100)]
		public string Eum_Descripcion { get; set; }
		[Required]
		[StringLength(300)]
		public string Acceso_Eum { get; set; }
		[Required]
		[StringLength(300)]
		public string Historia_Eum { get; set; }
		[Required]
		[StringLength(300)]
		public string Evidencia_Act_Rec { get; set; }
		[Required]
		public int Id_Tipo_Operacion { get; set; }
		[Required]
		public int Id_Tipo_Sustancia { get; set; }
		[Required]
		public string Relieve { get; set; }
		[Required]
		public string Cuerpos_Agua { get; set; }
		[Required]
		public int Id_Conflicto_Social { get; set; }
		[Required]
		public string Flora_Terrestre { get; set; }
		[Required]
		public string Fauna_Terreste { get; set; }
		[Required]
		public string Flora_Fauna_Acuatica { get; set; }
		[Required]
		public string Infra_Urbana { get; set; }
		[Required]
		public string Uso_Suelo { get; set; }
		[Required]
		public string Uso_Agua { get; set; }
		[Required]
		public string Area_Conservacion { get; set; }
		[Required]
		public string Sitio_Arque_Turistico { get; set; }
		public string Conflicto_Social { get; set; }
		[Required]
		public string Descripcion_Eum { get; set; }
		public string Comentario_Adi { get; set; }
		public int? Num_Eum { get; set; }
		public int? Id_Estado_Registro { get; set; }

		public string Usu_Ingreso { get; set; }
		public string Usu_Modifica { get; set; }
		public DateTime? Fec_Ingreso { get; set; }  		public DateTime? Fec_Modifica { get; set; }
		public string Ip_Ingreso { get; set; }
		public string Ip_Modifica { get; set; }
		public string Flg_Estado { get; set; }

		public DateTime? Ult_Visita { get; set; }
		public DateTime? Fecha_Informe { get; set; }
		public string Nro_Informe { get; set; }
		#endregion
	}
}