using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    /// <summary>
    /// Objetivo:	Controlador que implementa los servicios
    /// Creado Por:	Mateo Salvador Paucar
    /// Fecha Creación:	31/03/2022
    /// </summary>
    public class EumOperacionController : BaseController
    {
        public readonly IT_Sgpad_Eum_OperacionLN Eum_OperacionLN;
        public EumOperacionController(IT_Sgpad_Eum_OperacionLN vIT_Sgpad_Eum_OperacionLN)
        {
            Eum_OperacionLN = vIT_Sgpad_Eum_OperacionLN;
        }

        [HttpGet("List")]
        public IEnumerable<Eum_OperacionDTO> List()
        {
            return Eum_OperacionLN.ListarEum_OperacionDTO();
        }

        [HttpGet("Get")]
        public Eum_OperacionDTO Get(int vId_Eum_Operacion)
        {
            return Eum_OperacionLN.RecuperarEum_OperacionDTOPorCodigo(vId_Eum_Operacion);
        }

        [HttpPost("Save")]
        public Eum_OperacionDTO Save([FromBody] Eum_OperacionDTO vEum_OperacionDTO)
        {
            return Eum_OperacionLN.GrabarEum_OperacionDTO(vEum_OperacionDTO);
        }

        [HttpPost("Remove")]
        public bool Remove([FromBody] Eum_OperacionDTO vEum_OperacionDTO)
        {
            return Eum_OperacionLN.AnularEum_OperacionDTOPorCodigo(vEum_OperacionDTO);
        }

        [HttpGet("ListPorIdEum")]
        public IEnumerable<Eum_OperacionDTO> ListPorIdEum(int vId_Eum)
        {
            return Eum_OperacionLN.ListarPorIdEumEum_OperacionDTO(vId_Eum);
        }
    }

}
