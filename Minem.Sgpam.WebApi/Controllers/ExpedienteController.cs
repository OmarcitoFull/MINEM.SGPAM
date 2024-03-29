﻿using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class ExpedienteController : BaseController
    {
        public readonly IT_Sgpam_ExpedienteLN Expediente_LN;
        public ExpedienteController(IT_Sgpam_ExpedienteLN vIT_Sgpam_ExpedienteLN)
        {
            Expediente_LN = vIT_Sgpam_ExpedienteLN;
        }

        [HttpGet("List")]
        public IEnumerable<ExpedienteDTO> List()
        {
            return Expediente_LN.ListarExpedienteDTO();
        }

        [HttpGet("Get")]
        public ExpedienteDTO Get(int vId)
        {
            return Expediente_LN.RecuperarExpedienteDTOPorCodigo(vId);
        }

        [HttpPost("Save")]
        public ExpedienteDTO Save([FromBody] ExpedienteDTO vExpedienteDTO)
        {
            return Expediente_LN.GrabarExpedienteDTO(vExpedienteDTO);
        }

        [HttpGet("GetFull")]
        public RegistrarExpedienteDTO GetFull(int vId)
        {
            return Expediente_LN.RecuperarFullExpedienteDTOPorCodigo(vId);
        }

        [HttpGet("ListarPaginadoExpedienteDTO")]
        public IEnumerable<ExpedienteDTO> ListarPaginadoExpedienteDTO(string vNroExp, string vZona, string vUbigeo, int vNumPag, int vCantRegxPag)
        {
            return Expediente_LN.ListarPaginadoExpedienteDTO(vNroExp, vZona, vUbigeo, vNumPag, vCantRegxPag);
        }

        [HttpGet("ListaAutocompletar")]
        public IEnumerable<ExpedienteDTO> ListaAutocompletarExpedienteDTO(string vFiltro)
        {
            return Expediente_LN.ListaAutocompletarExpedienteDTO(vFiltro);
        }

    }
}
