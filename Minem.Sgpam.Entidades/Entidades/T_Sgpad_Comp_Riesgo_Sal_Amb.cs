using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Riesgo_Sal_Amb : BEPaginacion
    {
        #region Propiedades
        public string USU_MODIFICA { get; set; }  		public int ID_COMPONENTE { get; set; }  		public int ID_EVIDENCIA_INUNDACION { get; set; }  		public string IP_INGRESO { get; set; }  		public DateTime? FEC_INGRESO { get; set; }  		public string FLG_ESTADO { get; set; }  		public int ID_POTENCIAL_ARD { get; set; }  		public int ID_EVIDENCIA_EROSION { get; set; }  		public string IP_MODIFICA { get; set; }  		public int ID_EVIDENCIA_SUS_TOXICA { get; set; }  		public DateTime? FEC_MODIFICA { get; set; }  		public string USU_INGRESO { get; set; }  		public int ID_COMP_RIESGO_SAL_AMB { get; set; }  		
        #endregion
    }
}