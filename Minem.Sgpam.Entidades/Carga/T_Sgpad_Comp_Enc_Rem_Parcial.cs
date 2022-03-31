using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Enc_Rem
    {
        public T_Sgpad_Comp_Enc_Rem()
        {

        }

        public T_Sgpad_Comp_Enc_Rem(IDataReader vRdr)
        {
            this.NRO_REMEDIACION = Convert.ToString(vRdr["NRO_REMEDIACION"]);
            this.RESOLUCION_EXC_ENC = Convert.ToString(vRdr["RESOLUCION_EXC_ENC"]);
            this.ANIO_RESOLUCION = Convert.ToInt32(vRdr["ANIO_RESOLUCION"]);
            this.ID_TIPO_ENCARGO = Convert.ToInt32(vRdr["ID_TIPO_ENCARGO"]);
            this.ID_TIPO_RESOLUCION = Convert.ToInt32(vRdr["ID_TIPO_RESOLUCION"]);
            this.ID_COMP_ENC_REM = Convert.ToInt32(vRdr["ID_COMP_ENC_REM"]);

            if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))
            {
                this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);
            }
            this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);

            if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))
            {
                this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);
            }

            if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))
            {
                this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);
            }
            this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);
            this.RESPONSABLE_REMEDIACION = Convert.ToString(vRdr["RESPONSABLE_REMEDIACION"]);

            if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))
            {
                this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);
            }

            if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))
            {
                this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);
            }

            if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))
            {
                this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);
            }
            if (!Convert.IsDBNull(vRdr["RESOLUCION_ENGARGO"]))
            {
                this.RESOLUCION_ENGARGO = Convert.ToString(vRdr["RESOLUCION_ENGARGO"]);
            }
        }
    }
}