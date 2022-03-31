using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    public class V_Ext_TitularesReferencialesDerechos
    {
        public V_Ext_TitularesReferencialesDerechos()
        {

        }

        public V_Ext_TitularesReferencialesDerechos(IDataReader vRdr)
        {
            if (!Convert.IsDBNull(vRdr["TITULAR_REFERENCIAL"]))
            {
                this.TITULAR_REFERENCIAL = Convert.ToString(vRdr["TITULAR_REFERENCIAL"]);
            }
            if (!Convert.IsDBNull(vRdr["FECHA_INICIO"]))
            {
                this.FECHA_INICIO = Convert.ToDateTime(vRdr["FECHA_INICIO"]);
            }
            if (!Convert.IsDBNull(vRdr["FECHA_FINAL"]))
            {
                this.FECHA_FINAL = Convert.ToDateTime(vRdr["FECHA_FINAL"]);
            }
            if (!Convert.IsDBNull(vRdr["ESTADO"]))
            {
                this.ESTADO = Convert.ToString(vRdr["ESTADO"]);
            }
        }

        public string TITULAR_REFERENCIAL { get; set; }
        public DateTime FECHA_INICIO { get; set; }
        public DateTime? FECHA_FINAL { get; set; }
        public string ESTADO { get; set; }
    }
}
