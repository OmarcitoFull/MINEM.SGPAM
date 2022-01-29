using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class UsuarioDTO : BaseOTD
    {
        #region Propiedades
        public int Id_Usuario { get; set; }  		public string Flg_Estado { get; set; }  		public DateTime? Fec_Ingreso { get; set; }  		public DateTime? Fec_Modifica { get; set; }  		public string Usu_Ingreso { get; set; }  		public string Nombre_Usuario { get; set; }  		public string Cod_Usuario { get; set; }  		public string Ip_Modifica { get; set; }  		public string Ip_Ingreso { get; set; }  		public string Usu_Modifica { get; set; }  		
        #endregion
    }
}