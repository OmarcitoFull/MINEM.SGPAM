using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Riesgo_Fau_Con : BEPaginacion
    {
        #region Propiedades
        public DateTime? FEC_MODIFICA { get; set; }  		public int ID_SENSIBILIDAD_AREA { get; set; }  		public int ID_COMP_RIESGO_FAU_CON { get; set; }  		public int ID_ACCESO_FAUNA { get; set; }  		public string IP_MODIFICA { get; set; }  		public DateTime? FEC_INGRESO { get; set; }  		public int ID_VEGETACION_INVASIVA { get; set; }  		public int ID_ATRACCION_FAUNA { get; set; }  		public string USU_MODIFICA { get; set; }  		public string USU_INGRESO { get; set; }  		public string FLG_ESTADO { get; set; }  		public int ID_CERCA_AREA_PROTEGIDA { get; set; }  		public int ID_AGUA_CONTAMINADA { get; set; }  		public string IP_INGRESO { get; set; }  		public int ID_COMPONENTE { get; set; }  		
        #endregion
    }
}