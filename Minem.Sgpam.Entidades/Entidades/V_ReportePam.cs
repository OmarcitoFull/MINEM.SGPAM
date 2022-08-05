using System;
using System.Data;

namespace Minem.Sgpam.Entidades.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea la consulta para el reporte
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	01/06/2022
    /// </summary>
    public class V_ReportePam
    {
        public V_ReportePam()
        {

        }

        public V_ReportePam(IDataReader vRdr)
        {
            if (!Convert.IsDBNull(vRdr["NroInforme"]))
            {
                this.NroInforme = Convert.ToString(vRdr["NroInforme"]);
            }
            if (!Convert.IsDBNull(vRdr["NombreEUM"]))
            {
                this.NombreEUM = Convert.ToString(vRdr["NombreEUM"]);
            }
            if (!Convert.IsDBNull(vRdr["NroExpediente"]))
            {
                this.NroExpediente = Convert.ToString(vRdr["NroExpediente"]);
            }
            if (!Convert.IsDBNull(vRdr["Region"]))
            {
                this.Region = Convert.ToString(vRdr["Region"]);
            }
            if (!Convert.IsDBNull(vRdr["Provincia"]))
            {
                this.Provincia = Convert.ToString(vRdr["Provincia"]);
            }
            if (!Convert.IsDBNull(vRdr["Distrito"]))
            {
                this.Distrito = Convert.ToString(vRdr["Distrito"]);
            }
            if (!Convert.IsDBNull(vRdr["Puntaje"]))
            {
                this.Puntaje = Convert.ToString(vRdr["Puntaje"]);
            }
            if (!Convert.IsDBNull(vRdr["PuntajeNormalizado"]))
            {
                this.PuntajeNormalizado = Convert.ToString(vRdr["PuntajeNormalizado"]);
            }
            if (!Convert.IsDBNull(vRdr["Riesgo"]))
            {
                this.Riesgo = Convert.ToString(vRdr["Riesgo"]);
            }
            if (!Convert.IsDBNull(vRdr["ListaZonasPAM"]))
            {
                this.ListaZonasPAM = Convert.ToString(vRdr["ListaZonasPAM"]);
            }
            if (!Convert.IsDBNull(vRdr["IdComponente"]))
            {
                this.IdComponente = Convert.ToString(vRdr["IdComponente"]);
            }
            if (!Convert.IsDBNull(vRdr["TipoPam"]))
            {
                this.TipoPam = Convert.ToString(vRdr["TipoPam"]);
            }
            if (!Convert.IsDBNull(vRdr["SubTipoPam"]))
            {
                this.SubTipoPam = Convert.ToString(vRdr["SubTipoPam"]);
            }
            if (!Convert.IsDBNull(vRdr["Este"]))
            {
                this.Este = Convert.ToString(vRdr["Este"]);
            }
            if (!Convert.IsDBNull(vRdr["Norte"]))
            {
                this.Norte = Convert.ToString(vRdr["Norte"]);
            }
            if (!Convert.IsDBNull(vRdr["NomEstudioAmbiental"]))
            {
                this.NomEstudioAmbiental = Convert.ToString(vRdr["NomEstudioAmbiental"]);
            }
            if (!Convert.IsDBNull(vRdr["Caudal"]))
            {
                this.Caudal = Convert.ToString(vRdr["Caudal"]);
            }
            if (!Convert.IsDBNull(vRdr["PH"]))
            {
                this.PH = Convert.ToString(vRdr["PH"]);
            }
            if (!Convert.IsDBNull(vRdr["Conductividad"]))
            {
                this.Conductividad = Convert.ToString(vRdr["Conductividad"]);
            }
            if (!Convert.IsDBNull(vRdr["Area"]))
            {
                this.Area = Convert.ToString(vRdr["Area"]);
            }
            if (!Convert.IsDBNull(vRdr["Estado"]))
            {
                this.Estado = Convert.ToString(vRdr["Estado"]);
            }
            if (!Convert.IsDBNull(vRdr["Id_Historico"]))
            {
                this.Id_Historico = Convert.ToString(vRdr["Id_Historico"]);
            }

            if (!Convert.IsDBNull(vRdr["DescripcionCom"]))
            {
                this.DescripcionCom = Convert.ToString(vRdr["DescripcionCom"]);
            }
            if (!Convert.IsDBNull(vRdr["SituacionCom"]))
            {
                this.SituacionCom = Convert.ToString(vRdr["SituacionCom"]);
            }
            if (!Convert.IsDBNull(vRdr["FechaInformeUno"]))
            {
                this.FechaInformeUno = Convert.ToString(vRdr["FechaInformeUno"]);
            }
            if (!Convert.IsDBNull(vRdr["ResolucionIga"]))
            {
                this.ResolucionIga = Convert.ToString(vRdr["ResolucionIga"]);
            }
            if (!Convert.IsDBNull(vRdr["InstrumentoGestionAmbiental"]))
            {
                this.InstrumentoGestionAmbiental = Convert.ToString(vRdr["InstrumentoGestionAmbiental"]);
            }
            if (!Convert.IsDBNull(vRdr["AñoUno"]))
            {
                this.AñoUno = Convert.ToString(vRdr["AñoUno"]);
            }
            if (!Convert.IsDBNull(vRdr["Imagen1"]))
            {
                this.Imagen1 = Convert.ToString(vRdr["Imagen1"]);
            }
        }

        public string NroInforme { get; set; }
        public string NombreEUM { get; set; }
        public string NroExpediente { get; set; }
        public string Region { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string Puntaje { get; set; }
        public string PuntajeNormalizado { get; set; }
        public string Riesgo { get; set; }
        public string ListaZonasPAM { get; set; }
        public string IdComponente { get; set; }
        public string TipoPam { get; set; }
        public string SubTipoPam { get; set; }
        public string Este { get; set; }
        public string Norte { get; set; }
        public string NomEstudioAmbiental { get; set; }
        public string Caudal { get; set; }
        public string PH { get; set; }
        public string Conductividad { get; set; }
        public string Area { get; set; }
        public string Estado { get; set; }
        public string Id_Historico { get; set; }

        public string DescripcionCom { get; set; }
        public string SituacionCom { get; set; }
        public string FechaInformeUno { get; set; }
        public string ResolucionIga { get; set; }
        public string InstrumentoGestionAmbiental { get; set; }
        public string AñoUno { get; set; }
        public string Imagen1 { get; set; }

    }
}
