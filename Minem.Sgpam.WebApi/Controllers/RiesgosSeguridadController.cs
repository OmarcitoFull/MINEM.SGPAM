using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class RiesgosSeguridadController : BaseController
    {
        public readonly IT_Sgpad_Comp_Riesgo_Seg_HumLN Riesgo_Seg_HumLN;
        public RiesgosSeguridadController(IT_Sgpad_Comp_Riesgo_Seg_HumLN vIT_Sgpad_Comp_Riesgo_Seg_HumLN)
        {
            Riesgo_Seg_HumLN = vIT_Sgpad_Comp_Riesgo_Seg_HumLN;
        }

        [HttpGet("List")]
        public IEnumerable<Comp_Riesgo_Seg_HumDTO> List(int vIdComponente)
        {
            return Riesgo_Seg_HumLN.ListarComp_Riesgo_Seg_HumDTO(vIdComponente);
        }

        [HttpPost("Save")]
        public Comp_Riesgo_Seg_HumDTO Save([FromBody] Comp_Riesgo_Seg_HumDTO vComp_ComentarioDTO)
        {
            return Riesgo_Seg_HumLN.GrabarComp_Riesgo_Seg_HumDTO(vComp_ComentarioDTO);
        }

        [HttpGet("Get")]
        public Comp_Riesgo_Seg_HumDTO Get(int vId)
        {
            return Riesgo_Seg_HumLN.RecuperarComp_Riesgo_Seg_HumDTOPorCodigo(vId);
        }
    }
}
