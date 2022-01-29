using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Resultado 
    { 
        public T_Sgpad_Comp_Resultado()
        {

        }

        public T_Sgpad_Comp_Resultado(IDataReader vRdr)
        {
            			if (!Convert.IsDBNull(vRdr["ACT_SGP_DESCRIPCION"]))  			{				this.ACT_SGP_DESCRIPCION = Convert.ToString(vRdr["ACT_SGP_DESCRIPCION"]);  			}			if (!Convert.IsDBNull(vRdr["ACT_INV_REGION"]))  			{				this.ACT_INV_REGION = Convert.ToString(vRdr["ACT_INV_REGION"]);  			}			if (!Convert.IsDBNull(vRdr["ACT_INV_SUB_TIPO"]))  			{				this.ACT_INV_SUB_TIPO = Convert.ToString(vRdr["ACT_INV_SUB_TIPO"]);  			}			if (!Convert.IsDBNull(vRdr["EXC_OTROS"]))  			{				this.EXC_OTROS = Convert.ToString(vRdr["EXC_OTROS"]);  			}			this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);  
			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  
			if (!Convert.IsDBNull(vRdr["ACT_SGP_PH"]))  			{				this.ACT_SGP_PH = Convert.ToString(vRdr["ACT_SGP_PH"]);  			}			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))  			{				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))  			{				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["ACT_INV_GENERADOR"]))  			{				this.ACT_INV_GENERADOR = Convert.ToString(vRdr["ACT_INV_GENERADOR"]);  			}			if (!Convert.IsDBNull(vRdr["ACT_INV_EUM"]))  			{				this.ACT_INV_EUM = Convert.ToString(vRdr["ACT_INV_EUM"]);  			}			if (!Convert.IsDBNull(vRdr["EXC_NO_SIG_RIE"]))  			{				this.EXC_NO_SIG_RIE = Convert.ToString(vRdr["EXC_NO_SIG_RIE"]);  			}			if (!Convert.IsDBNull(vRdr["ACT_INV_RES_REMEDIA"]))  			{				this.ACT_INV_RES_REMEDIA = Convert.ToString(vRdr["ACT_INV_RES_REMEDIA"]);  			}			if (!Convert.IsDBNull(vRdr["INC_INVENTARIO"]))  			{				this.INC_INVENTARIO = Convert.ToString(vRdr["INC_INVENTARIO"]);  			}			if (!Convert.IsDBNull(vRdr["ACT_INV_COORDENADAS"]))  			{				this.ACT_INV_COORDENADAS = Convert.ToString(vRdr["ACT_INV_COORDENADAS"]);  			}			if (!Convert.IsDBNull(vRdr["ACT_SGP_CONDICIONES"]))  			{				this.ACT_SGP_CONDICIONES = Convert.ToString(vRdr["ACT_SGP_CONDICIONES"]);  			}			if (!Convert.IsDBNull(vRdr["ACT_INV_PROVINCIA"]))  			{				this.ACT_INV_PROVINCIA = Convert.ToString(vRdr["ACT_INV_PROVINCIA"]);  			}			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))  			{				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))  			{				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["ACT_INV_DISTRITO"]))  			{				this.ACT_INV_DISTRITO = Convert.ToString(vRdr["ACT_INV_DISTRITO"]);  			}			if (!Convert.IsDBNull(vRdr["EXC_NO_EXI_PAM"]))  			{				this.EXC_NO_EXI_PAM = Convert.ToString(vRdr["EXC_NO_EXI_PAM"]);  			}			this.ID_COMP_RESULTADO = Convert.ToInt32(vRdr["ID_COMP_RESULTADO"]);  
			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))  			{				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["ACT_SGP_Q"]))  			{				this.ACT_SGP_Q = Convert.ToString(vRdr["ACT_SGP_Q"]);  			}			if (!Convert.IsDBNull(vRdr["ACT_INV_CUENCA"]))  			{				this.ACT_INV_CUENCA = Convert.ToString(vRdr["ACT_INV_CUENCA"]);  			}			if (!Convert.IsDBNull(vRdr["ACT_SGP_AREAS"]))  			{				this.ACT_SGP_AREAS = Convert.ToString(vRdr["ACT_SGP_AREAS"]);  			}			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))  			{				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["EXC_PAM_INF_DUP"]))  			{				this.EXC_PAM_INF_DUP = Convert.ToString(vRdr["EXC_PAM_INF_DUP"]);  			}			if (!Convert.IsDBNull(vRdr["EXC_AGR_PAM_ID"]))  			{				this.EXC_AGR_PAM_ID = Convert.ToString(vRdr["EXC_AGR_PAM_ID"]);  			}
        }
    }
}