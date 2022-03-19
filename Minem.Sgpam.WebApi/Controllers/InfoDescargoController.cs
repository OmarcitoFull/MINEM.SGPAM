using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class InfoDescargoController : BaseController
    {
        public readonly IT_Sgpad_Eum_Info_DescargoLN Eum_Info_DescargoLN;
        public InfoDescargoController(IT_Sgpad_Eum_Info_DescargoLN vIT_Sgpad_Eum_Info_DescargoLN)
        {
            Eum_Info_DescargoLN = vIT_Sgpad_Eum_Info_DescargoLN;
        }

        [HttpGet("List")]
        public IEnumerable<Eum_Info_DescargoDTO> List(int vIdEum)
        {
            return Eum_Info_DescargoLN.ListarPorIdEumEum_Info_DescargoDTO(vIdEum);
        }

        [HttpGet("Get")]
        public Eum_Info_DescargoDTO Get(int vId)
        {
            return Eum_Info_DescargoLN.RecuperarEum_Info_DescargoDTOPorCodigo(vId);
        }


        [HttpPost("Save")]
        public Eum_Info_DescargoDTO Save([FromBody] Eum_Info_DescargoDTO vEum_Info_DescargoDTO)
        {
            return Eum_Info_DescargoLN.GrabarEum_Info_DescargoDTO(vEum_Info_DescargoDTO);
        }

    }
}
