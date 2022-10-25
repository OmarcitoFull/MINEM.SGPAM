using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpam_Maestra : BEPaginacion
    {
		#region Propiedades
		public int ID_EUM { get; set; }
		public string EUM_DESCRIPCION { get; set; }
		public string ACCESO_EUM { get; set; }
		public string HISTORIA_EUM { get; set; }
		public string EVIDENCIA_ACT_REC { get; set; }
		public int? ID_TIPO_OPERACION { get; set; }
		public int ID_TIPO_SUSTANCIA { get; set; }
		public string RELIEVE { get; set; }
		public string CUERPOS_AGUA { get; set; }
		public string FLORA_TERRESTRE { get; set; }
		public string FAUNA_TERRESTE { get; set; }
		public string FLORA_FAUNA_ACUATICA { get; set; }
		public string INFRA_URBANA { get; set; }
		public string USO_SUELO { get; set; }
		public string USO_AGUA { get; set; }
		public string AREA_CONSERVACION { get; set; }
		public string SITIO_ARQUE_TURISTICO { get; set; }
		public int ID_CONFLICTO_SOCIAL { get; set; }
		public string CONFLICTO_SOCIAL { get; set; }
		public string DESCRIPCION_EUM { get; set; }
		public string COMENTARIO_ADI { get; set; }
		public int? NUM_EUM { get; set; }
		public int? ID_ESTADO_REGISTRO { get; set; }
		public string USU_INGRESO { get; set; }
		public DateTime? FEC_INGRESO { get; set; }
		public string IP_INGRESO { get; set; }
		public string USU_MODIFICA { get; set; }
		public DateTime? FEC_MODIFICA { get; set; }
		public string IP_MODIFICA { get; set; }
		public string FLG_ESTADO { get; set; }

		public DateTime? ULT_VISITA { get; set; }
		public DateTime? FECHA_INFORME { get; set; }
		public string NRO_INFORME { get; set; }
		public string REGION { get; set; }
		public string PROVINCIA { get; set; }
		public string DISTRITO { get; set; }
		#endregion
	}
}