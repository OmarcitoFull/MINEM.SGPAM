using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class CoberturaController : BaseController
    {
        public readonly IT_Sgpal_CoberturaLN CoberturaLN;
        public CoberturaController(IT_Sgpal_CoberturaLN vIT_Sgpal_CoberturaLN)
        {
            CoberturaLN = vIT_Sgpal_CoberturaLN;
        }

        [HttpGet("List")]
        public IEnumerable<CoberturaDTO> List()
        {
            return CoberturaLN.ListarCoberturaDTO();
        }
    }
}
