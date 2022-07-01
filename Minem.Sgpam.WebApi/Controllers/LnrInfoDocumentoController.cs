using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class LnrInfoDocumentoController : BaseController
    {
        public readonly IT_Sgpad_Lnr_Info_DocumentoLN Lnr_Info_DocumentoLN;
        public LnrInfoDocumentoController(IT_Sgpad_Lnr_Info_DocumentoLN vIT_Sgpad_Lnr_Info_DocumentoLN)
        {
            Lnr_Info_DocumentoLN = vIT_Sgpad_Lnr_Info_DocumentoLN;
        }

        [HttpGet("List")]
        public IEnumerable<Lnr_Info_DocumentoDTO> List(int vIdLnr)
        {
            return Lnr_Info_DocumentoLN.ListarPorIdLnrLnr_Info_DocumentoDTO(vIdLnr);
        }

        [HttpGet("Get")]
        public Lnr_Info_DocumentoDTO Get(int vId)
        {
            return Lnr_Info_DocumentoLN.RecuperarLnr_Info_DocumentoDTOPorCodigo(vId);
        }


        [HttpPost("Save")]
        public Lnr_Info_DocumentoDTO Save([FromBody] Lnr_Info_DocumentoDTO vLnr_Info_DocumentoDTO)
        {
            return Lnr_Info_DocumentoLN.GrabarLnr_Info_DocumentoDTO(vLnr_Info_DocumentoDTO);
        }

    }
}
