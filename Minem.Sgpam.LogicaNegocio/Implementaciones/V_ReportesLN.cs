using Minem.Sgpam.AccesoDatos.Interfaces;
using Minem.Sgpam.InfraEstructura.Enumerados;
using Minem.Sgpam.LogicaNegocio.Base;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System;
using System.Globalization;
using System.Linq;

namespace Minem.Sgpam.LogicaNegocio.Implementaciones
{
    /// <summary>
    /// Objetivo:	Clase que implementa la lógica del negocio para las operaciones de las entidades
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	29/10/2021
    /// </summary>
    public class V_ReportesLN : BaseLN, IV_ReportesLN
    {
        private readonly IV_ReportesAD ReportesAD;

        public V_ReportesLN(IV_ReportesAD vIV_ReportesAD)
        {
            ReportesAD = vIV_ReportesAD;
        }

        public ReportePamDTO Obtener_ReportePam(int vId_Eum)
        {
            try
            {
                var vListaNew = (from A in ReportesAD.Listar_Componentes(vId_Eum)
                                 join B in Enum.GetValues(typeof(Zona)).Cast<Zona>().Select(x => new { Zona = x.ToString(), Id = ((int)x).ToString() }) on A.ListaZonasPAM equals B.Id
                                 select new
                                 {
                                     A.Area,
                                     A.Caudal,
                                     A.Conductividad,
                                     A.Distrito,
                                     A.Estado,
                                     A.Este,
                                     A.IdComponente,
                                     A.Id_Historico,
                                     ListaZonasPAM = B.Zona,
                                     A.NombreEUM,
                                     A.NomEstudioAmbiental,
                                     A.Norte,
                                     A.NroExpediente,
                                     A.NroInforme,
                                     A.PH,
                                     A.Provincia,
                                     A.Puntaje,
                                     A.PuntajeNormalizado,
                                     A.Region,
                                     A.Riesgo,
                                     A.SubTipoPam,
                                     A.TipoPam,
                                     A.AñoUno,
                                     A.DescripcionCom,
                                     A.FechaInformeUno,
                                     A.Imagen1,
                                     A.InstrumentoGestionAmbiental,
                                     A.ResolucionIga,
                                     A.SituacionCom
                                 }).OrderBy(x => x.IdComponente).ToList();

                int vCaracteristica = 0;
                int vResultados = 0;
                ReportePamDTO vResultado = new ReportePamDTO
                {
                    FechaGeneracionMesAño = DateTime.Now.ToString("MMMM", CultureInfo.CreateSpecificCulture("es")) + " " + DateTime.Now.Year.ToString(),
                    FechaGeneracionFormato = DateTime.Now.Day + " de " + DateTime.Now.ToString("MMMM", CultureInfo.CreateSpecificCulture("es")) + " del " + DateTime.Now.Year.ToString(),
                    ListaZonasPAM = string.Join(",", vListaNew.Select(y => y.ListaZonasPAM).Distinct().ToArray()),
                    ListaCaracteristicaPam = (from x in vListaNew select new CaracteristicaPam { Nro = (++vCaracteristica).ToString(), Este = x.Este, Id = x.IdComponente, Eum = x.NombreEUM, Norte = x.Norte, Pje = x.PuntajeNormalizado, Riesgo = x.Riesgo ?? string.Empty, SubTipo = x.SubTipoPam, Tipo = x.TipoPam }).ToList(),
                    ListaResultadosPam = (from z in vListaNew select new ResultadoPam { Nro = (++vResultados).ToString(), Area = z.Area, Q = z.Caudal, Cond = z.Conductividad, Este = z.Este, Id = z.IdComponente, Eum = z.NombreEUM, Iga = z.NomEstudioAmbiental, Norte = z.Norte, PH = z.PH, Pje = z.PuntajeNormalizado, SubTipo = z.SubTipoPam, Tipo = z.TipoPam }).ToList(),
                    ListaAnexoPam = (from z in vListaNew
                                     select new AnexoPam
                                     {
                                         Nro = (++vResultados).ToString(),
                                         Id = z.IdComponente,
                                         Eum = z.NombreEUM,
                                         DistritoCom = z.Distrito,
                                         ProvinciaCom = z.Provincia,
                                         RegionCom = z.Region,
                                         CuencaCom = "",
                                         FechaInspeccionCom = DateTime.Now.ToString("dd/MM/yyyy"),
                                         DescripcionCom = z.DescripcionCom,
                                         Tipo = z.TipoPam,
                                         SubTpo = z.SubTipoPam,
                                         Este = z.Este,
                                         Norte = z.Norte,
                                         Pje = z.PuntajeNormalizado,
                                         Riesgo = z.Riesgo ?? string.Empty,
                                         SituacionCom = z.SituacionCom,
                                         Q = z.Caudal,
                                         PH = z.PH,
                                         Cond = z.Conductividad,
                                         Area = z.Area,
                                         FechaInformeUno = z.FechaInformeUno,
                                         ResolucionIga = z.ResolucionIga,
                                         Iga = z.NomEstudioAmbiental,
                                         InstrumentoGestionAmbiental = z.InstrumentoGestionAmbiental,
                                         AñoUno = z.AñoUno,
                                         AñoDos = DateTime.Now.Year.ToString(),
                                         Imagen1 = z.Imagen1
                                     }).ToList(),

                    Distritosx = string.Join(",", vListaNew.Select(y => y.Distrito).Distinct().ToArray()),
                    Provincias = string.Join(",", vListaNew.Select(y => y.Provincia).Distinct().ToArray()),
                    Regiones = string.Join(",", vListaNew.Select(y => y.Region).Distinct().ToArray()),
                    NombreEUM = vListaNew.FirstOrDefault().NombreEUM,
                    NroExpediente = vListaNew.FirstOrDefault().NroExpediente,
                    NroInforme = vListaNew.FirstOrDefault().NroInforme,

                    RiesgoA = vListaNew.Select(m => m.Riesgo ?? string.Empty).Count(n => n.ToUpper() == "ALTO").ToString() ?? string.Empty,
                    RiesgoB = vListaNew.Select(m => m.Riesgo ?? string.Empty).Count(n => n.ToUpper() == "BAJO").ToString() ?? string.Empty,
                    RiesgoI = vListaNew.Select(m => m.Riesgo ?? string.Empty).Count(n => n.ToUpper() == "INSIGNIFICANTE").ToString() ?? string.Empty,
                    RiesgoM = vListaNew.Select(m => m.Riesgo ?? string.Empty).Count(n => n.ToUpper() == "MEDIO").ToString() ?? string.Empty,
                    RiesgoMA = vListaNew.Select(m => m.Riesgo ?? string.Empty).Count(n => n.ToUpper() == "MUY ALTO").ToString() ?? string.Empty,
                    TotalPAM = vListaNew.Count().ToString()
                };

                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}