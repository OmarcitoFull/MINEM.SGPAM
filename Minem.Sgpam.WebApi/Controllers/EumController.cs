using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class EumController : BaseController
    {
        public readonly IT_Sgpam_MaestraLN Eum_LN;
        public readonly IT_Sgpah_Eum_ModLN Eum_ModLN;

        public EumController(IT_Sgpam_MaestraLN vIT_Sgpam_MaestraLN, IT_Sgpah_Eum_ModLN vIT_Sgpah_Eum_ModLN)
        {
            Eum_LN = vIT_Sgpam_MaestraLN;
            Eum_ModLN = vIT_Sgpah_Eum_ModLN;
        }

        [HttpGet("List")]
        public IEnumerable<MaestraDTO> List()
        {
            return Eum_LN.ListarMaestraDTO();
        }

        [HttpGet("Get")]
        public MaestraDTO Get(int vId)
        {
            return Eum_LN.RecuperarMaestraDTOPorCodigo(vId);
        }

        [HttpPost("Save")]
        public MaestraDTO Save([FromBody] MaestraDTO vMaestraDTO)
        {
            return Eum_LN.GrabarMaestraDTO(vMaestraDTO);
        }

        [HttpGet("GetFull")]
        public RegistrarEumDTO GetFull(int vId)
        {
            return Eum_LN.RecuperarFullMaestraDTOPorCodigo(vId);
        }

        [HttpGet("ListarPaginadoMaestraDTO")]
        public IEnumerable<MaestraDTO> ListarPaginadoMaestraDTO(string vFiltro, string vUbigeo, int vNumPag, int vCantRegxPag)
        {
            return Eum_LN.ListarPaginadoMaestraDTO(vFiltro, vUbigeo, vNumPag, vCantRegxPag);
        }

        [HttpGet("ListaAutocompletar")]
        public IEnumerable<MaestraDTO> ListaAutocompletarMaestraDTO(string vFiltro)
        {
            return Eum_LN.ListaAutocompletarMaestraDTO(vFiltro);
        }

    }
}
