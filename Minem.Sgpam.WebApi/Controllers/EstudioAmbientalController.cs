using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class EstudioAmbientalController : BaseController
    {
        public readonly IT_Sgpad_Comp_Est_AmbLN Comp_Est_AmbLN;
        public EstudioAmbientalController(IT_Sgpad_Comp_Est_AmbLN vIT_Sgpad_Comp_Est_AmbLN)
        {
            Comp_Est_AmbLN = vIT_Sgpad_Comp_Est_AmbLN;
        }

        [HttpGet("List")]
        public IEnumerable<Comp_Est_AmbDTO> List(int vIdComponente)
        {
            return Comp_Est_AmbLN.ListarComp_Est_AmbDTO(vIdComponente);
        }

        [HttpGet("Get")]
        public Comp_Est_AmbDTO Get(int vId)
        {
            return Comp_Est_AmbLN.RecuperarComp_Est_AmbDTOPorCodigo(vId);
        }

        [HttpPost("Save")]
        public Comp_Est_AmbDTO Save([FromBody] Comp_Est_AmbDTO vComp_Est_AmbDTO)
        {
            return Comp_Est_AmbLN.GrabarComp_Est_AmbDTO(vComp_Est_AmbDTO);
        }
    }
}
