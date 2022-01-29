using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    public class V_Sgpad_Comp_Est_Gestion: T_Sgpad_Comp_Est_Gestion
    {

        public V_Sgpad_Comp_Est_Gestion()
        {

        }

        public V_Sgpad_Comp_Est_Gestion(IDataReader vRdr)
        {
            this.ID_COMP_EST_GESTION = Convert.ToInt32(vRdr["ID_COMP_EST_GESTION"]);

            if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))
            {
                this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);
            }

            if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))
            {
                this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);
            }

            if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))
            {
                this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);
            }

            if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))
            {
                this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);
            }

            if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))
            {
                this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);
            }
            this.ID_ESTADO_GESTION = Convert.ToInt32(vRdr["ID_ESTADO_GESTION"]);
            this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);

            if (!Convert.IsDBNull(vRdr["FECHA"]))
            {
                this.FECHA = Convert.ToDateTime(vRdr["FECHA"]);
            }

            if (!Convert.IsDBNull(vRdr["SUSTENTO"]))
            {
                this.SUSTENTO = Convert.ToString(vRdr["SUSTENTO"]);
            }

            if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))
            {
                this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);
            }
            
            this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);

            if (!Convert.IsDBNull(vRdr["DESCRIPCION"]))
            {
                this.DESCRIPCION = Convert.ToString(vRdr["DESCRIPCION"]);
            }
        }


        public string DESCRIPCION { get; set; }
    }
}
