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
    public class ComentarioController : BaseController
    {
        public readonly IT_Sgpad_Comp_ComentarioLN Comp_ComentarioLN;
        public ComentarioController(IT_Sgpad_Comp_ComentarioLN vIT_Sgpad_Comp_ComentarioLN)
        {
            Comp_ComentarioLN = vIT_Sgpad_Comp_ComentarioLN;
        }

        [HttpGet("List")]
        public IEnumerable<Comp_ComentarioDTO> List(int vIdComponente)
        {
            return Comp_ComentarioLN.ListarComp_ComentarioDTO(vIdComponente);
        }

        [HttpPost("Save")]
        public Comp_ComentarioDTO Save([FromBody] Comp_ComentarioDTO vComp_ComentarioDTO)
        {
            return Comp_ComentarioLN.GrabarComp_ComentarioDTO(vComp_ComentarioDTO);
        }
    }
}
