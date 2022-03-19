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
    public partial class Eum_InspeccionDTO : BaseOTD
    {
        #region Propiedades
        public int Id_Inspector { get; set; }  
		public int Id_Eum_Inspeccion { get; set; }  
		public string Usu_Modifica { get; set; }  
		public string Ip_Modifica { get; set; }  
		public int? Id_Tipo_Clima { get; set; }  
        public string Descripcion_Clima  { get; set; }
        public int Id_Eum { get; set; }  
		public string Usu_Ingreso { get; set; }  
		public DateTime? Fec_Ingreso { get; set; }  
		public DateTime Fecha_Inspeccion { get; set; }  
		public DateTime? Fec_Modifica { get; set; }  
		public string Flg_Estado { get; set; }  
		public string Ip_Ingreso { get; set; }


        public List<Tipo_ClimaDTO> CboTipoClima { get; set; }
        public string TipoClima { get; set; }
        public string Nomnbre_Inspector { get; set; }

        #endregion
    }
}