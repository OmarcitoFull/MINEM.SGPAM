using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Riesgo_Seg_Hum : BEPaginacion
    {
        #region Propiedades
        public int ID_COMP_RIESGO_SEG_HUM { get; set; }  		public DateTime? FEC_INGRESO { get; set; }  		public int ID_PRESENCIA_ADVERTENCIA { get; set; }  		public string FLG_ESTADO { get; set; }  		public int ID_COMPONENTE { get; set; }  		public string IP_MODIFICA { get; set; }  		public string IP_INGRESO { get; set; }  		public string USU_MODIFICA { get; set; }  		public int ID_HUNDIMIENTO { get; set; }  		public string USU_INGRESO { get; set; }  		public int ID_POT_COLAPSO { get; set; }  		public int ID_POT_CAIDA_PERSONA { get; set; }  		public int ID_CONDICION_CIERRE { get; set; }  		public int ID_PRESENCIA_ELEMENTO { get; set; }  		public DateTime? FEC_MODIFICA { get; set; }  		public int ID_ACCESIBILIDAD { get; set; }  		
        #endregion
    }
}