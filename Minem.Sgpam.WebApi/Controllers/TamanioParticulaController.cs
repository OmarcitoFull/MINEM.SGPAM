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
    public class TamanioParticulaController : BaseController
    {
        public readonly IT_Sgpal_Tamano_ParticulaLN Tamano_ParticulaLN;
        public TamanioParticulaController(IT_Sgpal_Tamano_ParticulaLN vIT_Sgpal_Tamano_ParticulaLN)
        {
            Tamano_ParticulaLN = vIT_Sgpal_Tamano_ParticulaLN;
        }

        [HttpGet("List")]
        public IEnumerable<Tamano_ParticulaDTO> List()
        {
            return Tamano_ParticulaLN.ListarTamano_ParticulaDTO();
        }
    }
}
