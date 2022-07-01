using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpaj_Visita_Det
    {
        public T_Sgpaj_Visita_Det()
        {

        }

        public T_Sgpaj_Visita_Det(IDataReader vRdr)
        {
            this.ID_VISITA_DET = Convert.ToInt32(vRdr["ID_VISITA_DET"]);
            this.ID_VISITA = Convert.ToInt32(vRdr["ID_VISITA"]);
            this.ID_TIPO_REGISTRO = Convert.ToInt32(vRdr["ID_TIPO_REGISTRO"]);
            if (!Convert.IsDBNull(vRdr["ID_EUM"]))
            {
                this.ID_EUM = Convert.ToInt32(vRdr["ID_EUM"]);
            }
            if (!Convert.IsDBNull(vRdr["ID_EXPEDIENTE"]))
            {
                this.ID_EXPEDIENTE = Convert.ToInt32(vRdr["ID_EXPEDIENTE"]);
            }
            if (!Convert.IsDBNull(vRdr["MOTIVO"]))
            {
                this.MOTIVO = Convert.ToString(vRdr["MOTIVO"]);
            }
            if (!Convert.IsDBNull(vRdr["OBSERVACION"]))
            {
                this.OBSERVACION = Convert.ToString(vRdr["OBSERVACION"]);
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


            if (!Convert.IsDBNull(vRdr["TIPO_REGISTRO"]))
            {
                this.TIPO_REGISTRO = Convert.ToString(vRdr["TIPO_REGISTRO"]);
            }
            if (!Convert.IsDBNull(vRdr["NOMBRE_EUM"]))
            {
                this.NOMBRE_EUM = Convert.ToString(vRdr["NOMBRE_EUM"]);
            }
            if (!Convert.IsDBNull(vRdr["NRO_EXPEDIENTE"]))
            {
                this.NRO_EXPEDIENTE = Convert.ToString(vRdr["NRO_EXPEDIENTE"]);
            }

        }
    }
}