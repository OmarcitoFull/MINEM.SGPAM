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
    public partial class Comp_Riesgo_Sal_AmbDTO : BaseOTD
    {
        #region Propiedades
        public int Id_Comp_Riesgo_Sal_Amb { get; set; }
        public int Id_Componente { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Id_Evidencia_Erosion { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Id_Evidencia_Inundacion { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Id_Potencial_Ard { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Id_Evidencia_Sus_Toxica { get; set; }
        [StringLength(1)]
        public string Flg_Estado { get; set; }
        public string Usu_Modifica { get; set; }
        public string Ip_Ingreso { get; set; }
        public DateTime? Fec_Ingreso { get; set; }
        public string Ip_Modifica { get; set; }
        public DateTime? Fec_Modifica { get; set; }
        public string Usu_Ingreso { get; set; }


        public string Evidencia_Erosion { get; set; }
        public string Evidencia_Inundacion { get; set; }
        public string Potencial_Ard { get; set; }
        public string Evidencia_Sus_Toxica { get; set; }

        public List<Evidencia_ErosionDTO> CboEvidencia_Erosion { get; set; }
        public List<Evidencia_InundacionDTO> CboEvidencia_Inundacion { get; set; }
        public List<Potencial_ArdDTO> CboPotencial_Ard { get; set; }
        public List<Evidencia_Sus_ToxicaDTO> CboEvidencia_Sus_Toxica { get; set; }
        #endregion
    }
}