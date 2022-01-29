using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpah_Eum_Mod : BEPaginacion
    {
        #region Propiedades
        public int ID_EUM { get; set; }  
		public DateTime? FEC_INGRESO { get; set; }  
		public string USU_INGRESO { get; set; }  
		public string CARGO { get; set; }  
		public int ID_EUM_MOD { get; set; }  
		public string FLG_ESTADO { get; set; }  
		public string IP_INGRESO { get; set; }  
		
        #endregion
    }
}