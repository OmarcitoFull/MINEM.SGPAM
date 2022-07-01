using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    /// <summary>
    /// Objetivo:	Controlador que implementa los servicios
    /// Creado Por:	Mateo Salvador Paucar
    /// Fecha Creación:	30/05/2022
    /// </summary>
    public class VisitaDetController : BaseController
    {
        public readonly IT_Sgpaj_Visita_DetLN Visita_DetLN;
        public VisitaDetController(IT_Sgpaj_Visita_DetLN vIT_Sgpaj_Visita_DetLN)
        {
            Visita_DetLN = vIT_Sgpaj_Visita_DetLN;
        }

        [HttpGet("List")]
        public IEnumerable<Visita_DetDTO> List()
        {
            return Visita_DetLN.ListarVisita_DetDTO();
        }

        [HttpGet("Get")]
        public Visita_DetDTO Get(int vId)
        {
            return Visita_DetLN.RecuperarVisita_DetDTOPorCodigo(vId);
        }

        [HttpPost("Save")]
        public Visita_DetDTO Save([FromBody] Visita_DetDTO vVisita_DetDTO)
        {
            return Visita_DetLN.GrabarVisita_DetDTO(vVisita_DetDTO);
        }

        [HttpPost("Remove")]
        public bool Remove([FromBody] Visita_DetDTO vVisita_DetDTO)
        {
            return Visita_DetLN.AnularVisita_DetDTOPorCodigo(vVisita_DetDTO);
        }

        [HttpGet("ListPorIdVisita")]
        public IEnumerable<Visita_DetDTO> ListPorIdVisita(int vId_Visita)
        {
            return Visita_DetLN.ListarPorIdVisitaVisita_DetDTO(vId_Visita);
        }

        [HttpGet("GetFull")]
        public RegistrarVisitaDetDTO GetFull(int vId)
        {
            return Visita_DetLN.RecuperarFullVisita_DetDTOPorCodigo(vId);
        }
    }
}
