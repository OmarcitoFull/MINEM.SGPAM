using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    /// <summary>
    /// Objetivo:	Controlador que implementa los servicios
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	31/10/2021
    /// </summary>
    public class HumedadController : BaseController
    {
        public readonly IT_Sgpal_HumedadLN HumedadLN;
        public HumedadController(IT_Sgpal_HumedadLN vIT_Sgpal_HumedadLN)
        {
            HumedadLN = vIT_Sgpal_HumedadLN;
        }

        [HttpGet("List")]
        public IEnumerable<HumedadDTO> List()
        {
            return HumedadLN.ListarHumedadDTO();
        }
    }
}
