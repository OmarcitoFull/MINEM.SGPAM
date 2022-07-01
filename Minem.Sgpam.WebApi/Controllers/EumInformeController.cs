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
    public class EumInformeController : BaseController
    {
        public readonly IT_Sgpad_Eum_InformeLN Eum_InformeLN;
        public EumInformeController(IT_Sgpad_Eum_InformeLN vIT_Sgpad_Eum_InformeLN)
        {
            Eum_InformeLN = vIT_Sgpad_Eum_InformeLN;
        }

        [HttpGet("List")]
        public IEnumerable<Eum_InformeDTO> List()
        {
            return Eum_InformeLN.ListarEum_InformeDTO();
        }

        [HttpGet("Get")]
        public Eum_InformeDTO Get(int vId)
        {
            return Eum_InformeLN.RecuperarEum_InformeDTOPorCodigo(vId);
        }

        [HttpPost("Save")]
        public Eum_InformeDTO Save([FromBody] Eum_InformeDTO vEum_InformeDTO)
        {
            return Eum_InformeLN.GrabarEum_InformeDTO(vEum_InformeDTO);
        }

        [HttpPost("Remove")]
        public bool Remove([FromBody] Eum_InformeDTO vEum_InformeDTO)
        {
            return Eum_InformeLN.AnularEum_InformeDTOPorCodigo(vEum_InformeDTO);
        }

        [HttpGet("ListPorIdEum")]
        public IEnumerable<Eum_InformeDTO> ListPorIdEum(int vId_Eum)
        {
            return Eum_InformeLN.ListarPorIdEumEum_InformeDTO(vId_Eum);
        }

    }
}
