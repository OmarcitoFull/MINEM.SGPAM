using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Dm_Titular : BEPaginacion
    {
        #region Propiedades
        public int? ID_ESTADO { get; set; }  		public string USU_MODIFICA { get; set; }  		public string FLG_ESTADO { get; set; }  		public string IP_MODIFICA { get; set; }  		public int ID_COMP_DM_TITULAR { get; set; }  		public string USU_INGRESO { get; set; }  		public int ID_COMP_DM { get; set; }  		public DateTime? FEC_MODIFICA { get; set; }  		public int ID_EMPRESA { get; set; }  		public DateTime? FEC_INGRESO { get; set; }  		public DateTime FECHA_INICIO { get; set; }  		public string IP_INGRESO { get; set; }  		public DateTime? FECHA_FIN { get; set; }  		
        #endregion
    }
}