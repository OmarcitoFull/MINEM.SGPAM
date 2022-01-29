using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class RiesgosFaunaSilvestreController : BaseController
    {
        public readonly IT_Sgpad_Comp_Riesgo_Fau_ConLN Riesgo_Fau_ConLN;
        public RiesgosFaunaSilvestreController(IT_Sgpad_Comp_Riesgo_Fau_ConLN vIT_Sgpad_Comp_Riesgo_Fau_ConLN)
        {
            Riesgo_Fau_ConLN = vIT_Sgpad_Comp_Riesgo_Fau_ConLN;
        }

        [HttpGet("List")]
        public IEnumerable<Comp_Riesgo_Fau_ConDTO> List(int vIdComponente)
        {
            return Riesgo_Fau_ConLN.ListarComp_Riesgo_Fau_ConDTO(vIdComponente);
        }

        [HttpPost("Save")]
        public Comp_Riesgo_Fau_ConDTO Save([FromBody] Comp_Riesgo_Fau_ConDTO vComp_Riesgo_Fau_ConDTO)
        {
            return Riesgo_Fau_ConLN.GrabarComp_Riesgo_Fau_ConDTO(vComp_Riesgo_Fau_ConDTO);
        }

        [HttpGet("Get")]
        public Comp_Riesgo_Fau_ConDTO Get(int vId)
        {
            return Riesgo_Fau_ConLN.RecuperarComp_Riesgo_Fau_ConDTOPorCodigo(vId);
        }
    }
}
