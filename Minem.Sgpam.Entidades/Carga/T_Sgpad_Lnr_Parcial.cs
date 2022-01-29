using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Lnr 
    { 
        public T_Sgpad_Lnr()
        {

        }

        public T_Sgpad_Lnr(IDataReader vRdr)
        {
            			this.ID_ZONA = Convert.ToInt32(vRdr["ID_ZONA"]);  
			if (!Convert.IsDBNull(vRdr["SUB_TIPO_DECLARADO"]))  			{				this.SUB_TIPO_DECLARADO = Convert.ToString(vRdr["SUB_TIPO_DECLARADO"]);  			}			if (!Convert.IsDBNull(vRdr["PROFUNDIDAD"]))  			{				this.PROFUNDIDAD = Convert.ToInt32(vRdr["PROFUNDIDAD"]);  			}			if (!Convert.IsDBNull(vRdr["EVA_RESTOS"]))  			{				this.EVA_RESTOS = Convert.ToString(vRdr["EVA_RESTOS"]);  			}			if (!Convert.IsDBNull(vRdr["VOLUMEN_DESC"]))  			{				this.VOLUMEN_DESC = Convert.ToString(vRdr["VOLUMEN_DESC"]);  			}			this.ID_SUB_TIPO_LNR = Convert.ToInt32(vRdr["ID_SUB_TIPO_LNR"]);  
			if (!Convert.IsDBNull(vRdr["ANCHO"]))  			{				this.ANCHO = Convert.ToInt32(vRdr["ANCHO"]);  			}			if (!Convert.IsDBNull(vRdr["EVA_MATERIAL"]))  			{				this.EVA_MATERIAL = Convert.ToString(vRdr["EVA_MATERIAL"]);  			}			this.NORTE = Convert.ToInt32(vRdr["NORTE"]);  
			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))  			{				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["AREA_DESC"]))  			{				this.AREA_DESC = Convert.ToString(vRdr["AREA_DESC"]);  			}			this.ID_LNR = Convert.ToInt32(vRdr["ID_LNR"]);  
			if (!Convert.IsDBNull(vRdr["PROFUNDIDAD_DESC"]))  			{				this.PROFUNDIDAD_DESC = Convert.ToString(vRdr["PROFUNDIDAD_DESC"]);  			}			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))  			{				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);  			}			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))  			{				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["EVA_CAIDA"]))  			{				this.EVA_CAIDA = Convert.ToString(vRdr["EVA_CAIDA"]);  			}			if (!Convert.IsDBNull(vRdr["EVA_EVIDENCIA"]))  			{				this.EVA_EVIDENCIA = Convert.ToString(vRdr["EVA_EVIDENCIA"]);  			}			this.ID_EXPEDIENTE = Convert.ToInt32(vRdr["ID_EXPEDIENTE"]);  
			if (!Convert.IsDBNull(vRdr["ANCHO_DESC"]))  			{				this.ANCHO_DESC = Convert.ToString(vRdr["ANCHO_DESC"]);  			}			this.ESTE = Convert.ToInt32(vRdr["ESTE"]);  
			this.ID_TIPO_LNR = Convert.ToInt32(vRdr["ID_TIPO_LNR"]);  
			if (!Convert.IsDBNull(vRdr["NOM_DECLARANTE"]))  			{				this.NOM_DECLARANTE = Convert.ToString(vRdr["NOM_DECLARANTE"]);  			}			if (!Convert.IsDBNull(vRdr["LARGO_DESC"]))  			{				this.LARGO_DESC = Convert.ToString(vRdr["LARGO_DESC"]);  			}			if (!Convert.IsDBNull(vRdr["EVA_GENERADOR"]))  			{				this.EVA_GENERADOR = Convert.ToString(vRdr["EVA_GENERADOR"]);  			}			this.UBIGEO = Convert.ToString(vRdr["UBIGEO"]);  
			if (!Convert.IsDBNull(vRdr["LARGO"]))  			{				this.LARGO = Convert.ToInt32(vRdr["LARGO"]);  			}			if (!Convert.IsDBNull(vRdr["EVA_ELEMENTO"]))  			{				this.EVA_ELEMENTO = Convert.ToString(vRdr["EVA_ELEMENTO"]);  			}			if (!Convert.IsDBNull(vRdr["EVA_DRENAJES"]))  			{				this.EVA_DRENAJES = Convert.ToString(vRdr["EVA_DRENAJES"]);  			}			if (!Convert.IsDBNull(vRdr["EVA_ELEMENTOS"]))  			{				this.EVA_ELEMENTOS = Convert.ToString(vRdr["EVA_ELEMENTOS"]);  			}			if (!Convert.IsDBNull(vRdr["ALTO_DESC"]))  			{				this.ALTO_DESC = Convert.ToString(vRdr["ALTO_DESC"]);  			}			if (!Convert.IsDBNull(vRdr["EVA_AFECTACION"]))  			{				this.EVA_AFECTACION = Convert.ToString(vRdr["EVA_AFECTACION"]);  			}			if (!Convert.IsDBNull(vRdr["EVA_POSIBILIDAD"]))  			{				this.EVA_POSIBILIDAD = Convert.ToString(vRdr["EVA_POSIBILIDAD"]);  			}			if (!Convert.IsDBNull(vRdr["EVA_POTENCIAL"]))  			{				this.EVA_POTENCIAL = Convert.ToString(vRdr["EVA_POTENCIAL"]);  			}			this.NRO_EXPEDIENTE = Convert.ToString(vRdr["NRO_EXPEDIENTE"]);  
			if (!Convert.IsDBNull(vRdr["CODIGO_DECLARADO"]))  			{				this.CODIGO_DECLARADO = Convert.ToString(vRdr["CODIGO_DECLARADO"]);  			}			if (!Convert.IsDBNull(vRdr["AREA"]))  			{				this.AREA = Convert.ToInt32(vRdr["AREA"]);  			}			if (!Convert.IsDBNull(vRdr["ALTO"]))  			{				this.ALTO = Convert.ToInt32(vRdr["ALTO"]);  			}			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))  			{				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["EVA_LABOR"]))  			{				this.EVA_LABOR = Convert.ToString(vRdr["EVA_LABOR"]);  			}			this.ID_TEMPORALIDAD = Convert.ToInt32(vRdr["ID_TEMPORALIDAD"]);  
			this.FEC_REGISTRO = Convert.ToDateTime(vRdr["FEC_REGISTRO"]);  
			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))  			{				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);  			}			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))  			{				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);  			}			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  
			if (!Convert.IsDBNull(vRdr["VOLUMEN"]))  			{				this.VOLUMEN = Convert.ToInt32(vRdr["VOLUMEN"]);  			}
        }
    }
}