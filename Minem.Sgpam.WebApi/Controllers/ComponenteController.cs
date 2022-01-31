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
        public readonly IT_Sgpad_Comp_ReconocimientoLN ReconocimientoLN;

        public ComponenteController(IT_Sgpad_ComponenteLN vIT_Sgpad_ComponenteLN, IT_Sgpad_Comp_ReconocimientoLN vIT_Sgpad_Comp_ReconocimientoLN)
        {
            ComponenteLN = vIT_Sgpad_ComponenteLN;
            ReconocimientoLN = vIT_Sgpad_Comp_ReconocimientoLN;
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

        [HttpPost("InsertRecognition")]
        public Comp_ReconocimientoDTO InsertRecognition([FromBody] Comp_ReconocimientoDTO vComp_ReconocimientoDTO)
        {
            int vResult = ReconocimientoLN.Insertar_Reconocimiento_Tipo(vComp_ReconocimientoDTO);
            vComp_ReconocimientoDTO.Id_Comp_Reconocimiento = (vResult != 0) ? 1 : 0;
            return vComp_ReconocimientoDTO;
        }

        [HttpGet("ListRecognition")]
        public IEnumerable<Comp_ReconocimientoDTO> ListRecognition(int vIdComponente)
        {
            return ReconocimientoLN.ListarComp_ReconocimientoDTO(vIdComponente);
        }
    }
}
