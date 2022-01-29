using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class Fuente_PasivoDTO : BaseOTD
    {
        #region Propiedades
        public DateTime? Fec_Modifica { get; set; }  		public string Usu_Modifica { get; set; }  		public string Descripcion { get; set; }  		public DateTime? Fec_Ingreso { get; set; }  		public string Ip_Ingreso { get; set; }  		public int Id_Fuente_Pasivo { get; set; }  		public string Ip_Modifica { get; set; }  		public string Usu_Ingreso { get; set; }  		public string Flg_Estado { get; set; }  		
        #endregion
    }
}