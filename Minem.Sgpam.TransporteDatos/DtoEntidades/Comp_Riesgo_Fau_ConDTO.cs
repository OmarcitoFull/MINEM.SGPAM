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
    public partial class Comp_Riesgo_Fau_ConDTO : BaseOTD
    {
        #region Propiedades
        public int Id_Comp_Riesgo_Fau_Con { get; set; }
        public int Id_Componente { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Id_Acceso_Fauna { get; set; }
        [Required]
        [Range(1, int.MaxValue)] 
        public int Id_Atraccion_Fauna { get; set; }
        [Required]
        [Range(1, int.MaxValue)] 
        public int Id_Vegetacion_Invasiva { get; set; }
        [Required]
        [Range(1, int.MaxValue)] 
        public int Id_Cerca_Area_Protegida { get; set; }
        [Required]
        [Range(1, int.MaxValue)] 
        public int Id_Sensibilidad_Area { get; set; }
        [Required]
        [Range(1, int.MaxValue)] 
        public int Id_Agua_Contaminada { get; set; }
        [StringLength(1)] 
        public string Flg_Estado { get; set; }

        public DateTime? Fec_Modifica { get; set; }
        public string Ip_Modifica { get; set; }
        public DateTime? Fec_Ingreso { get; set; }
        public string Usu_Modifica { get; set; }
        public string Usu_Ingreso { get; set; }
        public string Ip_Ingreso { get; set; }


        public string Acceso_Fauna { get; set; }
        public string Atraccion_Fauna { get; set; }
        public string Vegetacion_Invasiva { get; set; }
        public string Cerca_Area_Protegida { get; set; }
        public string Sensibilidad_Area { get; set; }
        public string Agua_Contaminada { get; set; }

        public List<Acceso_FaunaDTO> CboAcceso_Fauna { get; set; }
        public List<Atraccion_FaunaDTO> CboAtraccion_Fauna { get; set; }
        public List<Vegetacion_InvasivaDTO> CboVegetacion_Invasiva { get; set; }
        public List<Cerca_Area_ProtegidaDTO> CboCerca_Area_Protegida { get; set; }
        public List<Sensibilidad_AreaDTO> CboSensibilidad_Area { get; set; }
        public List<Agua_ContaminadaDTO> CboAgua_Contaminada { get; set; }
        #endregion
    }
}