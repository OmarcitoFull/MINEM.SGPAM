using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpam_Visita : BEPaginacion
    {
        #region Propiedades
        public int ID_VISITA { get; set; }
        public string UBIGEO { get; set; }
        public DateTime FECHA_SALIDA { get; set; }
        public DateTime? FECHA_REGRESO { get; set; }

        public string USU_INGRESO { get; set; }
        public DateTime? FEC_INGRESO { get; set; }
        public string IP_INGRESO { get; set; }
        public string USU_MODIFICA { get; set; }
        public DateTime? FEC_MODIFICA { get; set; }
        public string IP_MODIFICA { get; set; }
        public string FLG_ESTADO { get; set; }

        public string MOTIVO { get; set; }
        public string OBSERVACION { get; set; }
        public string DEPARTAMENTO { get; set; }
        public string PROVINCIA { get; set; }
        public string DISTRITO { get; set; }
        public string EUM_DESCRIPCION { get; set; }
        public string NRO_EXPEDIENTE { get; set; }
        public string DECLARANTE { get; set; }
        public string TIEMPO_SIN_VISITA { get; set; }
        #endregion
    }
}