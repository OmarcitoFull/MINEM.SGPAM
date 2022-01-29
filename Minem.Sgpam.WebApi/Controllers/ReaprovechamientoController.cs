using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class ReaprovechamientoController : BaseController
    {
        public readonly IT_Sgpad_Comp_ReaproLN Comp_ReaproLN;
        public ReaprovechamientoController(IT_Sgpad_Comp_ReaproLN vIT_Sgpad_Comp_ReaproLN)
        {
            Comp_ReaproLN = vIT_Sgpad_Comp_ReaproLN;
        }

        [HttpGet("List")]
        public IEnumerable<Comp_ReaproDTO> List(int vIdComponente)
        {
            return Comp_ReaproLN.ListarComp_ReaproDTO(vIdComponente);
        }

        [HttpPost("Save")]
        public Comp_ReaproDTO Save([FromBody] Comp_ReaproDTO vComp_ReaproDTO)
        {
            return Comp_ReaproLN.GrabarComp_ReaproDTO(vComp_ReaproDTO);
        }
    }
}
