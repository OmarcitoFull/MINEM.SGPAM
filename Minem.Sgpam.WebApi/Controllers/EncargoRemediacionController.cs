using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class EncargoRemediacionController : BaseController
    {
        public readonly IT_Sgpad_Comp_Enc_RemLN Comp_Enc_RemLN;
        public EncargoRemediacionController(IT_Sgpad_Comp_Enc_RemLN vIT_Sgpad_Comp_Enc_RemLN)
        {
            Comp_Enc_RemLN = vIT_Sgpad_Comp_Enc_RemLN;
        }

        [HttpGet("List")]
        public IEnumerable<Comp_Enc_RemDTO> List(int vIdComponente)
        {
            return Comp_Enc_RemLN.ListarComp_Enc_RemDTO(vIdComponente);
        }

        [HttpPost("Save")]
        public Comp_Enc_RemDTO Save([FromBody] Comp_Enc_RemDTO vComp_Enc_RemDTO)
        {
            return Comp_Enc_RemLN.GrabarComp_Enc_RemDTO(vComp_Enc_RemDTO);
        }

        [HttpGet("Get")]
        public Comp_Enc_RemDTO Get(int vId)
        {
            return Comp_Enc_RemLN.RecuperarComp_Enc_RemDTOPorCodigo(vId);
        }
    }
}
