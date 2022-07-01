using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Lnr_Info_Documento 
    { 
        public T_Sgpad_Lnr_Info_Documento()
        {

        }

        public T_Sgpad_Lnr_Info_Documento(IDataReader vRdr)
        {
			this.ID_LNR_INFO_DOCUMENTO = Convert.ToInt32(vRdr["ID_LNR_INFO_DOCUMENTO"]);
			this.ID_LNR = Convert.ToInt32(vRdr["ID_LNR"]);
			if (!Convert.IsDBNull(vRdr["NOMBRE_DOCUMENTO"]))
			{				this.NOMBRE_DOCUMENTO = Convert.ToString(vRdr["NOMBRE_DOCUMENTO"]);
			}			if (!Convert.IsDBNull(vRdr["RUTA_DOCUMENTO"]))
			{				this.RUTA_DOCUMENTO = Convert.ToString(vRdr["RUTA_DOCUMENTO"]);
			}			if (!Convert.IsDBNull(vRdr["EXTENCION"]))
			{				this.EXTENCION = Convert.ToString(vRdr["EXTENCION"]);
			}			if (!Convert.IsDBNull(vRdr["TAMANO"]))
			{				this.TAMANO = Convert.ToInt32(vRdr["TAMANO"]);
			}			this.FECHA_DOCUMENTO = Convert.ToDateTime(vRdr["FECHA_DOCUMENTO"]);
			this.NOMBRE_INFORME = Convert.ToString(vRdr["NOMBRE_INFORME"]);
			this.DESCRIPCION = Convert.ToString(vRdr["DESCRIPCION"]);
			if (!Convert.IsDBNull(vRdr["ID_LASERFICHE"]))
			{
				this.ID_LASERFICHE = Convert.ToInt64(vRdr["ID_LASERFICHE"]);
			}
			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))
			{				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);
			}			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))
			{				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);
			}			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))
			{				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);
			}			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))
			{				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);
			}			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))
			{				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);
			}			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))
			{				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);
			}			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);

		}
	}
}