using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    /// <summary>
    /// Objetivo:	Controlador que implementa los servicios
    /// Creado Por:	Mateo Salvador Paucar
    /// Fecha Creación:	31/12/2021
    /// </summary>
    public class TipoClimaController : BaseController
    {
        public readonly IT_Sgpal_Tipo_ClimaLN Tipo_ClimaN;
        public TipoClimaController(IT_Sgpal_Tipo_ClimaLN vIT_Sgpal_Tipo_ClimaLN)
        {
            Tipo_ClimaN = vIT_Sgpal_Tipo_ClimaLN;
        }

        [HttpGet("List")]
        public IEnumerable<Tipo_ClimaDTO> List()
        {
            return Tipo_ClimaN.ListarTipo_ClimaDTO();
        }
    }
}
