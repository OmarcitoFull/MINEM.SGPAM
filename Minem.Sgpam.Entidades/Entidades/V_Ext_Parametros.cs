using System;

namespace Minem.Sgpam.Entidades
{
    public class V_Ext_Parametros
    {
        public V_Ext_Parametros()
        {

        }

        public int ID_COMPONENTE { get; set; }
        public int? ID_ZONA { get; set; }
        public string ID_DATUM { get; set; }
        public decimal? ESTE { get; set; }
        public decimal? NORTE { get; set; }
        public string UBIGEO { get; set; }
        public string USU_INGRESO { get; set; }
        public DateTime? FEC_INGRESO { get; set; }
        public string IP_INGRESO { get; set; }
        public int ID_COMP_DM { get; set; }
    }
}
