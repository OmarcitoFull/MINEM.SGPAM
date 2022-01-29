using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class Eum_ModDTO : BaseOTD
    {
        #region Propiedades
        public int Id_Eum { get; set; }  
		public DateTime? Fec_Ingreso { get; set; }  
		public string Usu_Ingreso { get; set; }  
		public string Cargo { get; set; }  
		public int Id_Eum_Mod { get; set; }  
		public string Flg_Estado { get; set; }  
		public string Ip_Ingreso { get; set; }  
		
        #endregion
    }
}