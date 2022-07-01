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

            this.ID_EUM = Convert.ToInt32(vRdr["ID_EUM"]);
            this.EUM_DESCRIPCION = Convert.ToString(vRdr["EUM_DESCRIPCION"]);
            this.ACCESO_EUM = Convert.ToString(vRdr["ACCESO_EUM"]);
            this.HISTORIA_EUM = Convert.ToString(vRdr["HISTORIA_EUM"]);
            this.EVIDENCIA_ACT_REC = Convert.ToString(vRdr["EVIDENCIA_ACT_REC"]);
            if (!Convert.IsDBNull(vRdr["ID_TIPO_OPERACION"]))
            {
                this.ID_TIPO_OPERACION = Convert.ToInt32(vRdr["ID_TIPO_OPERACION"]);
            }
            this.ID_TIPO_SUSTANCIA = Convert.ToInt32(vRdr["ID_TIPO_SUSTANCIA"]);
            this.RELIEVE = Convert.ToString(vRdr["RELIEVE"]);
            this.CUERPOS_AGUA = Convert.ToString(vRdr["CUERPOS_AGUA"]);
            this.FLORA_TERRESTRE = Convert.ToString(vRdr["FLORA_TERRESTRE"]);
            this.FAUNA_TERRESTE = Convert.ToString(vRdr["FAUNA_TERRESTE"]);
            this.FLORA_FAUNA_ACUATICA = Convert.ToString(vRdr["FLORA_FAUNA_ACUATICA"]);
            this.INFRA_URBANA = Convert.ToString(vRdr["INFRA_URBANA"]);
            this.USO_SUELO = Convert.ToString(vRdr["USO_SUELO"]);
            this.USO_AGUA = Convert.ToString(vRdr["USO_AGUA"]);
            this.AREA_CONSERVACION = Convert.ToString(vRdr["AREA_CONSERVACION"]);
            this.SITIO_ARQUE_TURISTICO = Convert.ToString(vRdr["SITIO_ARQUE_TURISTICO"]);
            this.ID_CONFLICTO_SOCIAL = Convert.ToInt32(vRdr["ID_CONFLICTO_SOCIAL"]);
            if (!Convert.IsDBNull(vRdr["CONFLICTO_SOCIAL"]))
            {
                this.CONFLICTO_SOCIAL = Convert.ToString(vRdr["CONFLICTO_SOCIAL"]);
            }
            this.DESCRIPCION_EUM = Convert.ToString(vRdr["DESCRIPCION_EUM"]);
            if (!Convert.IsDBNull(vRdr["COMENTARIO_ADI"]))
            {
                this.COMENTARIO_ADI = Convert.ToString(vRdr["COMENTARIO_ADI"]);
            }
            if (!Convert.IsDBNull(vRdr["NUM_EUM"]))
            {
                this.NUM_EUM = Convert.ToInt32(vRdr["NUM_EUM"]);
            }
            if (!Convert.IsDBNull(vRdr["ID_ESTADO_REGISTRO"]))
            {
                this.ID_ESTADO_REGISTRO = Convert.ToInt32(vRdr["ID_ESTADO_REGISTRO"]);
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


            if (!Convert.IsDBNull(vRdr["ULT_VISITA"]))
            {
                this.ULT_VISITA = Convert.ToDateTime(vRdr["ULT_VISITA"]);
            }
            if (!Convert.IsDBNull(vRdr["FECHA_INFORME"]))
            {
                this.FECHA_INFORME = Convert.ToDateTime(vRdr["FECHA_INFORME"]);
            }
            if (!Convert.IsDBNull(vRdr["NRO_INFORME"]))
            {
                this.NRO_INFORME = Convert.ToString(vRdr["NRO_INFORME"]);
            }

        }
    }
}