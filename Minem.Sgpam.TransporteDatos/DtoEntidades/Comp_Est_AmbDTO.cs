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
    public partial class Comp_Est_AmbDTO : BaseOTD
    {
        #region Propiedades
        public DateTime? Fec_Modifica { get; set; }
        public string Usu_Modifica { get; set; }
        [Required]
        [StringLength(50)]
        public string Tipo_Estudio { get; set; }
        public string Usu_Ingreso { get; set; }
        public DateTime? Fec_Resolucion { get; set; }
        [Required]
        [StringLength(50)]
        public string Nro_Expediente { get; set; }
        [Required]
        [StringLength(300)]
        public string Des_Nom_Titular { get; set; }
        public string Ip_Modifica { get; set; }
        [Required]
        [StringLength(300)]
        public string Des_Nom_Proyecto { get; set; }
        [Required]
        [StringLength(300)]
        public string Des_Und_Ambiental { get; set; }
        public DateTime? Fec_Expediente { get; set; }
        [Required]
        [StringLength(100)]
        public string Des_Situacion { get; set; }
        public int Id_Componente { get; set; }
        public DateTime? Fec_Ingreso { get; set; }
        public string Res_Aprobacion { get; set; }
        [StringLength(1)]
        public string Flg_Estado { get; set; }
        public string Ip_Ingreso { get; set; }
        public int Id_Comp_Est_Amb { get; set; }
        public string Nombre_Documento { get; set; }
        public string Ruta_Documento { get; set; }
        public string Extension { get; set; }
        public int? Tamano { get; set; }
        #endregion
    }
}