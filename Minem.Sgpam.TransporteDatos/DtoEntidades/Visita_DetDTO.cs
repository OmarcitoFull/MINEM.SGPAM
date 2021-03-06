using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class Visita_DetDTO : BaseOTD
    {
        #region Propiedades
        public int Id_Visita_Det { get; set; }
		public int Id_Visita { get; set; }
		public int Id_Tipo_Registro { get; set; }
		public int? Id_Eum { get; set; }
		public int? Id_Expediente { get; set; }
		public string Motivo { get; set; }
		public string Observacion { get; set; }
		public string Usu_Ingreso { get; set; }
		public DateTime? Fec_Ingreso { get; set; }
		public string Ip_Ingreso { get; set; }
		public string Usu_Modifica { get; set; }
		public DateTime? Fec_Modifica { get; set; }
		public string Ip_Modifica { get; set; }  		public string Flg_Estado { get; set; }

		public string Tipo_Registro { get; set; }
		public string Nro_Expediente { get; set; }
		public string Nombre_Eum { get; set; }
		#endregion
	}
}