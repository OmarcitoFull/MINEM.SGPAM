using System.Collections.Generic;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para la generación del reporte Pam
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	15/06/2022
    /// </summary>
    public class ReportePamDTO
    {
        public ReportePamDTO()
        { }

        public string NroInforme { get; set; }
        public string NombreEUM { get; set; }
        public string NroExpediente { get; set; }
        public string Distritosx { get; set; }
        public string Provincias { get; set; }
        public string Regiones { get; set; }
        public string RiesgoMA { get; set; }
        public string RiesgoA { get; set; }
        public string RiesgoM { get; set; }
        public string RiesgoB { get; set; }
        public string RiesgoI { get; set; }
        public string TotalPAM { get; set; }
        public string ListaZonasPAM { get; set; }
        public string FechaGeneracionMesAño { get; set; }
        public string FechaGeneracionFormato { get; set; }

        public List<CaracteristicaPam> ListaCaracteristicaPam { get; set; }
        public List<ResultadoPam> ListaResultadosPam { get; set; }
        public List<AnexoPam> ListaAnexoPam { get; set; }
    }

    public class CaracteristicaPam
    {
        public string Nro { get; set; }
        public string Eum { get; set; }
        public string Id { get; set; }
        public string Tipo { get; set; }
        public string SubTipo { get; set; }
        public string Este { get; set; }
        public string Norte { get; set; }
        public string Pje { get; set; }
        public string Riesgo { get; set; }
    }

    public class ResultadoPam
    {
        public string Nro { get; set; }
        public string Eum { get; set; }
        public string Id { get; set; }
        public string Tipo { get; set; }
        public string SubTipo { get; set; }
        public string Este { get; set; }
        public string Norte { get; set; }
        public string Iga { get; set; }
        public string Pje { get; set; }
        public string Q { get; set; }
        public string PH { get; set; }
        public string Cond { get; set; }
        public string Area { get; set; }
    }

    public class AnexoPam
    {
        public string Nro { get; set; }
        public string Id { get; set; }
        public string Eum { get; set; }
        public string DistritoCom { get; set; }
        public string ProvinciaCom { get; set; }
        public string RegionCom { get; set; }
        public string CuencaCom { get; set; }
        public string FechaInspeccionCom { get; set; }
        public string DescripcionCom { get; set; }

        public string Tipo { get; set; }
        public string SubTpo { get; set; }
        public string Este { get; set; }
        public string Norte { get; set; }
        public string Pje { get; set; }
        public string Riesgo { get; set; }
        public string SituacionCom { get; set; }
        public string Q { get; set; }
        public string PH { get; set; }
        public string Cond { get; set; }
        public string Area { get; set; }
        public string FechaInformeUno { get; set; }
        public string ResolucionIga { get; set; }
        public string Iga { get; set; }
        public string InstrumentoGestionAmbiental { get; set; }
        public string AñoUno { get; set; }
        public string AñoDos { get; set; }
        public string Imagen1 { get; set; }
    }
}
