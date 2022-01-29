using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpad_Eum_Ubicacion : BEPaginacion
    {
        #region Propiedades
        public DateTime? FEC_INGRESO { get; set; }  		public string PARAJE { get; set; }  		public int ID_CUENCA_PRINCIPAL { get; set; }  		public int? ID_CUENCA_SECUNDARIA { get; set; }  		public DateTime? FEC_MODIFICA { get; set; }  		public int ID_EUM_UBICACION { get; set; }  		public string REFERENCIA { get; set; }  		public string IP_MODIFICA { get; set; }  		public string IP_INGRESO { get; set; }  		public string USU_MODIFICA { get; set; }  		public int ID_EUM { get; set; }  		public string UBIGEO { get; set; }  		public string USU_INGRESO { get; set; }  		public string FLG_ESTADO { get; set; }  		
        #endregion
    }
}