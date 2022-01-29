using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    public class V_Sgpad_Comp_Reconocimiento: T_Sgpad_Comp_Reconocimiento
    {
        public V_Sgpad_Comp_Reconocimiento()
        {

        }

		public V_Sgpad_Comp_Reconocimiento(IDataReader vRdr)
		{

			if (!Convert.IsDBNull(vRdr["ALTURA"]))
			{
				this.ALTURA = Convert.ToInt32(vRdr["ALTURA"]);
			}
			this.ID_TIPO_RECONOCIMIENTO = Convert.ToInt32(vRdr["ID_TIPO_RECONOCIMIENTO"]);

			if (!Convert.IsDBNull(vRdr["BASE"]))
			{
				this.BASE = Convert.ToInt32(vRdr["BASE"]);
			}
			this.ID_COMP_RECONOCIMIENTO = Convert.ToInt32(vRdr["ID_COMP_RECONOCIMIENTO"]);

			if (!Convert.IsDBNull(vRdr["ANCHO"]))
			{
				this.ANCHO = Convert.ToInt32(vRdr["ANCHO"]);
			}

			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))
			{
				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);
			}

			if (!Convert.IsDBNull(vRdr["ID_TIPO_MINERIA"]))
			{
				this.ID_TIPO_MINERIA = Convert.ToInt32(vRdr["ID_TIPO_MINERIA"]);
			}
			this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);

			if (!Convert.IsDBNull(vRdr["VOLUMEN"]))
			{
				this.VOLUMEN = Convert.ToInt32(vRdr["VOLUMEN"]);
			}

			if (!Convert.IsDBNull(vRdr["LARGO"]))
			{
				this.LARGO = Convert.ToInt32(vRdr["LARGO"]);
			}

			if (!Convert.IsDBNull(vRdr["CANTIDAD"]))
			{
				this.CANTIDAD = Convert.ToInt32(vRdr["CANTIDAD"]);
			}

			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))
			{
				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);
			}
			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);

			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))
			{
				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);
			}

			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))
			{
				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);
			}

			if (!Convert.IsDBNull(vRdr["PROFUNDIDAD"]))
			{
				this.PROFUNDIDAD = Convert.ToInt32(vRdr["PROFUNDIDAD"]);
			}

			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))
			{
				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);
			}

			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))
			{
				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);
			}

			if (!Convert.IsDBNull(vRdr["AREA"]))
			{
				this.AREA = Convert.ToInt32(vRdr["AREA"]);
			}

			if (!Convert.IsDBNull(vRdr["DESCRIPCION"]))
			{
				this.DESCRIPCION = Convert.ToString(vRdr["DESCRIPCION"]);
			}

		}

		public string DESCRIPCION { get; set; }
    }
}
