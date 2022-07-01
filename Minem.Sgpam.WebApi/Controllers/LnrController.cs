using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class LnrController : BaseController
    {
        public readonly IT_Sgpad_LnrLN Lnr_LN;


        public LnrController(IT_Sgpad_LnrLN vIT_Sgpad_LnrLN)
        {
            Lnr_LN = vIT_Sgpad_LnrLN;
        }

        [HttpGet("List")]
        public IEnumerable<LnrDTO> List()
        {
            return Lnr_LN.ListarLnrDTO();
        }

        [HttpGet("Get")]
        public LnrDTO Get(int vId)
        {
            return Lnr_LN.RecuperarLnrDTOPorCodigo(vId);
        }

        [HttpPost("Save")]
        public LnrDTO Save([FromBody] LnrDTO vLnrDTO)
        {
            return Lnr_LN.GrabarLnrDTO(vLnrDTO);
        }

        [HttpGet("GetFull")]
        public RegistrarLnrDTO GetFull(int vId)
        {
            return Lnr_LN.RecuperarFullLnrDTOPorCodigo(vId);
        }

        [HttpGet("ListarPaginadoLnrDTO")]
        public IEnumerable<LnrDTO> ListarPaginadoLnrDTO(int vIdExpediente, int vNumPag, int vCantRegxPag)
        {
            return Lnr_LN.ListarPaginadoLnrDTO(vIdExpediente, vNumPag, vCantRegxPag);
        }

        [HttpGet("Evaluar")]
        public RegistrarEvaluacionLnrDTO Evaluar(int vId)
        {
            return Lnr_LN.RecuperarFullEvaluarLnrDTOPorCodigo(vId);
        }

    }
}
