using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpah_Componente_Mod : BEPaginacion
    {
        #region Propiedades
        public DateTime? FEC_INGRESO { get; set; }  		public string IP_INGRESO { get; set; }  		public string USU_INGRESO { get; set; }  		public string FLG_ESTADO { get; set; }  		public int ID_COMPONENTE_MOD { get; set; }  		public int ID_COMPONENTE { get; set; }  		public string CARGO { get; set; }  		
        #endregion
    }
}