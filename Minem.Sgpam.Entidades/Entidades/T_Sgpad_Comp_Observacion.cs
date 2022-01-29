using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Observacion : BEPaginacion
    {
        #region Propiedades
        public DateTime FECHA { get; set; }  		public string IP_INGRESO { get; set; }  		public DateTime? FEC_MODIFICA { get; set; }  		public string USU_MODIFICA { get; set; }  		public string SUELOS_DISTURBADOS { get; set; }  		public int ID_COMP_OBSERVACION { get; set; }  		public string DESCRIPCION_COMP { get; set; }  		public string USU_INGRESO { get; set; }  		public DateTime? FEC_INGRESO { get; set; }  		public string OBRAS_REHABILITACION { get; set; }  		public int ID_COMPONENTE { get; set; }  		public string IP_MODIFICA { get; set; }  		public string FLG_ESTADO { get; set; }  		
        #endregion
    }
}