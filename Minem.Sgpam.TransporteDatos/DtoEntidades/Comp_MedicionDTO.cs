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
    public partial class Comp_MedicionDTO : BaseOTD
    {
        #region Propiedades
        public int Id_Comp_Medicion { get; set; }
        public int Id_Componente { get; set; }
        [Required]
        public DateTime Fecha_Desicion { get; set; }
        [Required]
        public int Ph { get; set; }
        [Required]
        [StringLength(100)]
        public string Conductividad { get; set; }
        [Required]
        [StringLength(100)]
        public string Caudal { get; set; }
        [Required]
        [StringLength(100)]
        public string Observacion { get; set; }
        public string Ip_Modifica { get; set; }
        public string Ip_Ingreso { get; set; }
        public DateTime? Fec_Modifica { get; set; }
        public string Usu_Modifica { get; set; }
        public string Usu_Ingreso { get; set; }
        public DateTime? Fec_Ingreso { get; set; }
        [StringLength(1)]
        public string Flg_Estado { get; set; }

        #endregion
    }
}