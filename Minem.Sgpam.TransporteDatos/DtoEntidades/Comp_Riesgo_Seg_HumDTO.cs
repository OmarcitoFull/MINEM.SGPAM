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
    public partial class Comp_Riesgo_Seg_HumDTO : BaseOTD
    {
        #region Propiedades
        public int Id_Comp_Riesgo_Seg_Hum { get; set; }
        public int Id_Componente { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Id_Accesibilidad { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Id_Pot_Colapso { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Id_Condicion_Cierre { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Id_Presencia_Elemento { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Id_Hundimiento { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Id_Pot_Caida_Persona { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Id_Presencia_Advertencia { get; set; }
        [StringLength(1)]
        public string Flg_Estado { get; set; }
        public DateTime? Fec_Ingreso { get; set; }
        public string Ip_Modifica { get; set; }
        public string Ip_Ingreso { get; set; }
        public string Usu_Modifica { get; set; }
        public string Usu_Ingreso { get; set; }
        public DateTime? Fec_Modifica { get; set; }



        public List<AccesibilidadDTO> CboAccesibilidad { get; set; }
        public List<Pot_ColapsoDTO> CboPotenciaColapso { get; set; }
        public List<Condicion_CierreDTO> CboCondicionCierre { get; set; }
        public List<Presencia_ElementoDTO> CboPresenciaSeniales { get; set; }
        public List<HundimientoDTO> CboHundimiento { get; set; }
        public List<Pot_Caida_PersonaDTO> CboPotenciaDanio { get; set; }
        public List<Presencia_AdvertenciaDTO> CboPresenciaEscombros { get; set; }
        public string Accesibilidad { get; set; }
        public string Pot_Colapso { get; set; }
        public string Condicion_Cierre { get; set; }
        public string Presencia_Elemento { get; set; }
        public string Hundimiento { get; set; }
        public string Pot_Caida_Persona { get; set; }
        public string Presencia_Advertencia { get; set; }
        #endregion
    }
}