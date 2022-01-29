using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpal_Distrito : BEPaginacion
    {
        #region Propiedades
        public int ID_DISTRITO { get; set; }  		public string IP_MODIFICA { get; set; }  		public DateTime? FEC_MODIFICA { get; set; }  		public string USU_MODIFICA { get; set; }  		public string USU_INGRESO { get; set; }  		public string COD_REFERENCIAL { get; set; }  		public string DESCRIPCION { get; set; }  		public int ID_PROVINCIA { get; set; }  		public string IP_INGRESO { get; set; }  		public DateTime? FEC_INGRESO { get; set; }  		public string FLG_ESTADO { get; set; }  		
        #endregion
    }

	public partial class Ubigeo
	{
		#region Propiedades
		public string ID_REGION { get; set; }
		public string REGION { get; set; }
		public string ID_PROVINCIA { get; set; }
		public string PROVINCIA { get; set; }
		public string ID_DISTRITO { get; set; }
		public string DISTRITO { get; set; }
		#endregion
	}
}