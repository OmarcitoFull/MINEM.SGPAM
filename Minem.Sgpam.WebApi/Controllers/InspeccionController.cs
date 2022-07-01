using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    /// <summary>
    /// Objetivo:	Controlador que implementa los servicios
    /// Creado Por:	Mateo Salvado Paucar
    /// Fecha Creación:	31/12/2021
    /// </summary>
    public class InspeccionController : BaseController
    {
        public readonly IT_Sgpad_Eum_InspeccionLN InspeccionLN;
        public InspeccionController(IT_Sgpad_Eum_InspeccionLN vIT_Sgpad_Eum_InspeccionLN)
        {
            InspeccionLN = vIT_Sgpad_Eum_InspeccionLN;
        }

        [HttpGet("List")]
        public IEnumerable<Eum_InspeccionDTO> List()
        {
            return InspeccionLN.ListarEum_InspeccionDTO();
        }

        [HttpGet("Get")]
        public Eum_InspeccionDTO Get(int vId)
        {
            return InspeccionLN.RecuperarEum_InspeccionDTOPorCodigo(vId);
        }

        [HttpPost("Save")]
        public Eum_InspeccionDTO Save([FromBody] Eum_InspeccionDTO vEum_InspeccionDTO)
        {
            return InspeccionLN.GrabarEum_InspeccionDTO(vEum_InspeccionDTO);
        }

        [HttpPost("Remove")]
        public bool Remove([FromBody] Eum_InspeccionDTO vEum_InspeccionDTO)
        {
            return InspeccionLN.AnularEum_InspeccionDTOPorCodigo(vEum_InspeccionDTO);
        }

        [HttpGet("ListPorIdEum")]
        public IEnumerable<Eum_InspeccionDTO> ListPorIdEum(int vId_Eum)
        {
            return InspeccionLN.ListarPorIdEumEum_InspeccionDTO(vId_Eum);
        }

        [HttpGet("GetFull")]
        public RegistrarEumInspeccionDTO GetFull(int vId)
        {
            return InspeccionLN.RecuperarFullEum_InspeccionDTOPorCodigo(vId);
        }
    }

}
