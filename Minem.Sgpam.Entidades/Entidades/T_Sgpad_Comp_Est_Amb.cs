using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Est_Amb : BEPaginacion
    {
        #region Propiedades
        public DateTime? FEC_MODIFICA { get; set; }  		public string USU_MODIFICA { get; set; }  		public string TIPO_ESTUDIO { get; set; }  		public string USU_INGRESO { get; set; }  		public DateTime? FEC_RESOLUCION { get; set; }  		public string NRO_EXPEDIENTE { get; set; }  		public string DES_NOM_TITULAR { get; set; }  		public string IP_MODIFICA { get; set; }  		public string DES_NOM_PROYECTO { get; set; }  		public string DES_UND_AMBIENTAL { get; set; }  		public DateTime? FEC_EXPEDIENTE { get; set; }  		public string DES_SITUACION { get; set; }  		public int ID_COMPONENTE { get; set; }  		public DateTime? FEC_INGRESO { get; set; }  		public string RES_APROBACION { get; set; }  		public string FLG_ESTADO { get; set; }  		public string IP_INGRESO { get; set; }  		public int ID_COMP_EST_AMB { get; set; }  		
        #endregion
    }
}