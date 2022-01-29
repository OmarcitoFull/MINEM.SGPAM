using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class VisitaDTO : BaseOTD
    {
        #region Propiedades
        public string Ip_Modifica { get; set; }  		public DateTime? Fec_Modifica { get; set; }  		public DateTime Fecha_Salida { get; set; }  		public string Ip_Ingreso { get; set; }  		public string Usu_Ingreso { get; set; }  		public string Ubigeo { get; set; }  		public int Id_Visita { get; set; }  		public DateTime? Fec_Ingreso { get; set; }  		public string Usu_Modifica { get; set; }  		public string Flg_Estado { get; set; }  		public DateTime? Fecha_Regreso { get; set; }  		
        #endregion
    }
}