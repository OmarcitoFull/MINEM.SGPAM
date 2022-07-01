using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minem.Sgpam.WebApi.Controllers
{
    /// <summary>
    /// Objetivo:	Controlador que implementa los servicios
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	31/10/2021
    /// </summary>
    public class ReportesController : BaseController
    {
        public readonly IV_ReportesLN ReportesLN;

        public ReportesController(IV_ReportesLN vIV_ReportesLN)
        {
            ReportesLN = vIV_ReportesLN;
        }

        [HttpGet("GetReportPam")]
        public ReportePamDTO GetReportPam(int vId)
        {
            return ReportesLN.Obtener_ReportePam(vId);
        }
    }
}
