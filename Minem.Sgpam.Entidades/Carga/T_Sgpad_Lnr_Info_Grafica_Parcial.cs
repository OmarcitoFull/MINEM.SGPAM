using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Lnr_Info_Grafica 
    { 
        public T_Sgpad_Lnr_Info_Grafica()
        {

        }

        public T_Sgpad_Lnr_Info_Grafica(IDataReader vRdr)
        {
			this.ID_LNR_INFO_GRAFICA = Convert.ToInt32(vRdr["ID_LNR_INFO_GRAFICA"]);
			this.ID_LNR = Convert.ToInt32(vRdr["ID_LNR"]);
			this.NOMBRE_IMAGEN = Convert.ToString(vRdr["NOMBRE_IMAGEN"]);
			this.RUTA_IMAGEN = Convert.ToString(vRdr["RUTA_IMAGEN"]);
			if (!Convert.IsDBNull(vRdr["EXTENCION"]))
			{				this.EXTENCION = Convert.ToString(vRdr["EXTENCION"]);
			}			if (!Convert.IsDBNull(vRdr["TAMANO"]))
			{				this.TAMANO = Convert.ToInt32(vRdr["TAMANO"]);
			}			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))
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
			if (!Convert.IsDBNull(vRdr["FECHA_TOMA"]))
			{
				this.FECHA_TOMA = Convert.ToDateTime(vRdr["FECHA_TOMA"]);
			}
			if (!Convert.IsDBNull(vRdr["ID_LASERFICHE"]))
			{
				this.ID_LASERFICHE = Convert.ToInt64(vRdr["ID_LASERFICHE"]);
			}
			this.DESCRIPCION = Convert.ToString(vRdr["DESCRIPCION"]);


		}
	}
}