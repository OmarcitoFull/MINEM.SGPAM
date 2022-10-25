using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpad_Lnr : BEPaginacion
    {
		#region Propiedades
		public int ID_LNR { get; set; }
		public int ID_EXPEDIENTE { get; set; }
		public string NRO_EXPEDIENTE { get; set; }
		public string CODIGO_DECLARADO { get; set; }
		public int ID_TIPO_LNR { get; set; }
		public int ID_SUB_TIPO_LNR { get; set; }
		public string SUB_TIPO_DECLARADO { get; set; }
		public decimal ESTE { get; set; }
		public decimal NORTE { get; set; }
		public int ID_ZONA { get; set; }
		public string UBIGEO { get; set; }
		public string NOM_DECLARANTE { get; set; }
		public int? VOLUMEN { get; set; }
		public string VOLUMEN_DESC { get; set; }
		public int? PROFUNDIDAD { get; set; }
		public string PROFUNDIDAD_DESC { get; set; }
		public int? ANCHO { get; set; }
		public string ANCHO_DESC { get; set; }
		public int? ALTO { get; set; }
		public string ALTO_DESC { get; set; }
		public int? AREA { get; set; }
		public string AREA_DESC { get; set; }
		public int? LARGO { get; set; }
		public string LARGO_DESC { get; set; }  		public string EVA_GENERADOR { get; set; }  		public string EVA_MATERIAL { get; set; }
		public string EVA_RESTOS { get; set; }
		public string EVA_CAIDA { get; set; }
		public string EVA_EVIDENCIA { get; set; }
		public string EVA_ELEMENTO { get; set; }  		public string EVA_DRENAJES { get; set; }  		public string EVA_ELEMENTOS { get; set; }  		public string EVA_AFECTACION { get; set; }  		public string EVA_POSIBILIDAD { get; set; }  		public string EVA_POTENCIAL { get; set; }  		public string EVA_LABOR { get; set; }  		public int ID_TEMPORALIDAD { get; set; }  		public DateTime FEC_REGISTRO { get; set; }
		public string USU_INGRESO { get; set; }
		public DateTime? FEC_INGRESO { get; set; }
		public string IP_INGRESO { get; set; }
		public string USU_MODIFICA { get; set; }
		public DateTime? FEC_MODIFICA { get; set; }
		public string IP_MODIFICA { get; set; }
		public string FLG_ESTADO { get; set; }  
			
		public string DES_TIPO_LNR { get; set; }
		public string REGION { get; set; }
		public string PROVINCIA { get; set; }
		public string DISTRITO { get; set; }

		#endregion
	}
}