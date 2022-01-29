using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class Eum_UbicacionDTO : BaseOTD
    {
        #region Propiedades
        public DateTime? Fec_Ingreso { get; set; }  		public string Paraje { get; set; }  		public int Id_Cuenca_Principal { get; set; }  		public int? Id_Cuenca_Secundaria { get; set; }  		public DateTime? Fec_Modifica { get; set; }  		public int Id_Eum_Ubicacion { get; set; }  		public string Referencia { get; set; }  		public string Ip_Modifica { get; set; }  		public string Ip_Ingreso { get; set; }  		public string Usu_Modifica { get; set; }  		public int Id_Eum { get; set; }  		public string Ubigeo { get; set; }  		public string Usu_Ingreso { get; set; }  		public string Flg_Estado { get; set; }  		
        #endregion
    }
}