using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpal_Vegetacion_Invasiva : BEPaginacion
    {
        #region Propiedades
        public string DESCRIPCION { get; set; }  		public DateTime? FEC_INGRESO { get; set; }  		public string IP_INGRESO { get; set; }  		public string USU_MODIFICA { get; set; }  		public string USU_INGRESO { get; set; }  		public int? PESO_ORM { get; set; }  		public int ID_VEGETACION_INVASIVA { get; set; }  		public int? PESO_LB { get; set; }  		public DateTime? FEC_MODIFICA { get; set; }  		public int? PESO_PQ { get; set; }  		public string IP_MODIFICA { get; set; }  		public string FLG_ESTADO { get; set; }  		public int? PESO_I { get; set; }  		public int? PESO_RM { get; set; }  		
        #endregion
    }
}