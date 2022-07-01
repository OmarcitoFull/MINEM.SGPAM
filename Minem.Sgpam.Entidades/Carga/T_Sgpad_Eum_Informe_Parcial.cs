using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Eum_Informe
    {
        public T_Sgpad_Eum_Informe()
        {

        }

        public T_Sgpad_Eum_Informe(IDataReader vRdr)
        {
            this.NRO_EXPEDIENTE = Convert.ToString(vRdr["NRO_EXPEDIENTE"]);

            if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))
            {
                this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);
            }
            this.ID_EUM = Convert.ToInt32(vRdr["ID_EUM"]);

            if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))
            {
                this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);
            }

            if (!Convert.IsDBNull(vRdr["FECHA_INFORME"]))
            {
                this.FECHA_INFORME = Convert.ToDateTime(vRdr["FECHA_INFORME"]);
            }
            this.NRO_INFORME = Convert.ToString(vRdr["NRO_INFORME"]);
            this.DESCRIPCION = Convert.ToString(vRdr["DESCRIPCION"]);
            this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);

            if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))
            {
                this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);
            }

            if (!Convert.IsDBNull(vRdr["TAMANO"]))
            {
                this.TAMANO = Convert.ToInt32(vRdr["TAMANO"]);
            }

            if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))
            {
                this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);
            }
            this.NOMBRE_INFORME = Convert.ToString(vRdr["NOMBRE_INFORME"]);
            this.ID_EUM_INFORME = Convert.ToInt32(vRdr["ID_EUM_INFORME"]);

            if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))
            {
                this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);
            }

            if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))
            {
                this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);
            }
            this.RUTA_INFORME = Convert.ToString(vRdr["RUTA_INFORME"]);

        }
    }
}