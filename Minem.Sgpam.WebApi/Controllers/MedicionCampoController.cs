using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class MedicionCampoController : BaseController
    {
        public readonly IT_Sgpad_Comp_MedicionLN Comp_MedicionLN;
        public MedicionCampoController(IT_Sgpad_Comp_MedicionLN vIT_Sgpad_Comp_MedicionLN)
        {
            Comp_MedicionLN = vIT_Sgpad_Comp_MedicionLN;
        }

        [HttpGet("List")]
        public IEnumerable<Comp_MedicionDTO> List(int vIdComponente)
        {
            return Comp_MedicionLN.ListarComp_MedicionDTO(vIdComponente);
        }

        [HttpPost("Save")]
        public Comp_MedicionDTO Save([FromBody] Comp_MedicionDTO vComp_MedicionDTO)
        {
            return Comp_MedicionLN.GrabarComp_MedicionDTO(vComp_MedicionDTO);
        }
    }
}
