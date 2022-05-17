using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class VisitaController : BaseController
    {
        public readonly IT_Sgpam_VisitaLN Visita_LN;


        public VisitaController(IT_Sgpam_VisitaLN vIT_Sgpam_VisitaLN )
        {
            Visita_LN = vIT_Sgpam_VisitaLN;
        }

        [HttpGet("List")]
        public IEnumerable<VisitaDTO> List()
        {
            return Visita_LN.ListarVisitaDTO();
        }

        [HttpGet("Get")]
        public VisitaDTO Get(int vId)
        {
            return Visita_LN.RecuperarVisitaDTOPorCodigo(vId);
        }

        [HttpPost("Save")]
        public VisitaDTO Save([FromBody] VisitaDTO vVisitaDTO)
        {
            return Visita_LN.ActualizarVisitaDTO(vVisitaDTO);
        }

        [HttpGet("GetFull")]
        public RegistrarVisitaDTO GetFull(int vId)
        {
            return Visita_LN.RecuperarFullVisitaDTOPorCodigo(vId);
        }


        [HttpGet("ListarPaginadoVisitaDTO")]
        public IEnumerable<VisitaDTO> ListarPaginadoVisitaDTO(string vFiltro, string vNroExpediente, int vTipo, int vCantAnios, int vNumPag, int vCantRegxPag)
        {
            return Visita_LN.ListarPaginadoVisitaDTO(vFiltro, vNroExpediente, vTipo, vCantAnios, vNumPag, vCantRegxPag);
        }

    }
}
