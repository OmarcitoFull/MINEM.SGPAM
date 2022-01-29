using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class RiesgosSaludHumanaController : BaseController
    {
        public readonly IT_Sgpad_Comp_Riesgo_Sal_AmbLN Riesgo_Sal_AmbLN;
        public RiesgosSaludHumanaController(IT_Sgpad_Comp_Riesgo_Sal_AmbLN vIT_Sgpad_Comp_Riesgo_Sal_AmbLN)
        {
            Riesgo_Sal_AmbLN = vIT_Sgpad_Comp_Riesgo_Sal_AmbLN;
        }

        [HttpGet("List")]
        public IEnumerable<Comp_Riesgo_Sal_AmbDTO> List(int vIdComponente)
        {
            return Riesgo_Sal_AmbLN.ListarComp_Riesgo_Sal_AmbDTO(vIdComponente);
        }

        [HttpPost("Save")]
        public Comp_Riesgo_Sal_AmbDTO Save([FromBody] Comp_Riesgo_Sal_AmbDTO vComp_Riesgo_Sal_AmbDTO)
        {
            return Riesgo_Sal_AmbLN.GrabarComp_Riesgo_Sal_AmbDTO(vComp_Riesgo_Sal_AmbDTO);
        }

        [HttpGet("Get")]
        public Comp_Riesgo_Sal_AmbDTO Get(int vId)
        {
            return Riesgo_Sal_AmbLN.RecuperarComp_Riesgo_Sal_AmbDTOPorCodigo(vId);
        }
    }
}
