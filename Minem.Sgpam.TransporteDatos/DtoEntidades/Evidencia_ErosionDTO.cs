using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class Evidencia_ErosionDTO : BaseOTD
    {
        #region Propiedades
        public string Usu_Modifica { get; set; }  		public int? Peso_Orm { get; set; }  		public string Ip_Ingreso { get; set; }  		public string Flg_Estado { get; set; }  		public int? Peso_I { get; set; }  		public int? Peso_Pq { get; set; }  		public string Ip_Modifica { get; set; }  		public int? Peso_Rm { get; set; }  		public int Id_Evidencia_Erosion { get; set; }  		public DateTime? Fec_Modifica { get; set; }  		public DateTime? Fec_Ingreso { get; set; }  		public string Descripcion { get; set; }  		public string Usu_Ingreso { get; set; }  		public int? Peso_Lb { get; set; }  		
        #endregion
    }
}