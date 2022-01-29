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
    public class ResultadoController : BaseController
    {
        public readonly IT_Sgpad_Comp_ResultadoLN Comp_ResultadoLN;
        public ResultadoController(IT_Sgpad_Comp_ResultadoLN vIT_Sgpad_Comp_ResultadoLN)
        {
            Comp_ResultadoLN = vIT_Sgpad_Comp_ResultadoLN;
        }

        [HttpGet("List")]
        public IEnumerable<Comp_ResultadoResumenDTO> List(int vIdComponente)
        {
            return Comp_ResultadoLN.ListarComp_ResultadoDTO(vIdComponente);
        }

        [HttpPost("Save")]
        public Comp_ResultadoDTO Save([FromBody] Comp_ResultadoDTO vComp_ResultadoDTO)
        {
            return Comp_ResultadoLN.GrabarComp_ResultadoDTO(vComp_ResultadoDTO);
        }
    }
}
