using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class TipoMineriaController : BaseController
    {
        public readonly IT_Sgpal_Tipo_MineriaLN Tipo_MineriaLN;
        public TipoMineriaController(IT_Sgpal_Tipo_MineriaLN vIT_Sgpal_Tipo_MineriaLN)
        {
            Tipo_MineriaLN = vIT_Sgpal_Tipo_MineriaLN;
        }

        [HttpGet("List")]
        public IEnumerable<Tipo_MineriaDTO> List()
        {
            return Tipo_MineriaLN.ListarTipo_MineriaDTO();
        }
    }
}
