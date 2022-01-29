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
    public partial class Comp_Est_GestionDTO : BaseOTD
    {
        #region Propiedades
        public int Id_Comp_Est_Gestion { get; set; }  		public string Usu_Modifica { get; set; }  		public string Usu_Ingreso { get; set; }  		public DateTime? Fec_Ingreso { get; set; }  		public DateTime? Fec_Modifica { get; set; }  		public string Ip_Modifica { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Id_Estado_Gestion { get; set; }
        [StringLength(1)]
        public string Flg_Estado { get; set; }  		public DateTime? Fecha { get; set; }  		public string Sustento { get; set; }  		public string Ip_Ingreso { get; set; }  		public int Id_Componente { get; set; }
        public string Descripcion { get; set; }
        #endregion
    }
}