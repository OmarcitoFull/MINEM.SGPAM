using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    public class V_Ext_ReinfoDerechosMineros
    {
        public V_Ext_ReinfoDerechosMineros()
        {

        }

        public V_Ext_ReinfoDerechosMineros(IDataReader vRdr)
        {
            if (!Convert.IsDBNull(vRdr["RUC"]))
            {
                this.RUC = Convert.ToString(vRdr["RUC"]);
            }
            if (!Convert.IsDBNull(vRdr["MINERO"]))
            {
                this.MINERO = Convert.ToString(vRdr["MINERO"]);
            }
            if (!Convert.IsDBNull(vRdr["CODIGO_DM"]))
            {
                this.CODIGO_DM = Convert.ToString(vRdr["CODIGO_DM"]);
            }
            if (!Convert.IsDBNull(vRdr["NOMBRE_DM"]))
            {
                this.NOMBRE_DM = Convert.ToString(vRdr["NOMBRE_DM"]);
            }
            if (!Convert.IsDBNull(vRdr["DEPARTAMENTO"]))
            {
                this.DEPARTAMENTO = Convert.ToString(vRdr["DEPARTAMENTO"]);
            }
            if (!Convert.IsDBNull(vRdr["PROVINCIA"]))
            {
                this.PROVINCIA = Convert.ToString(vRdr["PROVINCIA"]);
            }
            if (!Convert.IsDBNull(vRdr["DISTRITO"]))
            {
                this.DISTRITO = Convert.ToString(vRdr["DISTRITO"]);
            }
            if (!Convert.IsDBNull(vRdr["ESTADO"]))
            {
                this.ESTADO = Convert.ToString(vRdr["ESTADO"]);
            }
            if (!Convert.IsDBNull(vRdr["ESTE_PSAD56"]))
            {
                this.ESTE_PSAD56 = Convert.ToString(vRdr["ESTE_PSAD56"]);
            }
            if (!Convert.IsDBNull(vRdr["NORTE_PSAD56"]))
            {
                this.NORTE_PSAD56 = Convert.ToString(vRdr["NORTE_PSAD56"]);
            }
            if (!Convert.IsDBNull(vRdr["ESTE_WGS84_1P"]))
            {
                this.ESTE_WGS84_1P = Convert.ToString(vRdr["ESTE_WGS84_1P"]);
            }
            if (!Convert.IsDBNull(vRdr["NORTE_WGS84_1P"]))
            {
                this.NORTE_WGS84_1P = Convert.ToString(vRdr["NORTE_WGS84_1P"]);
            }
            if (!Convert.IsDBNull(vRdr["ESTE_WGS84_2P"]))
            {
                this.ESTE_WGS84_2P = Convert.ToString(vRdr["ESTE_WGS84_2P"]);
            }
            if (!Convert.IsDBNull(vRdr["NORTE_WGS84_2P"]))
            {
                this.NORTE_WGS84_2P = Convert.ToString(vRdr["NORTE_WGS84_2P"]);
            }
            if (!Convert.IsDBNull(vRdr["TIPO_ACTIVIDAD"]))
            {
                this.TIPO_ACTIVIDAD = Convert.ToString(vRdr["TIPO_ACTIVIDAD"]);
            }
        }

        public string RUC { get; set; }
        public string MINERO { get; set; }
        public string CODIGO_DM { get; set; }
        public string NOMBRE_DM { get; set; }
        public string DEPARTAMENTO { get; set; }
        public string PROVINCIA { get; set; }
        public string DISTRITO { get; set; }
        public string ESTADO { get; set; }
        public string ESTE_PSAD56 { get; set; }
        public string NORTE_PSAD56 { get; set; }
        public string ESTE_WGS84_1P { get; set; }
        public string NORTE_WGS84_1P { get; set; }
        public string ESTE_WGS84_2P { get; set; }
        public string NORTE_WGS84_2P { get; set; }
        public string TIPO_ACTIVIDAD { get; set; }
    }
}
