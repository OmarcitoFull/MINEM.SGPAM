using Minem.Sgpam.TransporteDatos.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class Comp_Enc_RemDTO : BaseOTD
    {
        #region Propiedades
        public int Id_Comp_Enc_Rem { get; set; }
        public int Id_Componente { get; set; }
        [Required]
        [StringLength(100)]
        public string Nro_Remediacion { get; set; }
        [Required]
        [StringLength(100)]
        public string Resolucion_Exc_Enc { get; set; }
        [Required]
        [Range(1, 99999999)]
        public int Id_Tipo_Encargo { get; set; }
        [Required]
        [Range(1, 99999999)]
        public int Id_Tipo_Resolucion { get; set; }
        [Required]
        [Range(1, 99999999)]
        public int Anio_Resolucion { get; set; }
        [Required]
        [StringLength(100)]
        public string Responsable_Remediacion { get; set; }

        public DateTime? Fec_Modifica { get; set; }
        public string Ip_Ingreso { get; set; }
        public DateTime? Fec_Ingreso { get; set; }
        [StringLength(1)]
        public string Flg_Estado { get; set; }
        public string Usu_Modifica { get; set; }
        public string Usu_Ingreso { get; set; }
        public string Ip_Modifica { get; set; }


        public string Resolucion_Encargo { get; set; }
        public List<Tipo_EncargoDTO> CboTipoEncargo { get; set; }
        public List<Tipo_ResolucionDTO> CboTipoResolucion { get; set; }
        #endregion
    }
}