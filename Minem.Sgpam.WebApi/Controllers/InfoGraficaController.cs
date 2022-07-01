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
    public class InfoGraficaController : BaseController
    {
        public readonly IT_Sgpad_Eum_Info_GraficaLN Eum_Info_GraficaLN;
        public InfoGraficaController(IT_Sgpad_Eum_Info_GraficaLN vIT_Sgpad_Eum_Info_GraficaLN)
        {
            Eum_Info_GraficaLN = vIT_Sgpad_Eum_Info_GraficaLN;
        }

        [HttpGet("List")]
        public IEnumerable<Eum_Info_GraficaDTO> List()
        {
            return Eum_Info_GraficaLN.ListarEum_Info_GraficaDTO();
        }

        [HttpGet("Get")]
        public Eum_Info_GraficaDTO Get(int vId)
        {
            return Eum_Info_GraficaLN.RecuperarEum_Info_GraficaDTOPorCodigo(vId);
        }

        [HttpPost("Save")]
        public Eum_Info_GraficaDTO Save([FromBody] Eum_Info_GraficaDTO vEum_Info_GraficaDTO)
        {
            return Eum_Info_GraficaLN.GrabarEum_Info_GraficaDTO(vEum_Info_GraficaDTO);
        }

        [HttpPost("Remove")]
        public bool Remove([FromBody] Eum_Info_GraficaDTO vEum_Info_GraficaDTO)
        {
            return Eum_Info_GraficaLN.AnularEum_Info_GraficaDTOPorCodigo(vEum_Info_GraficaDTO);
        }

        [HttpGet("ListPorIdEum")]
        public IEnumerable<Eum_Info_GraficaDTO> ListPorIdEum(int vId_Eum)
        {
            return Eum_Info_GraficaLN.ListarPorIdEumEum_Info_GraficaDTO(vId_Eum);
        }


    }
}
