using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpal_Distrito
    {
        public T_Sgpal_Distrito()
        {

        }

        public T_Sgpal_Distrito(IDataReader vRdr)
        {
            this.ID_DISTRITO = Convert.ToInt32(vRdr["ID_DISTRITO"]);

            if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))
            {
                this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);
            }

            if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))
            {
                this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);
            }

            if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))
            {
                this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);
            }

            if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))
            {
                this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);
            }
            this.COD_REFERENCIAL = Convert.ToString(vRdr["COD_REFERENCIAL"]);
            this.DESCRIPCION = Convert.ToString(vRdr["DESCRIPCION"]);
            this.ID_PROVINCIA = Convert.ToInt32(vRdr["ID_PROVINCIA"]);

            if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))
            {
                this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);
            }

            if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))
            {
                this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);
            }
            this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);

        }
    }


    public partial class Ubigeo
    {
        public Ubigeo()
        {

        }

        public Ubigeo(IDataReader vRdr)
        {
            this.ID_REGION = Convert.ToString(vRdr["ID_REGION"]);
            this.REGION = Convert.ToString(vRdr["REGION"]);
            this.ID_PROVINCIA = Convert.ToString(vRdr["ID_PROVINCIA"]);
            this.PROVINCIA = Convert.ToString(vRdr["PROVINCIA"]);
            this.ID_DISTRITO = Convert.ToString(vRdr["ID_DISTRITO"]);
            this.DISTRITO = Convert.ToString(vRdr["DISTRITO"]);
        }
    }
}