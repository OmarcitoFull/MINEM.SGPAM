using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class InformacionGraficaController : BaseController
    {
        public readonly IT_Sgpad_Comp_Info_GraficaLN Comp_Info_GraficaLN;
        public InformacionGraficaController(IT_Sgpad_Comp_Info_GraficaLN vIT_Sgpad_Comp_Info_GraficaLN)
        {
            Comp_Info_GraficaLN = vIT_Sgpad_Comp_Info_GraficaLN;
        }

        [HttpGet("List")]
        public IEnumerable<Comp_Info_GraficaDTO> List(int vIdComponente)
        {
            return Comp_Info_GraficaLN.ListarComp_Info_GraficaDTO(vIdComponente);
        }

        [HttpPost("Save")]
        public Comp_Info_GraficaDTO Save([FromBody] Comp_Info_GraficaDTO vComp_Info_GraficaDTO)
        {
            return Comp_Info_GraficaLN.GrabarComp_Info_GraficaDTO(vComp_Info_GraficaDTO);
        }
    }
}
