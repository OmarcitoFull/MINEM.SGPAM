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
    public partial class Comp_Info_CampoDTO : BaseOTD
    {
        #region Propiedades
        [Required]
        public DateTime Fecha_Informe { get; set; }
        public string Ip_Modifica { get; set; }
        public DateTime? Fec_Modifica { get; set; }
        public string Usu_Ingreso { get; set; }
        public string Ip_Ingreso { get; set; }
        public string Usu_Modifica { get; set; }
        [StringLength(1)]
        public string Flg_Estado { get; set; }
        public int Id_Comp_Info_Campo { get; set; }
        public int Id_Componente { get; set; }
        public DateTime? Fec_Ingreso { get; set; }
        [Required]
        [StringLength(100)]
        public string Nro_Informe { get; set; }

        #endregion
    }
}