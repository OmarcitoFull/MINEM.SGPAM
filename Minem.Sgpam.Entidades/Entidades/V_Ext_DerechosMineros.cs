using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    public class V_Ext_DerechosMineros
    {
        public V_Ext_DerechosMineros()
        {

        }

        public V_Ext_DerechosMineros(IDataReader vRdr)
        {
            if (!Convert.IsDBNull(vRdr["ID"]))
            {
                this.ID = Convert.ToInt32(vRdr["ID"]);
            }

            if (!Convert.IsDBNull(vRdr["CODIGO"]))
            {
                this.CODIGO = Convert.ToString(vRdr["CODIGO"]);
            }
            if (!Convert.IsDBNull(vRdr["NOMBRE"]))
            {
                this.NOMBRE = Convert.ToString(vRdr["NOMBRE"]);
            }
            if (!Convert.IsDBNull(vRdr["UEA"]))
            {
                this.UEA = Convert.ToString(vRdr["UEA"]);
            }
            if (!Convert.IsDBNull(vRdr["TIPO"]))
            {
                this.TIPO = Convert.ToString(vRdr["TIPO"]);
            }
            if (!Convert.IsDBNull(vRdr["SUSTANCIA"]))
            {
                this.SUSTANCIA = Convert.ToString(vRdr["SUSTANCIA"]);
            }
            if (!Convert.IsDBNull(vRdr["SITUACION"]))
            {
                this.SITUACION = Convert.ToString(vRdr["SITUACION"]);
            }
            if (!Convert.IsDBNull(vRdr["ESTADO"]))
            {
                this.ESTADO = Convert.ToString(vRdr["ESTADO"]);
            }
            if (!Convert.IsDBNull(vRdr["RESOLUCION"]))
            {
                this.RESOLUCION = Convert.ToString(vRdr["RESOLUCION"]);
            }
            if (!Convert.IsDBNull(vRdr["FECHA_RESOLUCION"]))
            {
                this.FECHA_RESOLUCION = Convert.ToString(vRdr["FECHA_RESOLUCION"]);
            }
            if (!Convert.IsDBNull(vRdr["RESOLUCION_CADUCIDAD"]))
            {
                this.RESOLUCION_CADUCIDAD = Convert.ToString(vRdr["RESOLUCION_CADUCIDAD"]);
            }
            if (!Convert.IsDBNull(vRdr["FECHA_CADUCIDAD"]))
            {
                this.FECHA_CADUCIDAD = Convert.ToString(vRdr["FECHA_CADUCIDAD"]);
            }
        }

        public int ID { get; set; }
        public string CODIGO { get; set; }
        public string NOMBRE { get; set; }
        public string UEA { get; set; }
        public string TIPO { get; set; }
        public string SUSTANCIA { get; set; }
        public string SITUACION { get; set; }
        public string ESTADO { get; set; }
        public string RESOLUCION { get; set; }
        public string FECHA_RESOLUCION { get; set; }
        public string RESOLUCION_CADUCIDAD { get; set; }
        public string FECHA_CADUCIDAD { get; set; }
    }
}
