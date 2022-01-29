using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class TipoPamController : BaseController
    {
        public readonly IT_Sgpal_Tipo_PamLN Tipo_PamLN;
        public TipoPamController(IT_Sgpal_Tipo_PamLN vIT_Sgpal_Tipo_PamLN)
        {
            Tipo_PamLN = vIT_Sgpal_Tipo_PamLN;
        }

        [HttpGet("List")]
        public IEnumerable<Tipo_PamDTO> List()
        {
            return Tipo_PamLN.ListarTipo_PamDTO();
        }
    }
}
