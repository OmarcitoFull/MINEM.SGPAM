using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpam_Expediente
    {
        public T_Sgpam_Expediente()
        {

        }

        public T_Sgpam_Expediente(IDataReader vRdr)
        {

            this.ID_EXPEDIENTE = Convert.ToInt32(vRdr["ID_EXPEDIENTE"]);
            this.NRO_EXPEDIENTE = Convert.ToString(vRdr["NRO_EXPEDIENTE"]);
            if (!Convert.IsDBNull(vRdr["ZONA"]))
            {
                this.ZONA = Convert.ToString(vRdr["ZONA"]);
            }
            if (!Convert.IsDBNull(vRdr["DECLARANTE"]))
            {
                this.DECLARANTE = Convert.ToString(vRdr["DECLARANTE"]);
            }

            if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))
            {
                this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);
            }
            if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))
            {
                this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);
            }
            if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))
            {
                this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);
            }
            if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))
            {
                this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);
            }
            if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))
            {
                this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);
            }
            if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))
            {
                this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);
            }
            this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);


            if (!Convert.IsDBNull(vRdr["TOTAL_LNR"]))
            {
                this.TOTAL_LNR = Convert.ToInt32(vRdr["TOTAL_LNR"]);
            }
            if (!Convert.IsDBNull(vRdr["NRO_INFORME"]))
            {
                this.NRO_INFORME = Convert.ToString(vRdr["NRO_INFORME"]);
            }

        }
    }
}