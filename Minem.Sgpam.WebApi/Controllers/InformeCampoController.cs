using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    /// <summary>
    /// Objetivo:	Controlador que implementa los servicios
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	31/10/2021
    /// </summary>
    public class InformeCampoController : BaseController
    {
        public readonly IT_Sgpad_Comp_Info_CampoLN Comp_Info_CampoLN;
        public InformeCampoController(IT_Sgpad_Comp_Info_CampoLN vIT_Sgpad_Comp_Info_CampoLN)
        {
            Comp_Info_CampoLN = vIT_Sgpad_Comp_Info_CampoLN;
        }

        [HttpGet("List")]
        public IEnumerable<Comp_Info_CampoDTO> List(int vIdComponente)
        {
            return Comp_Info_CampoLN.ListarComp_Info_CampoDTO(vIdComponente);
        }

        [HttpPost("Save")]
        public Comp_Info_CampoDTO Save([FromBody] Comp_Info_CampoDTO vComp_Info_CampoDTO)
        {
            return Comp_Info_CampoLN.GrabarComp_Info_CampoDTO(vComp_Info_CampoDTO);
        }
    }
}
