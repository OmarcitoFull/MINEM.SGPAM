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
    public partial class Comp_ObservacionDTO : BaseOTD
    {
        #region Propiedades
        public int Id_Comp_Observacion { get; set; }
        public int Id_Componente { get; set; }
        [StringLength(300)]
        public string Suelos_Disturbados { get; set; }
        [StringLength(300)]
        public string Obras_Rehabilitacion { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        [StringLength(100)]
        public string Descripcion_Comp { get; set; }

        public DateTime? Fec_Ingreso { get; set; }
        public string Usu_Ingreso { get; set; }
        public string Ip_Ingreso { get; set; }
        public DateTime? Fec_Modifica { get; set; }
        public string Usu_Modifica { get; set; }
        public string Ip_Modifica { get; set; }

        [StringLength(1)]
        public string Flg_Estado { get; set; }
        #endregion
    }
}