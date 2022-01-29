using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Resultado : BEPaginacion
    {
        #region Propiedades
        public string ACT_SGP_DESCRIPCION { get; set; }  		public string ACT_INV_REGION { get; set; }  		public string ACT_INV_SUB_TIPO { get; set; }  		public string EXC_OTROS { get; set; }  		public int ID_COMPONENTE { get; set; }  		public string FLG_ESTADO { get; set; }  		public string ACT_SGP_PH { get; set; }  		public string USU_INGRESO { get; set; }  		public string IP_MODIFICA { get; set; }  		public string ACT_INV_GENERADOR { get; set; }  		public string ACT_INV_EUM { get; set; }  		public string EXC_NO_SIG_RIE { get; set; }  		public string ACT_INV_RES_REMEDIA { get; set; }  		public string INC_INVENTARIO { get; set; }  		public string ACT_INV_COORDENADAS { get; set; }  		public string ACT_SGP_CONDICIONES { get; set; }  		public string ACT_INV_PROVINCIA { get; set; }  		public DateTime? FEC_MODIFICA { get; set; }  		public string IP_INGRESO { get; set; }  		public string ACT_INV_DISTRITO { get; set; }  		public string EXC_NO_EXI_PAM { get; set; }  		public int ID_COMP_RESULTADO { get; set; }  		public DateTime? FEC_INGRESO { get; set; }  		public string ACT_SGP_Q { get; set; }  		public string ACT_INV_CUENCA { get; set; }  		public string ACT_SGP_AREAS { get; set; }  		public string USU_MODIFICA { get; set; }  		public string EXC_PAM_INF_DUP { get; set; }  		public string EXC_AGR_PAM_ID { get; set; }  		
        #endregion
    }
}