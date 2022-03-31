using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	SobreCarga para la Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/10/2021
    /// </summary>
    public partial class T_Sgpad_Componente
    {
        public T_Sgpad_Componente()
        {

        }

        public T_Sgpad_Componente(IDataReader vRdr)
        {
            this.ID_DATUM = Convert.ToString(vRdr["ID_DATUM"]);

            if (!Convert.IsDBNull(vRdr["USU_INGRESO"]))
            {
                this.USU_INGRESO = Convert.ToString(vRdr["USU_INGRESO"]);
            }

            if (!Convert.IsDBNull(vRdr["ID_HUMEDAD"]))
            {
                this.ID_HUMEDAD = Convert.ToInt32(vRdr["ID_HUMEDAD"]);
            }
            this.ID_EUM = Convert.ToInt32(vRdr["ID_EUM"]);

            if (!Convert.IsDBNull(vRdr["FEC_MODIFICA"]))
            {
                this.FEC_MODIFICA = Convert.ToDateTime(vRdr["FEC_MODIFICA"]);
            }

            if (!Convert.IsDBNull(vRdr["ID_TAMANO_PARTICULA"]))
            {
                this.ID_TAMANO_PARTICULA = Convert.ToInt32(vRdr["ID_TAMANO_PARTICULA"]);
            }

            if (!Convert.IsDBNull(vRdr["NOMBRE"]))
            {
                this.NOMBRE = Convert.ToString(vRdr["NOMBRE"]);
            }

            if (!Convert.IsDBNull(vRdr["OTRO_DESCRIPCION"]))
            {
                this.OTRO_DESCRIPCION = Convert.ToString(vRdr["OTRO_DESCRIPCION"]);
            }

            if (!Convert.IsDBNull(vRdr["ID_TIPO_MINERIA"]))
            {
                this.ID_TIPO_MINERIA = Convert.ToInt32(vRdr["ID_TIPO_MINERIA"]);
            }
            this.FLG_ESTADO = Convert.ToString(vRdr["FLG_ESTADO"]);
            this.ID_COMPONENTE = Convert.ToInt32(vRdr["ID_COMPONENTE"]);

            if (!Convert.IsDBNull(vRdr["ID_CUENCA"]))
            {
                this.ID_CUENCA = Convert.ToInt32(vRdr["ID_CUENCA"]);
            }

            if (!Convert.IsDBNull(vRdr["PUNTAJE_NORMALIZADO"]))
            {
                this.PUNTAJE_NORMALIZADO = Convert.ToInt32(vRdr["PUNTAJE_NORMALIZADO"]);
            }

            if (!Convert.IsDBNull(vRdr["CARACTERISTICA"]))
            {
                this.CARACTERISTICA = Convert.ToString(vRdr["CARACTERISTICA"]);
            }

            if (!Convert.IsDBNull(vRdr["IP_INGRESO"]))
            {
                this.IP_INGRESO = Convert.ToString(vRdr["IP_INGRESO"]);
            }

            if (!Convert.IsDBNull(vRdr["FEC_INGRESO"]))
            {
                this.FEC_INGRESO = Convert.ToDateTime(vRdr["FEC_INGRESO"]);
            }

            this.UBICACION = Convert.ToString(vRdr["UBICACION"]);

            if (!Convert.IsDBNull(vRdr["PUNTAJE"]))
            {
                this.PUNTAJE = Convert.ToInt32(vRdr["PUNTAJE"]);
            }

            if (!Convert.IsDBNull(vRdr["USU_MODIFICA"]))
            {
                this.USU_MODIFICA = Convert.ToString(vRdr["USU_MODIFICA"]);
            }

            if (!Convert.IsDBNull(vRdr["ID_SITUACION_PAM"]))
            {
                this.ID_SITUACION_PAM = Convert.ToInt32(vRdr["ID_SITUACION_PAM"]);
            }

            if (!Convert.IsDBNull(vRdr["IP_MODIFICA"]))
            {
                this.IP_MODIFICA = Convert.ToString(vRdr["IP_MODIFICA"]);
            }

            if (!Convert.IsDBNull(vRdr["ID_ZONA"]))
            {
                this.ID_ZONA = Convert.ToInt32(vRdr["ID_ZONA"]);
            }

            if (!Convert.IsDBNull(vRdr["ID_TIPO_CONCESION"]))
            {
                this.ID_TIPO_CONCESION = Convert.ToInt32(vRdr["ID_TIPO_CONCESION"]);
            }

            if (!Convert.IsDBNull(vRdr["ID_SUB_TIPO_PAM"]))
            {
                this.ID_SUB_TIPO_PAM = Convert.ToInt32(vRdr["ID_SUB_TIPO_PAM"]);
            }

            if (!Convert.IsDBNull(vRdr["ESTE"]))
            {
                this.ESTE = Convert.ToDecimal(vRdr["ESTE"]);
            }

            if (!Convert.IsDBNull(vRdr["ID_CUENCA_HIDRO"]))
            {
                this.ID_CUENCA_HIDRO = Convert.ToInt32(vRdr["ID_CUENCA_HIDRO"]);
            }

            if (!Convert.IsDBNull(vRdr["ID_CUENCA_SECUNDARIA"]))
            {
                this.ID_CUENCA_SECUNDARIA = Convert.ToInt32(vRdr["ID_CUENCA_SECUNDARIA"]);
            }

            this.UBIGEO = Convert.ToString(vRdr["UBIGEO"]);
            this.ID_TIPO_PAM = Convert.ToInt32(vRdr["ID_TIPO_PAM"]);

            if (!Convert.IsDBNull(vRdr["ID_COBERTURA"]))
            {
                this.ID_COBERTURA = Convert.ToInt32(vRdr["ID_COBERTURA"]);
            }

            if (!Convert.IsDBNull(vRdr["NORTE"]))
            {
                this.NORTE = Convert.ToDecimal(vRdr["NORTE"]);
            }

            this.DESCRIPCION = Convert.ToString(vRdr["DESCRIPCION"]);

            if (!Convert.IsDBNull(vRdr["RIESGO"]))
            {
                this.RIESGO = Convert.ToString(vRdr["RIESGO"]);
            }
        }
    }
}