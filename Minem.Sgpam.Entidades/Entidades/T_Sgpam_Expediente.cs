using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpam_Expediente : BEPaginacion
    {
        #region Propiedades
        public int ID_EXPEDIENTE { get; set; }
		public string NRO_EXPEDIENTE { get; set; }  		public string ZONA { get; set; }
        public string DECLARANTE { get; set; }
        public string USU_INGRESO { get; set; }
        public DateTime? FEC_INGRESO { get; set; }
        public string IP_INGRESO { get; set; }
        public string USU_MODIFICA { get; set; }
        public DateTime? FEC_MODIFICA { get; set; }
        public string IP_MODIFICA { get; set; }
        public string FLG_ESTADO { get; set; }

        public int TOTAL_LNR { get; set; }
        public string NRO_INFORME { get; set; }
        //public string REGION { get; set; }
        //public string PROVINCIA { get; set; }
        //public string DISTRITO { get; set; }

        #endregion
    }
}