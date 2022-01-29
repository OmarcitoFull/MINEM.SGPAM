using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Reconocimiento : BEPaginacion
    {
        #region Propiedades
        public int? ALTURA { get; set; }  		public int ID_TIPO_RECONOCIMIENTO { get; set; }  		public int? BASE { get; set; }  		public int ID_COMP_RECONOCIMIENTO { get; set; }  		public int? ANCHO { get; set; }  		public string USU_INGRESO { get; set; }  		public int? ID_TIPO_MINERIA { get; set; }  		public int ID_COMPONENTE { get; set; }  		public int? VOLUMEN { get; set; }  		public int? LARGO { get; set; }  		public int? CANTIDAD { get; set; }  		public string IP_MODIFICA { get; set; }  		public string FLG_ESTADO { get; set; }  		public DateTime? FEC_MODIFICA { get; set; }  		public string IP_INGRESO { get; set; }  		public int? PROFUNDIDAD { get; set; }  		public string USU_MODIFICA { get; set; }  		public DateTime? FEC_INGRESO { get; set; }  		public int? AREA { get; set; }  		
        #endregion
    }
}