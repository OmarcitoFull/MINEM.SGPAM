using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Medicion : BEPaginacion
    {
        #region Propiedades
        public string OBSERVACION { get; set; }  		public string IP_MODIFICA { get; set; }  		public string IP_INGRESO { get; set; }  		public DateTime? FEC_MODIFICA { get; set; }  		public string CONDUCTIVIDAD { get; set; }  		public string USU_MODIFICA { get; set; }  		public string CAUDAL { get; set; }  		public int ID_COMP_MEDICION { get; set; }  		public int PH { get; set; }  		public int ID_COMPONENTE { get; set; }  		public string FLG_ESTADO { get; set; }  		public string USU_INGRESO { get; set; }  		public DateTime? FEC_INGRESO { get; set; }  		public DateTime FECHA_DESICION { get; set; }  		
        #endregion
    }
}