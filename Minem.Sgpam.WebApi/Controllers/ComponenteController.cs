using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    /// <summary>
    /// Objetivo:	Controlador que implementa los servicios
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	31/10/2021
    /// </summary>
    public class ComponenteController : BaseController
    {
        public readonly IT_Sgpad_ComponenteLN ComponenteLN;
        public ComponenteController(IT_Sgpad_ComponenteLN vIT_Sgpad_ComponenteLN)
        {
            ComponenteLN = vIT_Sgpad_ComponenteLN;
        }

        [HttpGet("GetFull")]
        public RegistrarPamDTO GetFull(int vId)
        {
            return ComponenteLN.RecuperarFullComponenteDTOPorCodigo(vId);
        }

        [HttpPost("Save")]
        public ComponenteDTO Save([FromBody] ComponenteDTO vComponenteDTO)
        {
            return ComponenteLN.GrabarComponenteDTO(vComponenteDTO);
        }

        [HttpPost("Remove")]
        public bool Remove([FromBody] ComponenteDTO vComponenteDTO)
        {
            return ComponenteLN.AnularComponenteDTOPorCodigo(vComponenteDTO);
        }

        [HttpGet("ListEum")]
        public IEnumerable<ComponenteMinDTO> ListEum(int vId_Eum)
        {
            return ComponenteLN.ListarComponenteEumDTO(vId_Eum);
        }
    }
}
