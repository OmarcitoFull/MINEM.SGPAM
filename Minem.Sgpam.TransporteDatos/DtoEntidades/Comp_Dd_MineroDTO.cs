using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class Comp_Dd_MineroDTO : BaseOTD
    {
        #region Propiedades
        public string Codigo_Dm { get; set; }  		public int Id_Componente { get; set; }  		public string Ip_Ingreso { get; set; }  		public int? Id_Estado { get; set; }  		public int? Id_Sustancia { get; set; }  		public string Usu_Modifica { get; set; }  		public string Descripcion_Dm { get; set; }  		public int? Id_Situacion { get; set; }  		public string Flg_Estado { get; set; }  		public int Id_Comp_Dm { get; set; }  		public int? Id_Tipo_Dm { get; set; }  		public DateTime? Fec_Modifica { get; set; }  		public string Uea { get; set; }  		public string Usu_Ingreso { get; set; }  		public string Ip_Modifica { get; set; }  		public DateTime? Fec_Ingreso { get; set; }

		public string Des_Tipo { get; set; }
		public string Des_Sustancia { get; set; }
		public string Des_Situacion { get; set; }
		public string Des_Estado { get; set; }
		#endregion
	}
}