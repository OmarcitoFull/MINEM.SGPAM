using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class InfoGraficaController : BaseController
    {
        public readonly IT_Sgpad_Eum_Info_GraficaLN Eum_Info_GraficaLN;
        public InfoGraficaController(IT_Sgpad_Eum_Info_GraficaLN vIT_Sgpad_Eum_Info_GraficaLN)
        {
            Eum_Info_GraficaLN = vIT_Sgpad_Eum_Info_GraficaLN;
        }

        [HttpGet("List")]
        public IEnumerable<Eum_Info_GraficaDTO> List(int vIdEum)
        {
            return Eum_Info_GraficaLN.ListarPorIdEumEum_Info_GraficaDTO(vIdEum);
        }

        [HttpGet("Get")]
        public Eum_Info_GraficaDTO Get(int vId)
        {
            return Eum_Info_GraficaLN.RecuperarEum_Info_GraficaDTOPorCodigo(vId);
        }

        //[HttpGet("GetFull")]
        //public RegistrarEumInspeccionDTO GetFull(int vId)
        //{
        //    return InspeccionLN.RecuperarFullEum_InspeccionDTOPorCodigo(vId);
        //}


        //[HttpPost("Save")]
        //public Eum_Info_GraficaDTO Save([FromBody] Eum_Info_GraficaDTO vEum_Info_GraficaDTO)
        //{
        //    return Eum_Info_GraficaLN.GrabarComp_Info_GraficaDTO(vEum_Info_GraficaDTO);
        //}
    }
}
