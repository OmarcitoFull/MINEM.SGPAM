using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpad_Eum_Info_Grafica : BEPaginacion
    {
        #region Propiedades
		public int ID_EUM_INFO_GRAFICA { get; set; }
		public int ID_EUM { get; set; }




		public string DESCRIPCION { get; set; }
		public DateTime? FECHA_TOMA { get; set; }
		public string NOMBRE_IMAGEN { get; set; }
		public string RUTA_IMAGEN { get; set; }
		public string EXTENCION { get; set; }
		public int? TAMANO { get; set; }
		public long? ID_LASERFICHE { get; set; }
		public string USU_INGRESO { get; set; }
		public DateTime? FEC_INGRESO { get; set; }
		public string IP_INGRESO { get; set; }
		public string USU_MODIFICA { get; set; }
		public DateTime? FEC_MODIFICA { get; set; }
		public string IP_MODIFICA { get; set; }
		public string FLG_ESTADO { get; set; }  
		#endregion
	}
}