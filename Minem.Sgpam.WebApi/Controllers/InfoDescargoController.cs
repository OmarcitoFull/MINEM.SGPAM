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
    public class InfoDescargoController : BaseController
    {
        public readonly IT_Sgpad_Eum_Info_DescargoLN Eum_Info_DescargoLN;
        public InfoDescargoController(IT_Sgpad_Eum_Info_DescargoLN vIT_Sgpad_Eum_Info_DescargoLN)
        {
            Eum_Info_DescargoLN = vIT_Sgpad_Eum_Info_DescargoLN;
        }

        [HttpGet("List")]
        public IEnumerable<Eum_Info_DescargoDTO> List()
        {
            return Eum_Info_DescargoLN.ListarEum_Info_DescargoDTO();
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

        [HttpPost("Remove")]
        public bool Remove([FromBody] Eum_Info_DescargoDTO vEum_Info_DescargoDTO)
        {
            return Eum_Info_DescargoLN.AnularEum_Info_DescargoDTOPorCodigo(vEum_Info_DescargoDTO);
        }

        [HttpGet("ListPorIdEum")]
        public IEnumerable<Eum_Info_DescargoDTO> ListPorIdEum(int vId_Eum)
        {
            return Eum_Info_DescargoLN.ListarPorIdEumEum_Info_DescargoDTO(vId_Eum);
        }

    }
}
