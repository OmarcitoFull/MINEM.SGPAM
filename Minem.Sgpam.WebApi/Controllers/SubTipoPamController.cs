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
    public class SubTipoPamController : BaseController
    {
        public readonly IT_Sgpal_Sub_Tipo_PamLN Sub_Tipo_PamLN;
        public SubTipoPamController(IT_Sgpal_Sub_Tipo_PamLN vIT_Sgpal_Sub_Tipo_PamLN)
        {
            Sub_Tipo_PamLN = vIT_Sgpal_Sub_Tipo_PamLN;
        }

        [HttpGet("List")]
        public IEnumerable<Sub_Tipo_PamDTO> List()
        {
            return Sub_Tipo_PamLN.ListarSub_Tipo_PamDTO();
        }
    }
}
