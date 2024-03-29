﻿using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    public class V_Ext_SituacionPrincipalesProductos
    {
        public V_Ext_SituacionPrincipalesProductos()
        {

        }

        public V_Ext_SituacionPrincipalesProductos(IDataReader vRdr)
        {
            if (!Convert.IsDBNull(vRdr["ANIO"]))
            {
                this.ANIO = Convert.ToString(vRdr["ANIO"]);
            }
            if (!Convert.IsDBNull(vRdr["ID_CLIENTE"]))
            {
                this.ID_CLIENTE = Convert.ToString(vRdr["ID_CLIENTE"]);
            }
            if (!Convert.IsDBNull(vRdr["NOMBRE_CLIENTE"]))
            {
                this.NOMBRE_CLIENTE = Convert.ToString(vRdr["NOMBRE_CLIENTE"]);
            }
            if (!Convert.IsDBNull(vRdr["ID_UNIDAD"]))
            {
                this.ID_UNIDAD = Convert.ToString(vRdr["ID_UNIDAD"]);
            }
            if (!Convert.IsDBNull(vRdr["NOMBRE_UNIDAD"]))
            {
                this.NOMBRE_UNIDAD = Convert.ToString(vRdr["NOMBRE_UNIDAD"]);
            }
            if (!Convert.IsDBNull(vRdr["SITUACION"]))
            {
                this.SITUACION = Convert.ToString(vRdr["SITUACION"]);
            }
            if (!Convert.IsDBNull(vRdr["TIPO_CONCENTRADO"]))
            {
                this.TIPO_CONCENTRADO = Convert.ToString(vRdr["TIPO_CONCENTRADO"]);
            }
            if (!Convert.IsDBNull(vRdr["CANTIDAD"]))
            {
                this.CANTIDAD = Convert.ToString(vRdr["CANTIDAD"]);
            }
        }

        public string ANIO { get; set; }
        public string ID_CLIENTE { get; set; }
        public string NOMBRE_CLIENTE { get; set; }
        public string ID_UNIDAD { get; set; }
        public string NOMBRE_UNIDAD { get; set; }
        public string SITUACION { get; set; }
        public string TIPO_CONCENTRADO { get; set; }
        public string CANTIDAD { get; set; }
    }
}
