using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class ObservacionController : BaseController
    {
        public readonly IT_Sgpad_Comp_ObservacionLN Comp_ObservacionLN;
        public ObservacionController(IT_Sgpad_Comp_ObservacionLN vIT_Sgpad_Comp_ObservacionLN)
        {
            Comp_ObservacionLN = vIT_Sgpad_Comp_ObservacionLN;
        }

        [HttpGet("List")]
        public IEnumerable<Comp_ObservacionDTO> List(int vIdComponente)
        {
            return Comp_ObservacionLN.ListarComp_ObservacionDTO(vIdComponente);
        }

        [HttpPost("Save")]
        public Comp_ObservacionDTO Save([FromBody] Comp_ObservacionDTO vComp_ObservacionDTO)
        {
            return Comp_ObservacionLN.GrabarComp_ObservacionDTO(vComp_ObservacionDTO);
        }
    }
}
