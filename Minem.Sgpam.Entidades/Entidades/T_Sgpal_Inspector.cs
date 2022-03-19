using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Mateo Salvador Paucar    
    /// Fecha Creación:	20/02/2022
    /// </summary>
    public partial class T_Sgpal_Inspector : BEPaginacion
    {
        #region Propiedades
        public string USU_MODIFICA { get; set; }
        public string IP_INGRESO { get; set; }
        public string NOMBRE { get; set; }
        public string APE_PATERNO { get; set; }
        public string APE_MATERNO { get; set; }
        public int ID_INSPECTOR { get; set; }
        public string USU_INGRESO { get; set; }
        public string IP_MODIFICA { get; set; }
        public DateTime? FEC_INGRESO { get; set; }
        public DateTime? FEC_MODIFICA { get; set; }
        public string FLG_ESTADO { get; set; }

        #endregion
    }
}
