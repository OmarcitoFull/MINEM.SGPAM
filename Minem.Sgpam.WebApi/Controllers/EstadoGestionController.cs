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
    public class EstadoGestionController : BaseController
    {
        public readonly IT_Sgpad_Comp_Est_GestionLN Comp_Est_GestionLN;
        public EstadoGestionController(IT_Sgpad_Comp_Est_GestionLN vIT_Sgpad_Comp_Est_GestionLN)
        {
            Comp_Est_GestionLN = vIT_Sgpad_Comp_Est_GestionLN;
        }

        [HttpGet("List")]
        public IEnumerable<Comp_Est_GestionDTO> List(int vIdComponente)
        {
            return Comp_Est_GestionLN.ListarComp_Est_GestionDTO(vIdComponente);
        }

        [HttpPost("Save")]
        public Comp_Est_GestionDTO Save([FromBody] Comp_Est_GestionDTO vComp_Est_GestionDTO)
        {
            return Comp_Est_GestionLN.GrabarComp_Est_GestionDTO(vComp_Est_GestionDTO);
        }
    }
}
