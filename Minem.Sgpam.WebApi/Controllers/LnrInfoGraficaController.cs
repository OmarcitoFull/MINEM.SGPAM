using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class LnrInfoGraficaController : BaseController
    {
        public readonly IT_Sgpad_Lnr_Info_GraficaLN Lnr_Info_GraficaLN;
        public LnrInfoGraficaController(IT_Sgpad_Lnr_Info_GraficaLN vIT_Sgpad_Lnr_Info_GraficaLN)
        {
            Lnr_Info_GraficaLN = vIT_Sgpad_Lnr_Info_GraficaLN;
        }

        [HttpGet("List")]
        public IEnumerable<Lnr_Info_GraficaDTO> List(int vIdLnr)
        {
            return Lnr_Info_GraficaLN.ListarPorIdLnrLnr_Info_GraficaDTO(vIdLnr);
        }

        [HttpGet("Get")]
        public Lnr_Info_GraficaDTO Get(int vId)
        {
            return Lnr_Info_GraficaLN.RecuperarLnr_Info_GraficaDTOPorCodigo(vId);
        }

        //[HttpGet("GetFull")]
        //public RegistrarEumInspeccionDTO GetFull(int vId)
        //{
        //    return Lnr_Info_GraficaLN.RecuperarFullEum_InspeccionDTOPorCodigo(vId);
        //}

        [HttpPost("Save")]
        public Lnr_Info_GraficaDTO Save([FromBody] Lnr_Info_GraficaDTO vLnr_Info_GraficaDTO)
        {
            return Lnr_Info_GraficaLN.GrabarLnr_Info_GraficaDTO(vLnr_Info_GraficaDTO);
        }

    }
}
