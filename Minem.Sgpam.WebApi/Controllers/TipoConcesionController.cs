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
    public class TipoConcesionController : BaseController
    {
        public readonly IT_Sgpal_Tipo_ConcesionLN Tipo_ConcesionLN;
        public TipoConcesionController(IT_Sgpal_Tipo_ConcesionLN vIT_Sgpal_Tipo_ConcesionLN)
        {
            Tipo_ConcesionLN = vIT_Sgpal_Tipo_ConcesionLN;
        }

        [HttpGet("List")]
        public IEnumerable<Tipo_ConcesionDTO> List()
        {
            return Tipo_ConcesionLN.ListarTipo_ConcesionDTO();
        }
    }
}
