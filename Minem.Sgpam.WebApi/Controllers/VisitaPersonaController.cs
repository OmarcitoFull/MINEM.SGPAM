using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    /// <summary>
    /// Objetivo:	Controlador que implementa los servicios
    /// Creado Por:	Mateo Salvado Paucar
    /// Fecha Creación:	31/05/2022
    /// </summary>
    public class VisitaPersonaController : BaseController
    {
        public readonly IT_Sgpad_Visita_PersonaLN Visita_PersonaLN;
        public VisitaPersonaController(IT_Sgpad_Visita_PersonaLN vIT_Sgpad_Visita_PersonaLN)
        {
            Visita_PersonaLN = vIT_Sgpad_Visita_PersonaLN;
        }

        [HttpGet("List")]
        public IEnumerable<Visita_PersonaDTO> List()
        {
            return Visita_PersonaLN.ListarVisita_PersonaDTO();
        }

        [HttpGet("Get")]
        public Visita_PersonaDTO Get(int vId)
        {
            return Visita_PersonaLN.RecuperarVisita_PersonaDTOPorCodigo(vId);
        }

        [HttpPost("Save")]
        public Visita_PersonaDTO Save([FromBody] Visita_PersonaDTO vVisita_PersonaDTO)
        {
            return Visita_PersonaLN.GrabarVisita_PersonaDTO(vVisita_PersonaDTO);
        }

        [HttpPost("Remove")]
        public bool Remove([FromBody] Visita_PersonaDTO vVisita_PersonaDTO)
        {
            return Visita_PersonaLN.AnularVisita_PersonaDTOPorCodigo(vVisita_PersonaDTO);
        }

        [HttpGet("ListPorIdVisita")]
        public IEnumerable<Visita_PersonaDTO> ListPorIdVisita(int vId_Visita)
        {
            return Visita_PersonaLN.ListarPorIdVisitaVisita_PersonaDTO(vId_Visita);
        }

        [HttpGet("GetFull")]
        public RegistrarVisitaPersonaDTO GetFull(int vId)
        {
            return Visita_PersonaLN.RecuperarFullVisita_PersonaDTOPorCodigo(vId);
        }
    }

}
