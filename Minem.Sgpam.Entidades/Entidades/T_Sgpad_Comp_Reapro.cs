using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Reapro : BEPaginacion
    {
        #region Propiedades
        public string NOMBRE_PROYECTO { get; set; }  		public string IP_INGRESO { get; set; }  		public DateTime? FECHA_EXPEDIENTE { get; set; }  		public string FLG_ESTADO { get; set; }  		public DateTime? FECHA_RESOLUCION { get; set; }  		public DateTime? FEC_MODIFICA { get; set; }  		public string NRO_EXPEDIENTE { get; set; }  		public int ID_COMP_REAPRO { get; set; }  		public int ID_COMPONENTE { get; set; }  		public string USU_INGRESO { get; set; }  		public string IP_MODIFICA { get; set; }  		public string USU_MODIFICA { get; set; }  		public DateTime? FEC_INGRESO { get; set; }  		public string RESOLUCION_REAPRO { get; set; }
		public string TITULAR { get; set; }
		#endregion
	}
}