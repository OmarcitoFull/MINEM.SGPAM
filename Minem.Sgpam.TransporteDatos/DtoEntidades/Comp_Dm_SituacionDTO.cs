using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class Comp_Dm_SituacionDTO : BaseOTD
    {
        #region Propiedades
        public int Id_Comp_Dm { get; set; }  		public string Ip_Ingreso { get; set; }  		public string Flg_Estado { get; set; }  		public int Anio { get; set; }  		public int? Id_Tipo_Concentrado { get; set; }  		public DateTime? Fec_Modifica { get; set; }  		public int Id_Comp_Dm_Situacion { get; set; }  		public string Ip_Modifica { get; set; }  		public DateTime? Fec_Ingreso { get; set; }  		public int? Cantidad { get; set; }  		public string Usu_Modifica { get; set; }  		public string Usu_Ingreso { get; set; }  		public int? Id_Situacion { get; set; }  		
        #endregion
    }
}