using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpam_Maestra 
    { 
        public T_Sgpam_Maestra()
        {

        }

        public T_Sgpam_Maestra(IDataReader vRdr)
        {
            
			if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))  
			{
				this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);  
			}
			this.FLORA_FAUNA_ACUATICA = Convert.ToString(vRdr["FLORA_FAUNA_ACUATICA"]);  
			this.ID_TIPO_SUSTANCIA = Convert.ToInt32(vRdr["ID_TIPO_SUSTANCIA"]);  
			this.FLORA_TERRESTRE = Convert.ToString(vRdr["FLORA_TERRESTRE"]);  
			this.USO_SUELO = Convert.ToString(vRdr["USO_SUELO"]);  

			if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))  
			{
				this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);  
			}

			if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))  
			{
				this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);  
			}
			this.ACCESO_EUM = Convert.ToString(vRdr["ACCESO_EUM"]);  

			if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))  
			{
				this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);  
			}

			if (!Convert.IsDBNull(vRdr["ID_ESTADO_REGISTRO"]))  
			{
				this.ID_ESTADO_REGISTRO = Convert.ToInt32(vRdr["ID_ESTADO_REGISTRO"]);  
			}

			if (!Convert.IsDBNull(vRdr["CONFLICTO_SOCIAL"]))  
			{
				this.CONFLICTO_SOCIAL = Convert.ToString(vRdr["CONFLICTO_SOCIAL"]);  
			}

			if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))  
			{
				this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);  
			}
			this.USO_AGUA = Convert.ToString(vRdr["USO_AGUA"]);  
			this.ID_TIPO_OPERACION = Convert.ToInt32(vRdr["ID_TIPO_OPERACION"]);  
			this.HISTORIA_EUM = Convert.ToString(vRdr["HISTORIA_EUM"]);  
			this.RELIEVE = Convert.ToString(vRdr["RELIEVE"]);  
			this.ID_EUM = Convert.ToInt32(vRdr["ID_EUM"]);  
			this.FAUNA_TERRESTE = Convert.ToString(vRdr["FAUNA_TERRESTE"]);  
			this.SITIO_ARQUE_TURISTICO = Convert.ToString(vRdr["SITIO_ARQUE_TURISTICO"]);  
			this.AREA_CONSERVACION = Convert.ToString(vRdr["AREA_CONSERVACION"]);  
			this.EUM_DESCRIPCION = Convert.ToString(vRdr["EUM_DESCRIPCION"]);  
			this.INFRA_URBANA = Convert.ToString(vRdr["INFRA_URBANA"]);  
			this.EVIDENCIA_ACT_REC = Convert.ToString(vRdr["EVIDENCIA_ACT_REC"]);  
			this.ID_CONFLICTO_SOCIAL = Convert.ToInt32(vRdr["ID_CONFLICTO_SOCIAL"]);  
			this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);  

			if (!Convert.IsDBNull(vRdr["COMENTARIO_ADI"]))  
			{
				this.COMENTARIO_ADI = Convert.ToString(vRdr["COMENTARIO_ADI"]);  
			}

			if (!Convert.IsDBNull(vRdr["NUM_EUM"]))  
			{
				this.NUM_EUM = Convert.ToInt32(vRdr["NUM_EUM"]);  
			}
			this.DESCRIPCION_EUM = Convert.ToString(vRdr["DESCRIPCION_EUM"]);  

			if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))  
			{
				this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);  
			}
			this.CUERPOS_AGUA = Convert.ToString(vRdr["CUERPOS_AGUA"]);  

        }
    }
}